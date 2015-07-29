using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Media;
//#5C0F0F ; 92,15,15
namespace Imperiul_Britanic
{
    public partial class Main : Form
    {
        public string url = "http://softed.comli.com/";

        public FrmLectii fCopil1 = null;
        public FrmLectii fCopil2 = null;
        public FrmLectii fCopil3 = null;
        public FrmLectii fCopil4 = null;
        public FrmLectii fCopil5 = null;
        public FrmJoc fCopil6 = null;
        public FrmAutentificare fCopil7 = null;
   //     public FrmIntrebari fCopil8 = null;
        public FrmEditare fCopil8 = null;
        public FrmAjutor fCopil9 = null ;
      //  public FrmStergere fCopil10 = null;
        public FrmSteaguriJoc fCopil11 = null;
        public FrmRegi fCopil12 = null;
        public frmSpanzura fCopil13 = null;
        public frmProfil fCopil14 = null;
        public frmUtilizatori fCopil15 = null;
        public frmSynch fCopil16 = null;
        public frmBibliografie fCopil17 = null;
        public frmSite fCopil18 = null;

        public string nume,nume2;

        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    SoundPlayer sndplayr = new
            //             SoundPlayer("muzica.wav");
            //    sndplayr.Play();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(),
            //                   "Error");
            //}
       //     this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Visible = false;
            pictureBox2.Location = new Point(this.Width - pictureBox2.Width, 0);
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               // EditorIntrebari.Enabled = true;
               // EditorIntrebari.Visible = true;
               // stergere.Enabled = true;
            }
            if (e.KeyChar == 27)
            {
                if (fCopil1 != null)
                {
                    fCopil1.Close();
                }
                if (fCopil2 != null)
                {
                    fCopil2.Close();
                }
                if (fCopil3 != null)
                {
                    fCopil3.Close();
                }
                if (fCopil4 != null)
                {
                    fCopil4.Close();
                }
                if (fCopil5 != null)
                {
                    fCopil5.Close();
                }
                if (fCopil6 != null)
                {
                    fCopil6.Close();
                }
                if (fCopil7 != null)
                {
                    fCopil7.Close();
                }
                if (fCopil8 != null)
                {
                    fCopil8.Close();
                }
                if (fCopil9 != null)
                {
                    fCopil9.Close();
                }
              //  if (fCopil10 != null)
                {
               ///     fCopil10.Close();
                }
                if (fCopil11 != null)
                {
                    fCopil11.Close();
                }
                if (fCopil12 != null)
                {
                    fCopil12.Close();
                }
              //  if (Variable.acces == "Admin")
              //  {
               //     EditorIntrebari.Enabled = true;
                 //   stergere.Enabled = true;
              //      EditorIntrebari.Visible = true;
               // }
            }
        }


        private void mnIstoric_Click(object sender, EventArgs e)
        {
            	//	if (fCopil1 == null)			
            	{
                	fCopil1 = new FrmLectii();	 
                	fCopil1.MdiParent = this;
                    fCopil1.idl = 1;
               		fCopil1.Show();			
            	}

        }

        private void mnInceput_Click(object sender, EventArgs e)
        {
           // if (fCopil2 == null)
            {
                fCopil2 = new FrmLectii();
                fCopil2.idl = 2;
                fCopil2.MdiParent = this;
                fCopil2.Show();
            }
        }

        private void mnDezvoltare_Click(object sender, EventArgs e)
        {
          //  if (fCopil3 == null)
            {
                fCopil3 = new FrmLectii();
                fCopil3.idl = 3;
                fCopil3.MdiParent = this;
                fCopil3.Show();
            }
        }

        private void mnIndependenta_Click(object sender, EventArgs e)
        {
          //  if (fCopil4 == null)
            {
                fCopil4 = new FrmLectii();
                fCopil4.idl = 5;
                fCopil4.MdiParent = this;
                fCopil4.Show();
            }
        }

        private void mnContemporan_Click(object sender, EventArgs e)
        {
         //   if (fCopil5 == null)
            {
                fCopil5 = new FrmLectii();
                fCopil5.idl = 6;
                fCopil5.MdiParent = this;
                fCopil5.Show();
            }
        }

        private void jocDeVerificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil6 == null)
            {
                fCopil6 = new FrmJoc();
                fCopil6.MdiParent = this;
                fCopil6.Show();
            }
        }

        private void editorDeSoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil7 == null)
            {
                fCopil7 = new FrmAutentificare();
                fCopil7.MdiParent = this;
                fCopil7.Show();
            }
        }

     //   private void pictureBox1_Click(object sender, EventArgs e)
     //   {
      //      this.Close();
    //    }

        private void editorIntrebariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil8 == null)
            {
               // fCopil8 = new FrmIntrebari();
                fCopil8 = new FrmEditare();
                fCopil8.MdiParent = this;
                fCopil8.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Variable.acces == "Admin")
            {
               // EditorIntrebari.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil9 == null)
            {
                fCopil9 = new FrmAjutor();
                fCopil9.MdiParent = this;
                fCopil9.Show();
            }
        }



        private void recunoasteSteagulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil11 == null)
            {
                fCopil11 = new FrmSteaguriJoc();
                fCopil11.MdiParent = this;
                fCopil11.Show();
            }
        }

        private void regiiAnglieiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil12 == null)
            {
                fCopil12 = new FrmRegi();
                fCopil12.MdiParent = this;
                fCopil12.Show();
            }
        }

        private void lectiiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bibliografieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil13 == null)
            {
                fCopil13 = new frmSpanzura();
                fCopil13.MdiParent = this;
                fCopil13.Show();
            }
        }

        private void profilUtilizatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editorIntrebariToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (fCopil8 == null)
            {
                // fCopil8 = new FrmIntrebari();
                fCopil8 = new FrmEditare();
                fCopil8.MdiParent = this;
                fCopil8.Show();
            }
        }

        private void utilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil15 == null)
            {
                fCopil15 = new frmUtilizatori();
                fCopil15.MdiParent = this;
                fCopil15.Show();
            }
        }

        private void conectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil7 == null)
            {
                fCopil7 = new FrmAutentificare();
                fCopil7.MdiParent = this;
                fCopil7.Show();
            }
        }

        private void profilUtilizatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fCopil14 == null)
            {
                fCopil14 = new frmProfil();
                fCopil14.MdiParent = this;
                fCopil14.Show();
            }
        }

        private void deconectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deconectareToolStripMenuItem.Visible = false;
            conectareToolStripMenuItem.Visible = true;
            modDeAdministratorToolStripMenuItem.Visible = false;
            Variable.acces = "";
            profilUtilizatorToolStripMenuItem1.Visible = false;
            verificareaCunostiintelorToolStripMenuItem.Visible = false;
        }

        private void sincronizareBazaDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil16 == null)
            {
                fCopil16 = new frmSynch();
                fCopil16.MdiParent = this;
                fCopil16.Show();
            }
        }

        private void bibliografieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (fCopil17 == null)
            {
                fCopil17 = new frmBibliografie();
                fCopil17.MdiParent = this;
                fCopil17.Show();
            }
        }

        private void sitografieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCopil18 == null)
            {
                fCopil18 = new frmSite();
                fCopil18.MdiParent = this;
                fCopil18.Show();
            }
        }
    }
}
