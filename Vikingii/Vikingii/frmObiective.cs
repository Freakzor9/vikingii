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
    public partial class frmObiective : Form
    {
        public int idl;
        public frmObiective()
        {
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void frmObiective_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();

            string text = "select* from Lectii where id=" + idl.ToString();

            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                if (idl.ToString() == r["ID"].ToString())
                {
                    lblObiective.Text = r["Obiective"].ToString();
                }
            }
            r.Close();
            con.Close();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
