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
//---------------------------------------am modificat-o

namespace Imperiul_Britanic
{
    public partial class FrmLectii : Form
    {
        Point lastPoint;
        PictureBox[] img = new PictureBox[50];
 
        public int idl ;
        public int imagine = 0;
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        string imagineSelectata = "";//indicele imaginii mici selectate

        private void FrmInceputuri_FormClosed(object sender, FormClosedEventArgs e)
        {

          //  ((Main)this.MdiParent).fCopil1 = null;
      //      ((Main)this.MdiParent).fCopil2 = null;
      //      ((Main)this.MdiParent).fCopil3 = null;
      //      ((Main)this.MdiParent).fCopil4 = null;
      //      ((Main)this.MdiParent).fCopil5 = null;
        }

        private void imaginiMari()
        {
            lstTitlu.Items.Clear();
            lstImagini.Items.Clear();
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "select* from Imagini where idL="+idl.ToString();
            OleDbCommand com = new OleDbCommand(qs, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                lstTitlu.Items.Add(r["Titlu"]);
               lstImagini.Items.Add(r["Fisier"]);
            }
            r.Close();
            con.Close();
           
        }
        private void imgCreate()//andrei
        {
            int x = 3, y = 2, lat = 85, dist = 4, i, j, care = 0;

            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= 4; j++)
                {
                    img[care] = new PictureBox();
                    img[care].Size = new Size(lat, lat);
                    img[care].Location = new Point(x, y);
                    img[care].BorderStyle = BorderStyle.FixedSingle;
                    img[care].SizeMode = PictureBoxSizeMode.StretchImage;
                    img[care].Click += new System.EventHandler(img_Click);
                    panMic.Controls.Add(img[care]);

                    care++;
                    x += lat + dist;
                }
                y += lat + dist;
                x = 2;
            }
        }
        private void imgLoad()//andrei
        {
            int  i, j, care = 0;

            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= 4; j++)
                {
                    if (care < lstImagini.Items.Count)
                    {
                        img[care].Image = System.Drawing.Image.FromFile(cale + lstImagini.Items[care]);
                        img[care].Tag = care;
                        toolTip.SetToolTip(this.img[care], lstTitlu.Items[care].ToString());
                    }
                    else
                    {
                        img[care].Image = null;
                        img[care].Tag = care;
                    }

                    care++;
                }
            }

        }

        private void img_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16((sender as PictureBox).Tag) > lstImagini.Items.Count-1)
            {
                return;
            }
            imagine = Convert.ToInt16((sender as PictureBox).Tag);
            lblVizualizare_Click(sender, e);
            pbImagineMare.Image = System.Drawing.Image.FromFile(cale + lstImagini.Items[imagine]);
            txtTitlu.Text = lstTitlu.Items[imagine].ToString(); 
        }


        private void copiaza_fisier(string sursa, string destinatie)
        {
            string numef = Path.GetFileNameWithoutExtension(sursa);
            string extensie = Path.GetExtension(sursa);
            int contor = 0;
            string numeNou = destinatie + numef + extensie;
            while(File.Exists(numeNou))
            {
                contor++;
                numeNou = destinatie + numef + contor+ extensie;
            }
            File.Copy(sursa, numeNou);
            lstImagini.Items.Add("\\L"+idl+"\\"+Path.GetFileName(numeNou));
            lstTitlu.Items.Add("Imagine noua");
        }
        
        public FrmLectii()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.ContainerControl |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor
                          , true);
        }
        private void FrmInceputuri_Load(object sender, EventArgs e)
        {
             SendKeys.Send("{TAB}");//ca sa nu mai fie cursorul in lectie
             if (Variable.acces == "Admin")
             {
                 rtInceputuri.ReadOnly = false;
                 rtInceputuri.Enabled = true;
                 pbAdaugare.Visible = true;
             //    tbIstoricTitlu.ReadOnly = false;
                 tbIstoricTitlu.Enabled = true;
             //    tbImgAd.Visible = true;
                 pbImagineMare.Visible = false;


             }
             OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
             con.Open();
             string text = "select* from Lectii where id="+idl.ToString();

             OleDbCommand com = new OleDbCommand(text, con);
             OleDbDataReader r = com.ExecuteReader();
             while (r.Read())
             {
                rtInceputuri.Text = r["Continut"].ToString();
                tbIstoricTitlu.Text = r["Titlu"].ToString();
             }
             r.Close();
             con.Close();
             imaginiMari();

             if(lstImagini.Items.Count>0)
            {
                pbImagineMare.Visible = true;
                pbImagineMare.Image = System.Drawing.Image.FromFile(cale + lstImagini.Items[0]);
                imagineSelectata = cale + lstImagini.Items[0];
                txtTitlu.Text = lstTitlu.Items[imagine].ToString(); 
            }
             imgCreate();
             imgLoad();
         }


         private void pbInapoi_Click(object sender, EventArgs e)
         {
             imagine--;
             if (imagine < 0)
             {
                 imagine = lstImagini.Items.Count-1;
             }
             pbImagineMare.Image = System.Drawing.Image.FromFile(cale + lstImagini.Items[imagine]);
             imagineSelectata = cale + lstImagini.Items[imagine];
             txtTitlu.Text = lstTitlu.Items[imagine].ToString(); 
         }

         private void pbInainte_Click(object sender, EventArgs e)
         {
             imagine++;
             if (imagine >= lstImagini.Items.Count)
             {
                 imagine = 0;
             }
             pbImagineMare.Image = System.Drawing.Image.FromFile(cale + lstImagini.Items[imagine]);
             imagineSelectata = cale + lstImagini.Items[imagine];
             txtTitlu.Text = lstTitlu.Items[imagine].ToString(); 
         }

        private void FrmInceputuri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void pbAdaugare_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string cmd = "Insert into Imagini (IDL,Fisier) values(@idl,@fisier)";
            OleDbCommand com2 = new OleDbCommand(cmd, con);
            com2.Parameters.AddWithValue("idl", idl);
          //  com2.Parameters.AddWithValue("fisier", tbImgAd.Text);
            int asd = com2.ExecuteNonQuery();
            string qs = "Update Lectii SET Titlu=@titlu,Continut=@continut where ID="+idl.ToString();
            OleDbCommand com = new OleDbCommand(qs, con);
            com.Parameters.AddWithValue("Titlu", tbIstoricTitlu.Text);
            com.Parameters.AddWithValue("Continut", rtInceputuri.Text);
            com.ExecuteNonQuery();
            con.Close();
        }

        private void FrmInceputuri_Leave(object sender, EventArgs e)
        {

        }

        private void lblVizualizare_Click(object sender, EventArgs e)
        {
            if (lblVizualizare.Text == "Vezi imaginile in paralel")
            {
                panMic.Visible = true;
                panMare.Visible = !panMic.Visible;
                lblVizualizare.Text = "Vezi imaginile pe rand";

            }
            else
            {
                panMic.Visible = false;
                panMare.Visible = !panMic.Visible;
                lblVizualizare.Text = "Vezi imaginile in paralel";

            }
        }


        public int k;
        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }


            copiaza_fisier(ofd.FileName, cale+"/L"+idl.ToString()+"/");
            imgLoad();
          

            //sa faci foldere cu imagini pt fiecare lectie
            //adauga fisierul in baza de date si in lista lbimagini2
            //adauga fisierul in panoul cu vizualizare minimizata -> panMic 
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            if (imagineSelectata == "")
            {
                MessageBox.Show("Nu s-a ales nicio imagine!");
                return;
            }
            if (MessageBox.Show("Sunteti sigur ca vreti sa stergeti imaginea?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }
            lstImagini.Items.RemoveAt(imagine);
            lstTitlu.Items.RemoveAt(imagine); 
            imgLoad();
            pbInainte_Click(sender , e);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLectii_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void FrmLectii_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pbAdaugare_Click_1(object sender, EventArgs e)
        {
            if(rtInceputuri.Text=="")
            {
                return;
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
             //com2.Parameters.AddWithValue("fisier", tbImgAd.Text);

            string qs = "Update Lectii SET Titlu=@titlu,Continut=@continut where ID=" + idl.ToString();
            OleDbCommand com = new OleDbCommand(qs, con);
            com.Parameters.AddWithValue("Titlu", tbIstoricTitlu.Text);
            com.Parameters.AddWithValue("Continut", rtInceputuri.Text);
            com.ExecuteNonQuery();
                   
            qs = "Delete from Imagini where IDL="+idl;
            com.CommandText = qs;
          //  com.Parameters.AddWithValue("idl", idl);
            //com.Parameters["idl"].DbType = DbType.Int16;
            int nr = com.ExecuteNonQuery();

            qs = "Insert into Imagini (IDL,Titlu,Fisier) values(@idl,@titlu,@fisier)";
            com.CommandText = qs;
            com.Parameters.Clear();
            com.Parameters.AddWithValue("idl", idl);
            com.Parameters["idl"].DbType = DbType.Int16;
            com.Parameters.AddWithValue("Titlu", "");

            com.Parameters.AddWithValue("Fisier", "");
            for (k = 0; k < lstImagini.Items.Count; k++)
            {
                com.Parameters["Titlu"].Value = lstTitlu.Items[k];
                com.Parameters["Fisier"].Value = lstImagini.Items[k];
                com.ExecuteNonQuery();
            }
            con.Close();
        }

        private void pbObiective_Click(object sender, EventArgs e)
        {
            frmObiective form = new frmObiective();
            form.idl = idl;
            form.Show();
        }

        private void pbTest_Click(object sender, EventArgs e)
        {
            frmHang form = new frmHang();
            form.idl = idl;
            form.Show();
        }       


    }
}
