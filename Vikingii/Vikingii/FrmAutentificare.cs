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
using System.Security.Permissions;
using Microsoft.Win32;
using System.Net;

namespace Imperiul_Britanic
{
    public partial class FrmAutentificare : Form
    {
        Point lastPoint;
        public int flag = 1;
        public FrmAutentificare()
        {
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);

        private void FrmAutentificare_Leave(object sender, EventArgs e)
        {
            ((Main)this.MdiParent).fCopil8 = null;
        }
        public char[] ch = new char[10];
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            int ok = 0;
            string URI = ((Main)this.MdiParent).url + "login.php"; //how to post data from c# in php http://stackoverflow.com/questions/5401501/how-to-post-data-to-specific-url-using-webclient-in-c-sharp
            string parametri = "p=123soft&m=" + tbNume2.Text.Trim() + "&pass=" + tbParola2.Text;
            string response;
            System.Net.ServicePointManager.Expect100Continue = false; //http://stackoverflow.com/questions/566437/http-post-returns-the-error-417-expectation-failed-c
            using (WebClient wclient = new WebClient())
            {
                wclient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                try
                {
                    response = wclient.UploadString(URI, parametri);
                    string[] date = new string[10];
                    date = response.Split('\n');

                    if (date[0] == "1")
                    {
                        ok = 1;
                        utilizatori.logat = true;
                        utilizatori.gen = date[1];
                        utilizatori.nume = date[2];
                        utilizatori.mail = date[3];
                        ((Main)this.MdiParent).nume = utilizatori.mail;
                        utilizatori.clasa = date[4];
                        utilizatori.img = date[5];
                        utilizatori.id = date[6];
                        utilizatori.tip = date[7];
                        utilizatori.acceptat = date[0];

                        //utilizatori.gen = utilizatori.gen.Trim(ch);
                        //utilizatori.nume = utilizatori.nume.Trim(ch);
                        //utilizatori.mail = utilizatori.mail.Trim(ch);
                        //utilizatori.clasa = utilizatori.clasa.Trim(ch);
                        //utilizatori.img = utilizatori.img.Trim(ch);
                        //utilizatori.id = utilizatori.id.Trim(ch);
                        //utilizatori.tip = utilizatori.tip.Trim(ch);
                        //utilizatori.acceptat = utilizatori.acceptat.Trim(ch);

                        ((Main)this.MdiParent).profilUtilizatorToolStripMenuItem1.Visible = true;
                        ((Main)this.MdiParent).conectareToolStripMenuItem.Visible = false;
                        ((Main)this.MdiParent).deconectareToolStripMenuItem.Visible = true;
                        ((Main)this.MdiParent).verificareaCunostiintelorToolStripMenuItem.Visible = true;
                        ((Main)this.MdiParent).nume2 = utilizatori.nume;

                        if (utilizatori.tip == "Admin")
                        {
                            Variable.acces = "Admin";
                            ((Main)this.MdiParent).modDeAdministratorToolStripMenuItem.Visible = true;
                        }
                        this.Close();
                    }
                    if (response[0] == '0')
                    {
                        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                        con.Open();
                        string text = "select* from Utilizatori";
                        OleDbCommand com = new OleDbCommand(text, con);
                        OleDbDataReader r = com.ExecuteReader();
                        while (r.Read())
                        {
                            if (r["Mail"].ToString() == tbNume2.Text && r["Parola"].ToString() == tbParola2.Text)
                            {
                                if (r["Acceptat"].ToString() == "0")
                                {
                                    MessageBox.Show("Contul nu a fost validat de un administrator");
                                    return;
                                }
                                MessageBox.Show("Bine ai venit " + r["Nume"]);
                                if (r["Acces"].ToString() == "Admin")
                                {
                                    Variable.acces = "Admin";
                                    ((Main)this.MdiParent).modDeAdministratorToolStripMenuItem.Visible = true;
                                }
                                flag = 0;
                                ((Main)this.MdiParent).nume = r["Mail"].ToString();
                                ((Main)this.MdiParent).nume2 = r["Nume"].ToString();
                                ((Main)this.MdiParent).profilUtilizatorToolStripMenuItem1.Visible = true;
                                ((Main)this.MdiParent).conectareToolStripMenuItem.Visible = false;
                                ((Main)this.MdiParent).deconectareToolStripMenuItem.Visible = true;
                                ((Main)this.MdiParent).verificareaCunostiintelorToolStripMenuItem.Visible = true;

                                this.Close();
                            }
                        }
                        if (flag == 1)
                        {
                            MessageBox.Show("Date incorecte");
                        }
                       // MessageBox.Show("Emailul sau parola este gresita");
                        tbParola2.Text = "";

                    }
                }
                catch
                {
                    MessageBox.Show("Conexiune la server esuata!Se face conexiunea la serverul local","Vikingii",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                    con.Open();
                    string text = "select* from Utilizatori";
                    OleDbCommand com = new OleDbCommand(text, con);
                    OleDbDataReader r = com.ExecuteReader();
                    while (r.Read())
                    {
                        if (r["Mail"].ToString() == tbNume2.Text && r["Parola"].ToString() == tbParola2.Text)
                        {
                            if (r["Acceptat"].ToString() == "0")
                            {
                                MessageBox.Show("Contul nu a fost validat de un administrator");
                                return;
                            }
                            MessageBox.Show("Bine ai venit " + r["Nume"]);
                            if (r["Acces"].ToString() == "Admin")
                            {
                                Variable.acces = "Admin";
                                ((Main)this.MdiParent).modDeAdministratorToolStripMenuItem.Visible = true;
                            }
                            flag = 0;
                            ((Main)this.MdiParent).nume2 = r["Nume"].ToString();
                            ((Main)this.MdiParent).nume = r["Mail"].ToString();
                            ((Main)this.MdiParent).profilUtilizatorToolStripMenuItem1.Visible = true;
                            ((Main)this.MdiParent).conectareToolStripMenuItem.Visible = false;
                            ((Main)this.MdiParent).deconectareToolStripMenuItem.Visible = true;
                            ((Main)this.MdiParent).verificareaCunostiintelorToolStripMenuItem.Visible = true;

                            this.Close();
                        }
                    }
                    if (flag == 1)
                    {
                        MessageBox.Show("Date incorecte");
                    }

                }
            }


        }

