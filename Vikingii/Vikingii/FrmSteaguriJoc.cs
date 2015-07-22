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
    public partial class FrmSteaguriJoc : Form
    {
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        public int i = 0;
        public string sursa = "", dest = "";
        public FrmSteaguriJoc()
        {
            InitializeComponent();
        }
        private void interschimba(int p1, int p2)
        {

            string aux;
            aux = ((this.Controls["label" + p1] as Label).Text);
            (this.Controls["label" + p1] as Label).Text = (this.Controls["label" + p2] as Label).Text;
            (this.Controls["label" + p2] as Label).Text = aux;


        }
        private void FrmSteaguriJoc_Load(object sender, EventArgs e)
        {
            
            ((Control)label1).AllowDrop = true;
            ((Control)pictureBox1).AllowDrop = true;

            ((Control)label2).AllowDrop = true;
            ((Control)pictureBox2).AllowDrop = true;

            ((Control)label3).AllowDrop = true;
            ((Control)pictureBox3).AllowDrop = true;

            ((Control)label4).AllowDrop = true;
            ((Control)pictureBox1).AllowDrop = true;

            ((Control)label4).AllowDrop = true;
            ((Control)pictureBox4).AllowDrop = true;



            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from Steaguri order by rnd(ID)";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while(r.Read()&&i<5)
            {
                i++;
                lbCale.Items.Add(r["Locatie"]);
                lbTara.Items.Add(r["Tara"]);
            }
            pictureBox1.Image = System.Drawing.Image.FromFile(cale + lbCale.Items[0]);
            pictureBox2.Image = System.Drawing.Image.FromFile(cale + lbCale.Items[1]);
            pictureBox3.Image = System.Drawing.Image.FromFile(cale + lbCale.Items[2]);
            pictureBox4.Image = System.Drawing.Image.FromFile(cale + lbCale.Items[3]);
            pictureBox5.Image = System.Drawing.Image.FromFile(cale + lbCale.Items[4]);

            for (i = 0; i < 5; i++)
            {
                (this.Controls["label" + (i + 1)] as Label).Text = lbTara.Items[i].ToString();
            }
            int p1, p2;
            Random ra = new Random();
            for (i = 1; i <= 25; i++)
            {
                p1 = ra.Next(1, 6);
                p2 = ra.Next(1, 6);
                interschimba(p1, p2);
            }
            this.Text = lbTara.Items.Count.ToString();
        }

        private void FrmSteaguriJoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (label1.Text == null) return;
            DragDropEffects d = DoDragDrop(label1.Text, DragDropEffects.Move); 
            if (d == DragDropEffects.Move)
            {
                label1.Text = null; 
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            //VERIFICARI
        }

        private void lbTara_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void lbTara_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(lbTara.Items[0].ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (sursa == "")
            {
                sursa = (sender as Label).Text;
               // (sender as Label).Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sursa != "")
            {
                (sender as Label).Text= sursa;
                sursa = "";

            }
        }

        private void pbVerifica_Click(object sender, EventArgs e)
        {

            int i, corecte = 0;
            for (i = 0; i < lbTara.Items.Count; i++)
            {
                if ((this.Controls["pictureBox" + (i + 1)] as Label).Text == lbTara.Items[i].ToString())
                {
                    corecte++;
                }
            }

            if (corecte == 5)
            {
                MessageBox.Show("Ai castigat!", "Imagini", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Ai pierdut!", "Imagini", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Insert into Scoruri (Mail,Joc,Scor) values (@mail,@joc,@scor)";
            OleDbCommand com = new OleDbCommand(qs, con);
            com.Parameters.AddWithValue("Mail", ((Main)this.MdiParent).nume);
            com.Parameters.AddWithValue("Joc", "Imagini");
            com.Parameters.AddWithValue("Scor", corecte.ToString());
            int asd = com.ExecuteNonQuery();
            con.Close();
        }

    

       
       

    }
}
