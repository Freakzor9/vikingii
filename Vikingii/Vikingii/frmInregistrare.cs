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
    public partial class frmInregistrare : Form
    {
        public frmInregistrare()
        {
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void inregistrare()
        {
            string URI = ((Main)this.MdiParent).url + "cere.php"; //how to post data from c# in php http://stackoverflow.com/questions/5401501/how-to-post-data-to-specific-url-using-webclient-in-c-sharp
            string parametri = "p=123soft&m=" + txtMail.Text.Trim() + "&n=" + txtNume.Text.Trim()+"&acc=0&cls="+txtClasa.Text.Trim()+"tip=User";
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
                }
                catch
                {
                    txtClasa.Text = txtClasa.Text.Replace(" ", "");

                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                    con.Open();
                    string qs = "Insert into Utilizatori (Mail,Nume,Clasa,Gen,Parola,Acceptat,Acces) values(@mail,@nume,@clasa,@gen,@parola,@acceptat,@acces)";
                    OleDbCommand com = new OleDbCommand(qs, con);
                    com.Parameters.AddWithValue("Mail", txtMail.Text);
                    com.Parameters.AddWithValue("Nume", txtNume.Text);
                    com.Parameters.AddWithValue("Clasa", txtClasa.Text);
                    com.Parameters.AddWithValue("Gen", cmbGen.SelectedItem.ToString());
                    com.Parameters.AddWithValue("Parola", txtParola.Text);
                    com.Parameters.AddWithValue("Acceptat", 0);
                    com.Parameters.AddWithValue("Acces", "User");
                    int asd = com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Inregistrare finalizata, va rugam asteptati acceptul unui administrator");
                    this.Close();
                }
            }

        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (txtNume.Text.Trim() != "" && txtMail.Text.Trim() != "" && txtClasa.Text.Trim() != "" && txtParola.Text.Trim() != "")
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                con.Open();
                string text = "select * from Utilizatori";
                OleDbCommand com = new OleDbCommand(text, con);
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    if (r["Mail"].ToString() == txtMail.Text)
                    {
                        MessageBox.Show("Emailul este deja folosit");
                        r.Close();
                        con.Close();
                        return;
                    }
                }
                inregistrare();
            }
            else
            {
                MessageBox.Show("Exista campuri necompletate");
                return;
            }
        }

        private void frmInregistrare_Load(object sender, EventArgs e)
        {
            cmbGen.SelectedIndex = 0;
        }
    }
}