        private void FrmAutentificare_Load(object sender, EventArgs e)
        {
            tbParola2.PasswordChar = '*';
        }

        private void FrmAutentificare_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            //    con.Open();
            //    string text = "select * from Utilizatori";
            //    OleDbCommand com = new OleDbCommand(text, con);
            //    OleDbDataReader r = com.ExecuteReader();
            //    while (r.Read())
            //    {
            //        if (r["Mail"].ToString() == tbNume2.Text && r["Parola"].ToString() == tbParola2.Text)
            //        {
            //            if (r["Acceptat"].ToString() == "0")
            //            {
            //                MessageBox.Show("Contul nu a fost validat de un administrator");
            //                return;
            //            }
            //            MessageBox.Show("Bine ai venit " + r["Nume"]);
            //            if (r["Acces"].ToString() == "Admin")
            //            {
            //                Variable.acces = "Admin";
            //                ((Main)this.MdiParent).modDeAdministratorToolStripMenuItem.Visible = true;
            //            }
            //            flag = 0;
            //            ((Main)this.MdiParent).nume = r["Mail"].ToString();
            //            ((Main)this.MdiParent).nume2 = r["Nume"].ToString();
            //            ((Main)this.MdiParent).profilUtilizatorToolStripMenuItem1.Visible = true;
            //            ((Main)this.MdiParent).verificareaCunostiintelorToolStripMenuItem.Visible = true;
            //            ((Main)this.MdiParent).fCopil7 = null;
            //            this.Close();
            //        }
            //    }
            //    if (flag == 1)
            //    {
            //        MessageBox.Show("Date incorecte");
            //    }
            //}
        }

        private void FrmAutentificare_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void FrmAutentificare_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form form = new frmInregistrare();
            form.Show();
        }

        private void FrmAutentificare_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Main)this.MdiParent).fCopil7 = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
