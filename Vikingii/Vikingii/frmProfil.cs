﻿using System;
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
    public partial class frmProfil : Form
    {
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        public frmProfil()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            ((Main)this.MdiParent).fCopil14 = null;
            this.Close();
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select* from Utilizatori where Mail=@mail";//

            OleDbCommand com = new OleDbCommand(text, con);
            com.Parameters.AddWithValue("Mail", ((Main)this.MdiParent).nume);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                if (r["Imagine"].ToString() != "")
                {
                    lblPic.Image = System.Drawing.Image.FromFile(cale + r["Imagine"].ToString());
                }
                label2.Text = r["Nume"].ToString();
                label7.Text = r["Mail"].ToString();
                label8.Text = r["Clasa"].ToString();
                label9.Text = r["Acces"].ToString();
                label10.Text = r["Gen"].ToString();
            }
            r.Close();
            con.Close();
        }
        string deins;
        private void copiaza_fisier(string sursa, string destinatie)
        {
            string numef = Path.GetFileNameWithoutExtension(sursa);
            string extensie = Path.GetExtension(sursa);
            int contor = 0;
            string numeNou = destinatie + numef + extensie;
            while (File.Exists(numeNou))
            {
                contor++;
                numeNou = destinatie + numef + contor + extensie;
            }
            File.Copy(sursa, numeNou);
            deins = "/Useri/";
            deins += Path.GetFileName(sursa);
            lblPic.Image = System.Drawing.Image.FromFile(numeNou);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            copiaza_fisier(ofd.FileName, cale + "/Useri/");
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Update Utilizatori set Imagine = @imagine where Mail=@mail";
            OleDbCommand com = new OleDbCommand(qs, con);
            com.Parameters.AddWithValue("Imagine", deins);
            com.Parameters.AddWithValue("Mail", label7.Text);
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}