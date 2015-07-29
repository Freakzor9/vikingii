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
    public partial class FrmEditare : Form
    {
        public FrmEditare()
        {
            InitializeComponent();
        }
        Point lastPoint;
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        public int intrebare = 0;
        private void FrmEditare_Load(object sender, EventArgs e)
        {
            rbA.Checked = true;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from Intrebari";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                lbIntrebari.Items.Add(r["Intrebare"].ToString());
                lbR1.Items.Add(r["R1"].ToString());
                lbR2.Items.Add(r["R2"].ToString());
                lbR3.Items.Add(r["R3"].ToString());
                lbR4.Items.Add(r["R4"].ToString());
                lbID.Items.Add(r["ID"].ToString());
                lbRC.Items.Add(r["RCorect"].ToString());
            }
            lbIntrebari.Items.Add("                                        [Adauga o intrebare]");
        }

        private void lbIntrebari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbIntrebari.SelectedIndex == -1)
            {
                return;
            }
            if (lbIntrebari.SelectedIndex == lbIntrebari.Items.Count - 1)
            {
                tbIntrebare.Text = "";
                tbr1.Text = "";
                tbr2.Text = "";
                tbr3.Text = "";
                tbr4.Text = "";
            }
            else
            {
                tbIntrebare.Text = lbIntrebari.Items[lbIntrebari.SelectedIndex].ToString();
                tbr1.Text = lbR1.Items[lbIntrebari.SelectedIndex].ToString();
                tbr2.Text = lbR2.Items[lbIntrebari.SelectedIndex].ToString();
                tbr3.Text = lbR3.Items[lbIntrebari.SelectedIndex].ToString();
                tbr4.Text = lbR4.Items[lbIntrebari.SelectedIndex].ToString();
                if (lbRC.Items[lbIntrebari.SelectedIndex].ToString() == tbr1.Text)
                {
                    rbA.Checked = true;
                }
                if (lbRC.Items[lbIntrebari.SelectedIndex].ToString() == tbr2.Text)
                {
                    rbB.Checked = true;
                }
                if (lbRC.Items[lbIntrebari.SelectedIndex].ToString() == tbr3.Text)
                {
                    rbC.Checked = true;
                }
                if (lbRC.Items[lbIntrebari.SelectedIndex].ToString() == tbr4.Text)
                {
                    rbD.Checked = true;
                }
            }
        }

        public void incarca_intrebare()
        {
            lbIntrebari.Items.Clear();
            lbR1.Items.Clear();
            lbR2.Items.Clear();
            lbR3.Items.Clear();
            lbR4.Items.Clear();
            lbID.Items.Clear();
        }






        private void FrmEditare_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Main)this.MdiParent).fCopil8 = null;
        }


        private void pbAdaugare_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Insert into Intrebari (Intrebare,R1,R2,R3,R4,RCorect) values(@int,@R1,@R2,@R3,@R4,@RC)";
            OleDbCommand com = new OleDbCommand(qs, con);
            com.Parameters.AddWithValue("Intrebare", tbIntrebare.Text);
            com.Parameters.AddWithValue("R1", tbr1.Text);
            com.Parameters.AddWithValue("R2", tbr2.Text);
            com.Parameters.AddWithValue("R3", tbr3.Text);
            com.Parameters.AddWithValue("R4", tbr4.Text);
            if (rbA.Checked == true)
            {
                com.Parameters.AddWithValue("RCorect", tbr1.Text);
            }
            if (rbB.Checked == true)
            {
                com.Parameters.AddWithValue("RCorect", tbr2.Text);
            }
            if (rbC.Checked == true)
            {
                com.Parameters.AddWithValue("RCorect", tbr3.Text);
            }
            if (rbD.Checked == true)
            {
                com.Parameters.AddWithValue("RCorect", tbr4.Text);
            }
            int asd = com.ExecuteNonQuery();
            con.Close();

            incarca_intrebare();

            OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con2.Open();
            string text = "select * from Intrebari";
            OleDbCommand com2 = new OleDbCommand(text, con2);
            OleDbDataReader r = com2.ExecuteReader();
            while (r.Read())
            {
                lbIntrebari.Items.Add(r["Intrebare"].ToString());
                lbR1.Items.Add(r["R1"].ToString());
                lbR2.Items.Add(r["R2"].ToString());
                lbR3.Items.Add(r["R3"].ToString());
                lbR4.Items.Add(r["R4"].ToString());
                lbID.Items.Add(r["ID"].ToString());
                lbRC.Items.Add(r["RCorect"].ToString());
            }
            lbIntrebari.Items.Add("                                        [Adauga o intrebare]");
            MessageBox.Show("Intrebare adaugata!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Delete from Intrebari where ID=" + lbID.Items[lbIntrebari.SelectedIndex].ToString();
            OleDbCommand com = new OleDbCommand(qs, con);
            int asd = com.ExecuteNonQuery();
            con.Close();


            incarca_intrebare();

            OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con2.Open();
            string text = "select * from Intrebari";
            OleDbCommand com2 = new OleDbCommand(text, con2);
            OleDbDataReader r = com2.ExecuteReader();
            while (r.Read())
            {
                lbIntrebari.Items.Add(r["Intrebare"].ToString());
                lbR1.Items.Add(r["R1"].ToString());
                lbR2.Items.Add(r["R2"].ToString());
                lbR3.Items.Add(r["R3"].ToString());
                lbR4.Items.Add(r["R4"].ToString());
                lbID.Items.Add(r["ID"].ToString());
            }
            lbIntrebari.Items.Add("                                        [Adauga o intrebare]");

            MessageBox.Show("Intrebare stersa!");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (lbIntrebari.SelectedIndex == -1)
            {
                return;
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Update Intrebari SET Intrebare=@intrebare,R1=@R1,R2=@R2,R3=@R3,R4=@R4,RCorect=@RC where ID=@ID";
            OleDbCommand com = new OleDbCommand(qs, con);
            com.Parameters.AddWithValue("Intrebare", tbIntrebare.Text);
            com.Parameters.AddWithValue("R1", tbr1.Text);
            com.Parameters.AddWithValue("R2", tbr2.Text);
            com.Parameters.AddWithValue("R3", tbr3.Text);
            com.Parameters.AddWithValue("R4", tbr4.Text);
            if (rbA.Checked == true)
            {
                com.Parameters.AddWithValue("RCorect", tbr1.Text);
            }
            if (rbB.Checked == true)
            {
                com.Parameters.AddWithValue("RCorect", tbr2.Text);
            }
            if (rbC.Checked == true)
            {
                com.Parameters.AddWithValue("RCorect", tbr3.Text);
            }
            if (rbD.Checked == true)
            {
                com.Parameters.AddWithValue("RCorect", tbr4.Text);
            }
            com.Parameters.AddWithValue("ID", lbID.Items[lbIntrebari.SelectedIndex].ToString());
            com.ExecuteNonQuery();
            con.Close();
            incarca_intrebare();

            OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con2.Open();
            string text = "select * from Intrebari";
            OleDbCommand com2 = new OleDbCommand(text, con2);
            OleDbDataReader r = com2.ExecuteReader();
            while (r.Read())
            {
                lbIntrebari.Items.Add(r["Intrebare"].ToString());
                lbR1.Items.Add(r["R1"].ToString());
                lbR2.Items.Add(r["R2"].ToString());
                lbR3.Items.Add(r["R3"].ToString());
                lbR4.Items.Add(r["R4"].ToString());
                lbID.Items.Add(r["ID"].ToString());
            }
            lbIntrebari.Items.Add("                                        [Adauga o intrebare]");

            MessageBox.Show("Intrebare modificata!");
        }

        private void FrmEditare_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void FrmEditare_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
