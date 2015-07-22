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
    public partial class frmHang : Form
    {
        public frmHang()
        {
            InitializeComponent();
        }
        public int idl ; public int contor = 0;
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void frmHang_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from Intrebari where IDL ="+ idl.ToString()+" order by rnd(IDL)";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                lstQ.Items.Add(r["Intrebare"].ToString());
                lstR1.Items.Add(r["R1"].ToString());
                lstR2.Items.Add(r["R2"].ToString());
                lstR3.Items.Add(r["R3"].ToString());
                lstR4.Items.Add(r["R4"].ToString());
                lstRC.Items.Add(r["RCorect"].ToString());
            }
            lblQ.Text = lstQ.Items[contor].ToString();
            btn1.Text = lstR1.Items[contor].ToString();
            btn2.Text = lstR2.Items[contor].ToString();
            btn3.Text = lstR3.Items[contor].ToString();
            btn4.Text = lstR4.Items[contor].ToString();
            RC.Text = lstRC.Items[contor].ToString();
        }
        private void schimba()
        {
            lblQ.Text = lstQ.Items[contor].ToString();
            btn1.Text = lstR1.Items[contor].ToString();
            btn2.Text = lstR2.Items[contor].ToString();
            btn3.Text = lstR3.Items[contor].ToString();
            btn4.Text = lstR4.Items[contor].ToString();
            RC.Text = lstRC.Items[contor].ToString();
        }
        private void lstR4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int greseli = 0,cor=0;
        private void verifica()
        {
            if (greseli == 3)
            {
                MessageBox.Show("Ai pierdut...");
                lblQ.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
            }
            else
            {
                if (contor == 3)
                {
                    MessageBox.Show("Ai raspuns corect la " + (3 - greseli).ToString() + " intrebari");
                    lblQ.Enabled = false;
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                }
                else
                {
                    schimba();
                }
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == RC.Text)
            {
                cor++;
                pbHang.Image = new Bitmap(cale + "\\hang\\" + cor.ToString() + ".png");
                MessageBox.Show("Corect!");
                
            }
            else
            {
                greseli++;
            }
            contor++;
            verifica();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == RC.Text)
            {
                MessageBox.Show("Corect!");
                cor++;
                pbHang.Image = new Bitmap(cale + "\\hang\\" + cor.ToString() + ".png");
            }
            else
            {
                greseli++;
            }
            contor++;
            verifica();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == RC.Text)
            {
                MessageBox.Show("Corect!");
                cor++;
                pbHang.Image = new Bitmap(cale + "\\hang\\" + cor.ToString() + ".png");
            }
            else
            {
                greseli++;
                
            }
            contor++;
            verifica();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == RC.Text)
            {
                MessageBox.Show("Corect!");
                cor++;
                pbHang.Image = new Bitmap(cale + "\\hang\\" + cor.ToString() + ".png");
            }
            else
            {
                greseli++;
                
            }
            contor++;
            verifica();
        }
    }
}
