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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select* from Utilizatori";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                if (r["Mail"].ToString() == tbNume2.Text&&r["Parola"].ToString()==tbParola2.Text)
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
                    ((Main)this.MdiParent).profilUtilizatorToolStripMenuItem1.Visible = true;
                    ((Main)this.MdiParent).conectareToolStripMenuItem.Visible = false ;
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

        private void FrmAutentificare_Load(object sender, EventArgs e)
        {
            tbParola2.PasswordChar = '*';
        }

        private void FrmAutentificare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                con.Open();
                string text = "select * from Utilizatori";
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
                        ((Main)this.MdiParent).verificareaCunostiintelorToolStripMenuItem.Visible = true;
                        ((Main)this.MdiParent).fCopil7 = null;
                        this.Close();
                    }
                }
                if (flag == 1)
                {
                    MessageBox.Show("Date incorecte");
                }
            }
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

    }
}
