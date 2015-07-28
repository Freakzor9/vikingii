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
    public partial class frmSynch : Form
    {
        public frmSynch()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSynch_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Main)this.MdiParent).fCopil16 = null;
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //string URI = ((Main)this.MdiParent).url + "sincronizare.php"; //how to post data from c# in php http://stackoverflow.com/questions/5401501/how-to-post-data-to-specific-url-using-webclient-in-c-sharp
            //if (cbLectii.Checked == true)
            //{

            //    string response;
            //    System.Net.ServicePointManager.Expect100Continue = false; //http://stackoverflow.com/questions/566437/http-post-returns-the-error-417-expectation-failed-c
            //    using (WebClient wclient = new WebClient())
            //    {
            //        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            //        con.Open();
            //        string text = "select* from Lectii";

            //        OleDbCommand com = new OleDbCommand(text, con);
            //        OleDbDataReader r = com.ExecuteReader();
            //        while (r.Read())
            //        {
            //                string parametri = "p=123soft&tip=upload_lectie";
            //        }
            //        r.Close();
            //        con.Close();
            //    }
            lststatus.Items.Clear();
            lststatus.Items.Add("Sincronizarea s-a facut cu succes!");
            if (cbLectii.Checked)
            {

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                con.Open();
                string text = "select* from Lectii";

                OleDbCommand com = new OleDbCommand(text, con);
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    string URI = ((Main)this.MdiParent).url + "sincronizare.php"; //how to post data from c# in php http://stackoverflow.com/questions/5401501/how-to-post-data-to-specific-url-using-webclient-in-c-sharp
                    string parametri = "p=123soft&tip=upload_lectie&id=" + r["id"] + "&titlu=" + r["titlu"] + "&continut=" + r["continut"] + "&obiective=" + r["obiective"];
                    string response;
                    System.Net.ServicePointManager.Expect100Continue = false; //http://stackoverflow.com/questions/566437/http-post-returns-the-error-417-expectation-failed-c
                    using (WebClient wclient = new WebClient())
                    {
                        wclient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        try
                        {
                            response = wclient.UploadString(URI, parametri);
                            string[] date = new string[10];
                            date = response.Split('\t');
                            lststatus.Items.Add(date[0]);
                        }
                        catch
                        {
                            MessageBox.Show("Conexiunea la server a esuat!", "Vikingii");
                        }

                    }
                }
            }
            if (cbUtilizatori.Checked)
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                con.Open();
                string text = "select* from Utilizatori";
                OleDbCommand com = new OleDbCommand(text, con);
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    string URI = ((Main)this.MdiParent).url + "sincronizare.php";
               //     string parametri = "p=123soft&tip=upload_useri&id="
                }
            }
        }

        private void frmSynch_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lststatus.Items.Clear();
            lststatus.Items.Add("Downloadare reusita!");
        }
    }
}