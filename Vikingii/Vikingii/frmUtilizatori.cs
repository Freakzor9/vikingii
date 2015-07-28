using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Imperiul_Britanic
{
    public partial class frmUtilizatori : Form
    {
        public frmUtilizatori()
        {
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void clase()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select Distinct Clasa from Utilizatori";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                comboBox1.Items.Add(r["Clasa"].ToString());
            }
        }
        private void schimbareCombo(int slct)
        {
            if (slct == -1)
            {
                return;
            }
            lstUseri.Items.Clear();
            lstNume.Items.Clear();
            lstGen.Items.Clear();
            lstClasa.Items.Clear();
            lstAcceptat.Items.Clear();
            lstAcces.Items.Clear();
            lstImagini.Items.Clear();
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "";
            if (slct == 0)
            {
                text = "select * from Utilizatori";
            }
            else
            {
                text = "select * from Utilizatori where Clasa='" + comboBox1.Items[slct].ToString()+"'";
            }
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                lstUseri.Items.Add(r["Nume"].ToString());
                lstNume.Items.Add(r["Mail"].ToString());
                lstGen.Items.Add(r["Gen"].ToString());
                lstClasa.Items.Add(r["Clasa"].ToString());
                lstAcceptat.Items.Add(r["Acceptat"].ToString());
                lstAcces.Items.Add(r["Acces"].ToString());
                if (r["Imagine"].ToString() != "")
                {
                    lstImagini.Items.Add(r["Imagine"].ToString());
                }
                else
                {
                    lstImagini.Items.Add("<placeholder>");
                }
            }
        }
        private void frmUtilizatori_Load(object sender, EventArgs e)
        {
            clase();
           comboBox1.SelectedIndex = 0;
            //schimbareCombo(0);
        }

        private void lstUseri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUseri.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                lblPic.Image = null;
                label2.Text = lstNume.Items[lstUseri.SelectedIndex].ToString();
                label8.Text = lstClasa.Items[lstUseri.SelectedIndex].ToString();
                label9.Text = lstAcces.Items[lstUseri.SelectedIndex].ToString();
                label10.Text = lstGen.Items[lstUseri.SelectedIndex].ToString();

                lstNote.Items.Clear();
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                con.Open();
                string text = "select * from Scoruri where Mail=@mail";
                OleDbCommand com = new OleDbCommand(text, con);
                com.Parameters.AddWithValue("Mail", lstNume.Items[lstUseri.SelectedIndex]);
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    lstNote.Items.Add(r["Joc"].ToString() + " Scor:" + r["Scor"] + " " + r["Data"].ToString() + "\r\n");
                }
                con.Close();
                r.Close();

                if (lstImagini.Items[lstUseri.SelectedIndex].ToString() != "<placeholder>")
                {
                    lblPic.Image = System.Drawing.Image.FromFile(cale + lstImagini.Items[lstUseri.SelectedIndex].ToString());
                }
                if (lstAcceptat.Items[lstUseri.SelectedIndex].ToString() == "1")
                {
                    rbA.Checked = true;
                    radioButton1.Checked = false;
                }
                else
                {
                    radioButton1.Checked = true;
                    rbA.Checked = false;
                }
            }
        }

        private void frmUtilizatori_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Main)this.MdiParent).fCopil15 = null;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAcceptat.Items.Clear();
            lstAcces.Items.Clear();
            lstClasa.Items.Clear();
            lstGen.Items.Clear();
            lstNume.Items.Clear();
            lstUseri.Items.Clear();
            schimbareCombo(comboBox1.SelectedIndex);
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Update Utilizatori SET Acceptat=@acceptat where Mail=@mail";
            OleDbCommand com = new OleDbCommand(qs, con);
            if (rbA.Checked == true)
            {
                rbA.Checked = true;
                radioButton1.Checked = false;
                com.Parameters.AddWithValue("Acceptat", 1);
                com.Parameters.AddWithValue("Mail", lstNume.Items[lstUseri.SelectedIndex]);
            }
            else
            {

                rbA.Checked = false;
                radioButton1.Checked = true;
                com.Parameters.AddWithValue("Acceptat", 0);
                com.Parameters.AddWithValue("Mail", lstNume.Items[lstUseri.SelectedIndex]);
            }
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
