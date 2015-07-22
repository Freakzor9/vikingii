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
    public partial class frmBibliografie : Form
    {
        public frmBibliografie()
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
            pbImagineMare.Image = System.Drawing.Image.FromFile(cale + "\\bibliografie\\" + lstImagini.Items[imagine]);
            lbltext.Text = lstLink.Items[imagine].ToString();
        }

        private void frmBibliografie_Load(object sender, EventArgs e)
        {
            pbImagineMare.Image = System.Drawing.Image.FromFile(cale+"\\bibliografie\\" + lstImagini.Items[imagine]);
            lbltext.Text = lstLink.Items[imagine].ToString();
        }

        private void pbInapoi_Click(object sender, EventArgs e)
        {
            imagine--;
            if (imagine < 0)
            {
                imagine = lstImagini.Items.Count - 1;
            }
            pbImagineMare.Image = System.Drawing.Image.FromFile(cale + "\\bibliografie\\" + lstImagini.Items[imagine]);
            lbltext.Text = lstLink.Items[imagine].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
