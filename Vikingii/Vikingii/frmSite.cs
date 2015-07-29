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
    public partial class frmSite : Form
    {
        public frmSite()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int imagine = 0;
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void pbInainte_Click(object sender, EventArgs e)
        {
            imagine++;
            if (imagine >= lstImagini.Items.Count)
            {
                imagine = 0;
            }
            wb.Navigate(lstImagini.Items[imagine].ToString());
            lbltext.Text = lstLink.Items[imagine].ToString();
        }

        private void frmBibliografie_Load(object sender, EventArgs e)
        {
            wb.Navigate(lstImagini.Items[imagine].ToString()); 
            lbltext.Text = lstLink.Items[imagine].ToString();
        }

        private void pbInapoi_Click(object sender, EventArgs e)
        {
            imagine--;
            if (imagine < 0)
            {
                imagine = lstImagini.Items.Count - 1;
            }
            wb.Navigate(lstImagini.Items[imagine].ToString());
            lbltext.Text = lstLink.Items[imagine].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmBibliografie_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Main)this.MdiParent).fCopil18 = null;
        }
    }
}
