using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Imperiul_Britanic
{
    public partial class frmSpanzura : Form
    {
        public frmSpanzura()
        {
            InitializeComponent();
        }
        string cuvant = "";
        int indice = 0;
        string[] cuvinte = new string[11];
        string diacritice = "ÀÁÂÇÊÉÈÔÛÙ";
        Label[] litera = new Label[30];
        Label[] abcd = new Label[40];
        int nrgreseli = 0, jocC = 0, jocP = 0, maxg = 6;
        int nrcuv = 0;
        
        private void frmSpanzura_Load(object sender, EventArgs e)
        {
            string cale = Path.GetDirectoryName(Application.ExecutablePath);
           OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
           string qs = "Select count(*) as nr from Hang";
            OleDbCommand com = new OleDbCommand(qs, con);
            con.Open();
            OleDbDataReader q = com.ExecuteReader();
            if (q.Read())
            {

                nrcuv = Convert.ToInt16(q["nr"].ToString());
            }
            //panel1.Visible = false;
            int i, x = 100, y = 345;
            for (i = 0; i < 20; i++)
            {
                litera[i] = new Label();
                this.Controls.Add(litera[i]);
                litera[i].Size = new Size(20, 20);
                litera[i].Location = new Point(x, y);
                litera[i].Tag = i.ToString();
                x += 23;
                litera[i].BackColor = Color.Transparent;
                litera[i].ForeColor = Color.Green;
                litera[i].Font = lblModel.Font;//new Font("Jokerman", 19);
                litera[i].Click += new System.EventHandler(litera_Click);
                litera[i].Text = "_";
            }
            x = 100; y = 80;


            for (i = 0; i < 26; i++)
            {
                abcd[i] = new Label();
                this.Controls.Add(this.abcd[i]);
                abcd[i].Size = new Size(20, 20);
                abcd[i].Location = new Point(x, y);
                abcd[i].Tag = i.ToString();
                x += 23;
                if (i == 12 || i == 25) { y += 23; x = 100 + (i == 25 ? 35 : 0); }

                abcd[i].BackColor = Color.Transparent;
                abcd[i].ForeColor = Color.Firebrick;
                abcd[i].Font = lblModel.Font;
                //abcd[i].Font = new Font("Jokerman", 21);
                if (i < 26)
                    abcd[i].Text = Convert.ToChar(i + 65).ToString();
                else
                    abcd[i].Text = diacritice.Substring(i - 26, 1);
                abcd[i].Click += new System.EventHandler(abcd_Click);
                abcd[i].MouseHover += new System.EventHandler(abcd_MouseHover);
                abcd[i].MouseLeave += new System.EventHandler(abcd_MouseLeave);

            }
            completeaza();
            jocnou();
        }
        private void abcd_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(((Label)sender).Tag);
            abcd[i].Enabled = false;
            indice = i;
            cautL(((char)(i + 'A')).ToString());



        }
        private void litera_Click(object sender, EventArgs e)
        {
            // int i = Convert.ToInt16(((Label)sender).Tag);
            //MessageBox.Show(((char)(i+'A')).ToString());
        }

        private void abcd_MouseHover(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(((Label)sender).Tag);
            abcd[i].ForeColor = Color.White;
        }
        private void abcd_MouseLeave(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(((Label)sender).Tag);
            abcd[i].ForeColor = Color.Firebrick;
        }
        private void completeaza()
        {
            int i;
            for (i = 'A'; i <= 'Z'; i++)
                abcd[i - 'A'].Text = ((char)i).ToString();
        }
        void comp(string x)
        {
            int i;
            for (i = 0; i < x.Length; i++)
            {
                litera[i].Text = "_";//x.Substring(i,1);
                litera[i].Visible = true;
            }
            for (; i < 20; i++)
            {
                litera[i].Visible = false;
            }

        }
        private void jocnou()
        {
            int i;
            string cale = Path.GetDirectoryName(Application.ExecutablePath);
            for (i = 0; i < 26; i++)
            {
                abcd[i].Enabled = true;
            }
            nrgreseli = 0; 
            pbG.Image = new Bitmap("art\\h" + nrgreseli + ".gif");
            Random r = new Random();
            int k = r.Next(1, nrcuv);
            i = 0;

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            string qs = "Select * from Hang ";
            OleDbCommand com = new OleDbCommand(qs, con);
            con.Open();
            OleDbDataReader q = com.ExecuteReader();
            while (q.Read() && i<k)
            {
                cuvant = q["cuvant"].ToString();
                i++;
            }
            cuvant = cuvant.ToUpper();
            comp(cuvant);
            con.Close();
            abcd[indice].Enabled = true;
        }

        public void cautL(string l)
        {
            int poz;
            poz = cuvant.IndexOf(l, 0);
            if (poz != -1)
            {

                while (poz != -1)
                {
                    litera[poz].Text = l.ToString();
                    poz = cuvant.IndexOf(l, poz + 1);

                }
                aicastigat();
            }
            else
            {
                nrgreseli++;
                pbG.Image = new Bitmap("art\\h" + nrgreseli + ".gif");
                if (nrgreseli == maxg)
                {
                    aipierdut();
                }

            }
        }
        private void aipierdut()
        {

            int i,cate=0;
            for (i = 0; i < cuvant.Length; i++)
            {
                if (litera[i].Text != cuvant[i].ToString())
                {
                    litera[i].Text = cuvant[i].ToString();
                    cate++;
                }
            }
            if (cate > 0)
            {
                jocP++;
                lblJP.Text = jocP.ToString();
               MessageBox.Show("Ai Pierdut!");   //jocnou();
            }



        }
        private void aicastigat()
        {
            int i, ok = 1;
            for (i = 0; i < cuvant.Length; i++)
            {
                if (litera[i].Text == "_")
                    ok = 0;
            }
            if (ok == 1)
            {

                jocC++;
                lblJC.Text = jocC.ToString();
                MessageBox.Show("Ai Castigat!");
                jocnou();


            }

        }

        private void btnJn_Click(object sender, EventArgs e)
        {
            aipierdut();
            jocnou();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSpanzura_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyChar == 27)
            //{
            //    this.Close();
            //}
        }

        private void frmSpanzura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void frmSpanzura_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Main)this.MdiParent).fCopil13 = null;

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Insert into Scoruri (Mail,Joc,Scor) values (@mail,@joc,@scor)";
            OleDbCommand com = new OleDbCommand(qs, con);
            com.Parameters.AddWithValue("Mail", ((Main)this.MdiParent).nume);
            com.Parameters.AddWithValue("Joc", "Spanzuratoare");
            com.Parameters.AddWithValue("Scor", lblJC.Text.ToString());
            int asd = com.ExecuteNonQuery();
            con.Close();
        }

    }
}
