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
using System.Diagnostics;

//http://www.britishempire.co.uk/biography/britishroyalty.htm

namespace Imperiul_Britanic
{
    public partial class FrmRegi : Form
    {
        public FrmRegi()
        {
            InitializeComponent();
        }
        int posibil = 0;
        public int imagine = 0;
        int prima = 0, ultima = 0,corecte=0,mutari=0,secunde=60;
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void FrmContemporan_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 9; i++)
            {
                ((this.Controls["panel" + i] as Panel).Controls["p" + i] as PictureBox).Image.Tag = i;
            }
        }

        private void FrmContemporan_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((Main)this.MdiParent).fCopil5 = null;
        }

        private void FrmContemporan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }


        private void pbImagineIstoric_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics,pbImagineIstoric.DisplayRectangle,Color.FromArgb(92, 15, 15),ButtonBorderStyle.Solid);
           
        }
        private void interschimba(int p1, int p2)
        {
            
            Image aux;
            aux = ((this.Controls["panel" + p1] as Panel).Controls["p" + p1] as PictureBox).Image;
            ((this.Controls["panel" + p1] as Panel).Controls["p" + p1] as PictureBox).Image = ((this.Controls["panel" + p2] as Panel).Controls["p" + p2] as PictureBox).Image;
            ((this.Controls["panel" + p2] as Panel).Controls["p" + p2] as PictureBox).Image = aux;
            
        
        }

        private void amesteca()
        {
            int i,p1,p2;
          
            Random r = new Random();
            for (i = 1; i <= 25; i++)
            {
                p1 = r.Next(1, 10);
                p2 = r.Next(1, 10);
                interschimba(p1, p2);
            }
        
        }
        private void muta(object sender, EventArgs e)
        {
            if (posibil == 0)
            {
                return;
            }
            int i = Convert.ToInt16((sender as PictureBox).Tag);
            if (prima == 0)
            {
                prima = i;
            }
            else
            {
                ultima = i;
                if (prima != ultima)
                {
                    interschimba(prima, ultima);
                    mutari++;
                    lblMutari.Text = mutari.ToString();
                    verifica();
                }
                prima = ultima = 0;
            }

        }

        private void verifica()
        {
            int i, cate=0,a,b;

            for (i = 1; i <= 9; i++)
            {
                a = Convert.ToInt16(((this.Controls["panel" + i] as Panel).Controls["p" + i] as PictureBox).Image.Tag);
                b = Convert.ToInt16(((this.Controls["panel" + i] as Panel).Controls["p" + i] as PictureBox).Tag);
                if (a == b)
                {
                    cate++;
                }
            }

            corecte=cate;
            lblCorecte.Text = corecte.ToString();
            if (corecte == 9)
            {
                tmr.Stop();
                posibil = 0;
                MessageBox.Show("Felicitari! Ai rezolvat din " + mutari + " mutari.", "Regi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                con.Open();
                string qs = "Insert into Scoruri (Mail,Joc,Scor) values (@mail,@joc,@scor)";
                OleDbCommand com = new OleDbCommand(qs, con);
                com.Parameters.AddWithValue("Mail", ((Main)this.MdiParent).nume);
                com.Parameters.AddWithValue("Joc", "Regi");
                com.Parameters.AddWithValue("Scor", lblCorecte.Text.ToString());
                int asd = com.ExecuteNonQuery();
                con.Close();
            }
            
        }

        private void jocNou()
        {
            posibil = 1;
            prima = ultima = 0;
            corecte = mutari = 0;
            secunde = 60;
            amesteca();
            lblCorecte.Text = corecte.ToString();
            lblMutari.Text = mutari.ToString();
            lblSecunde.Text = secunde.ToString();
            tmr.Start();
            verifica();
        }
 

        private void tmr_Tick(object sender, EventArgs e)
        {
            secunde--;
            lblSecunde.Text = secunde.ToString();
            if (secunde == 0)
            {
                tmr.Stop();
                MessageBox.Show("Ai pierdut!" , "Regi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                con.Open();
                string qs = "Insert into Scoruri (Mail,Joc,Scor) values (@mail,@joc,@scor)";
                OleDbCommand com = new OleDbCommand(qs, con);
                com.Parameters.AddWithValue("Mail", ((Main)this.MdiParent).nume);
                com.Parameters.AddWithValue("Joc", "Regi");
                com.Parameters.AddWithValue("Scor", lblCorecte.Text.ToString());
                int asd = com.ExecuteNonQuery();
                con.Close();

                posibil = 0;
                return;
            }

        }

        private void btnJocNou_Click(object sender, EventArgs e)
        {
            
        }

        private void pbJocNou_Click(object sender, EventArgs e)
        {
            jocNou();
           
        }

        private void lblLegatura_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", lblLegatura.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegi_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Main)this.MdiParent).fCopil12 = null;
        }

        

    }
}
