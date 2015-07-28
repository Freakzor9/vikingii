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
//
//Random random = new Random();
//int randomNumber = random.Next(0, 100);
//
namespace Imperiul_Britanic
{
    public partial class FrmJoc : Form
    {
        public FrmJoc()
        {
            InitializeComponent();
        }
        public int flag = 1, flag2 = 1, flag3 = 1;
        public int ScorR1 = 1;
        public int ScorR2 = 1;
        public int contor = 0;
        public int RUNDA1 = 8;
        public int RUNDA2 = 8;
        public int H;
        public string RC;
        public string RA;
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void FrmJoc_Leave(object sender, EventArgs e)
        {
            ((Main)this.MdiParent).fCopil6 = null;
        }
        public int ok = 1; public int ScorFR = 0;
        private void FrmJoc_Load(object sender, EventArgs e)
        {
            lblNume.Text = ((Main)this.MdiParent).nume2;
            lblture.Text = RUNDA1.ToString();
            //   tbIntrebare.Location = new Point(159, 136);
            //    tbRaspuns1.Location = new Point(70, 307);
            //    tbRaspuns2.Location = new Point(70, 433);
            //    tbRaspuns3.Location = new Point(465, 307);
            //    tbRaspuns4.Location = new Point(465, 433);

            //if (Variable.acces == "Admin")
            //{
            //    tbINTR1.Visible = true;
            //    tbINTR2.Visible = true;
            //}


            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from Intrebari order by rnd(ID)";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                lstIntrebare.Items.Add(r["Intrebare"].ToString());
                lstR1.Items.Add(r["R1"].ToString());
                lstR2.Items.Add(r["R2"].ToString());
                lstR3.Items.Add(r["R3"].ToString());
                lstR4.Items.Add(r["R4"].ToString());
                lstRC.Items.Add(r["RCorect"].ToString());
                lbID.Items.Add(r["ID"]);


            }
        }
        public int[] aparitii = new int[100];

        private void FrmJoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        public int alegere;
        private void pbGalicia_Click(object sender, EventArgs e)
        {
            //         MessageBox.Show(RUNDA1.ToString());
            if (RUNDA1 > 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                alegere = 1;
                Random random = new Random();
                contor = random.Next(0, lstIntrebare.Items.Count);
                tbIntrebare.Text = lstIntrebare.Items[contor].ToString();
                tbRaspuns1.Text = lstR1.Items[contor].ToString();
                tbRaspuns2.Text = lstR2.Items[contor].ToString();
                tbRaspuns3.Text = lstR3.Items[contor].ToString();
                tbRaspuns4.Text = lstR4.Items[contor].ToString();
                RC = lstRC.Items[contor].ToString();
                tbINTR2.Text = lbID.Items[contor].ToString();


                pbGalicia.Visible = false;
                pbAndaluz.Visible = false;
                pbSwagonia.Visible = false;
                pbVoivodina.Visible = false;
                pbAmpulentia.Visible = false;
                pbClobaria.Visible = false;
                pbTortis.Visible = false;
                pbFloriopolis.Visible = false;
                
                tbIntrebare.Visible = true;
                tbRaspuns1.Visible = true;
                tbRaspuns2.Visible = true;
                tbRaspuns3.Visible = true;
                tbRaspuns4.Visible = true;
                RUNDA1--;
                lblture.Text = RUNDA1.ToString();
                lstIntrebare.Items.RemoveAt(contor);
                lstR1.Items.RemoveAt(contor);
                lstR2.Items.RemoveAt(contor);
                lstR3.Items.RemoveAt(contor);
                lstR4.Items.RemoveAt(contor);
                lstRC.Items.RemoveAt(contor);
                lbScor1.Text = ScorR1.ToString();
            }
            else
            {
                if (flag3 == 1)
                {
                    tmr.Enabled = true;
                    flag3 = 0;
                }
            }
        }

        private void pbAndaluz_Click(object sender, EventArgs e)
        {
            //        MessageBox.Show(RUNDA1.ToString());
            if (RUNDA1 > 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                alegere = 2;
                Random random = new Random();
                contor = random.Next(0, lstIntrebare.Items.Count);
                tbIntrebare.Text = lstIntrebare.Items[contor].ToString();
                tbRaspuns1.Text = lstR1.Items[contor].ToString();
                tbRaspuns2.Text = lstR2.Items[contor].ToString();
                tbRaspuns3.Text = lstR3.Items[contor].ToString();
                tbRaspuns4.Text = lstR4.Items[contor].ToString();
                RC = lstRC.Items[contor].ToString(); 
                tbINTR2.Text = lbID.Items[contor].ToString();

                pbGalicia.Visible = false;
                pbAndaluz.Visible = false;
                pbSwagonia.Visible = false;
                pbVoivodina.Visible = false;
                pbAmpulentia.Visible = false;
                pbClobaria.Visible = false;
                pbTortis.Visible = false;
                pbFloriopolis.Visible = false;

                tbIntrebare.Visible = true;
                tbRaspuns1.Visible = true;
                tbRaspuns2.Visible = true;
                tbRaspuns3.Visible = true;
                tbRaspuns4.Visible = true;
                RUNDA1--;
                lblture.Text = RUNDA1.ToString();
                lstIntrebare.Items.RemoveAt(contor);
                lstR1.Items.RemoveAt(contor);
                lstR2.Items.RemoveAt(contor);
                lstR3.Items.RemoveAt(contor);
                lstR4.Items.RemoveAt(contor);
                lstRC.Items.RemoveAt(contor);
                lbScor1.Text = ScorR1.ToString();
            }
            else
            {
                if (flag3 == 1)
                {
                    tmr.Enabled = true;
                    flag3 = 0;
                }
            }
        }

        private void pbSwagonia_Click(object sender, EventArgs e)
        {
            //        MessageBox.Show(RUNDA1.ToString());
            if (RUNDA1 > 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                alegere = 3;
                Random random = new Random();
                contor = random.Next(0, lstIntrebare.Items.Count);
                tbIntrebare.Text = lstIntrebare.Items[contor].ToString();
                tbRaspuns1.Text = lstR1.Items[contor].ToString();
                tbRaspuns2.Text = lstR2.Items[contor].ToString();
                tbRaspuns3.Text = lstR3.Items[contor].ToString();
                tbRaspuns4.Text = lstR4.Items[contor].ToString();
                RC = lstRC.Items[contor].ToString();
                tbINTR2.Text = lbID.Items[contor].ToString();

                pbGalicia.Visible = false;
                pbAndaluz.Visible = false;
                pbSwagonia.Visible = false;
                pbVoivodina.Visible = false;
                pbAmpulentia.Visible = false;
                pbClobaria.Visible = false;
                pbTortis.Visible = false;
                pbFloriopolis.Visible = false;

                tbIntrebare.Visible = true;
                tbRaspuns1.Visible = true;
                tbRaspuns2.Visible = true;
                tbRaspuns3.Visible = true;
                tbRaspuns4.Visible = true;
                RUNDA1--;
                lblture.Text = RUNDA1.ToString();
                lstIntrebare.Items.RemoveAt(contor);
                lstR1.Items.RemoveAt(contor);
                lstR2.Items.RemoveAt(contor);
                lstR3.Items.RemoveAt(contor);
                lstR4.Items.RemoveAt(contor);
                lstRC.Items.RemoveAt(contor);
                lbScor1.Text = ScorR1.ToString();
            }
            else
            {
                if (flag3 == 1)
                {
                    tmr.Enabled = true;
                    flag3 = 0;
                }
            }
        }

        private void pbVoivodina_Click(object sender, EventArgs e)
        {
            //      MessageBox.Show(RUNDA1.ToString());
            if (RUNDA1 > 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                alegere = 4;
                Random random = new Random();
                contor = random.Next(0, lstIntrebare.Items.Count);
                tbIntrebare.Text = lstIntrebare.Items[contor].ToString();
                tbRaspuns1.Text = lstR1.Items[contor].ToString();
                tbRaspuns2.Text = lstR2.Items[contor].ToString();
                tbRaspuns3.Text = lstR3.Items[contor].ToString();
                tbRaspuns4.Text = lstR4.Items[contor].ToString();
                RC = lstRC.Items[contor].ToString();
                tbINTR2.Text = lbID.Items[contor].ToString();

                pbGalicia.Visible = false;
                pbAndaluz.Visible = false;
                pbSwagonia.Visible = false;
                pbVoivodina.Visible = false;
                pbAmpulentia.Visible = false;
                pbClobaria.Visible = false;
                pbTortis.Visible = false;
                pbFloriopolis.Visible = false;

                tbIntrebare.Visible = true;
                tbRaspuns1.Visible = true;
                tbRaspuns2.Visible = true;
                tbRaspuns3.Visible = true;
                tbRaspuns4.Visible = true;
                RUNDA1--;
                lblture.Text = RUNDA1.ToString();
                lstIntrebare.Items.RemoveAt(contor);
                lstR1.Items.RemoveAt(contor);
                lstR2.Items.RemoveAt(contor);
                lstR3.Items.RemoveAt(contor);
                lstR4.Items.RemoveAt(contor);
                lstRC.Items.RemoveAt(contor);
                lbScor1.Text = ScorR1.ToString();
            }
            else
            {
                if (flag3 == 1)
                {
                    tmr.Enabled = true;
                    flag3 = 0;
                }
            }
        }

        private void pbAmpulentia_Click(object sender, EventArgs e)
        {
            //     MessageBox.Show(RUNDA1.ToString());
            if (RUNDA1 > 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                alegere = 5;
                Random random = new Random();
                contor = random.Next(0, lstIntrebare.Items.Count);
                tbIntrebare.Text = lstIntrebare.Items[contor].ToString();
                tbRaspuns1.Text = lstR1.Items[contor].ToString();
                tbRaspuns2.Text = lstR2.Items[contor].ToString();
                tbRaspuns3.Text = lstR3.Items[contor].ToString();
                tbRaspuns4.Text = lstR4.Items[contor].ToString();
                RC = lstRC.Items[contor].ToString();
                tbINTR2.Text = lbID.Items[contor].ToString();

                pbGalicia.Visible = false;
                pbAndaluz.Visible = false;
                pbSwagonia.Visible = false;
                pbVoivodina.Visible = false;
                pbAmpulentia.Visible = false;
                pbClobaria.Visible = false;
                pbTortis.Visible = false;
                pbFloriopolis.Visible = false;

                tbIntrebare.Visible = true;
                tbRaspuns1.Visible = true;
                tbRaspuns2.Visible = true;
                tbRaspuns3.Visible = true;
                tbRaspuns4.Visible = true;
                RUNDA1--;
                lblture.Text = RUNDA1.ToString();
                lstIntrebare.Items.RemoveAt(contor);
                lstR1.Items.RemoveAt(contor);
                lstR2.Items.RemoveAt(contor);
                lstR3.Items.RemoveAt(contor);
                lstR4.Items.RemoveAt(contor);
                lstRC.Items.RemoveAt(contor);
                lbScor1.Text = ScorR1.ToString();
            }
            else
            {
                if (flag3 == 1)
                {
                    tmr.Enabled = true;
                    flag3 = 0;
                }
            }
        }
        private void pbClobaria_Click(object sender, EventArgs e)
        {
            //    MessageBox.Show(RUNDA1.ToString());
            if (RUNDA1 > 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                alegere = 6;
                Random random = new Random();
                contor = random.Next(0, lstIntrebare.Items.Count);
                tbIntrebare.Text = lstIntrebare.Items[contor].ToString();
                tbRaspuns1.Text = lstR1.Items[contor].ToString();
                tbRaspuns2.Text = lstR2.Items[contor].ToString();
                tbRaspuns3.Text = lstR3.Items[contor].ToString();
                tbRaspuns4.Text = lstR4.Items[contor].ToString();
                RC = lstRC.Items[contor].ToString();
                tbINTR2.Text = lbID.Items[contor].ToString();

                pbGalicia.Visible = false;
                pbAndaluz.Visible = false;
                pbSwagonia.Visible = false;
                pbVoivodina.Visible = false;
                pbAmpulentia.Visible = false;
                pbClobaria.Visible = false;
                pbTortis.Visible = false;
                pbFloriopolis.Visible = false;

                tbIntrebare.Visible = true;
                tbRaspuns1.Visible = true;
                tbRaspuns2.Visible = true;
                tbRaspuns3.Visible = true;
                tbRaspuns4.Visible = true;
                RUNDA1--;
                lblture.Text = RUNDA1.ToString();
                lstIntrebare.Items.RemoveAt(contor);
                lstR1.Items.RemoveAt(contor);
                lstR2.Items.RemoveAt(contor);
                lstR3.Items.RemoveAt(contor);
                lstR4.Items.RemoveAt(contor);
                lstRC.Items.RemoveAt(contor);
                lbScor1.Text = ScorR1.ToString();
            }
            else
            {
                if (flag3 == 1)
                {
                    tmr.Enabled = true;
                    flag3 = 0;
                }
            }
        }

        private void pbTortis_Click(object sender, EventArgs e)
        {
            //    MessageBox.Show(RUNDA1.ToString());
            if (RUNDA1 > 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                alegere = 7;
                Random random = new Random();
                contor = random.Next(0, lstIntrebare.Items.Count);
                tbIntrebare.Text = lstIntrebare.Items[contor].ToString();
                tbRaspuns1.Text = lstR1.Items[contor].ToString();
                tbRaspuns2.Text = lstR2.Items[contor].ToString();
                tbRaspuns3.Text = lstR3.Items[contor].ToString();
                tbRaspuns4.Text = lstR4.Items[contor].ToString();
                RC = lstRC.Items[contor].ToString();
                tbINTR2.Text = lbID.Items[contor].ToString();

                pbGalicia.Visible = false;
                pbAndaluz.Visible = false;
                pbSwagonia.Visible = false;
                pbVoivodina.Visible = false;
                pbAmpulentia.Visible = false;
                pbClobaria.Visible = false;
                pbTortis.Visible = false;
                pbFloriopolis.Visible = false;

                tbIntrebare.Visible = true;
                tbRaspuns1.Visible = true;
                tbRaspuns2.Visible = true;
                tbRaspuns3.Visible = true;
                tbRaspuns4.Visible = true;
                RUNDA1--;
                lblture.Text = RUNDA1.ToString();
                lstIntrebare.Items.RemoveAt(contor);
                lstR1.Items.RemoveAt(contor);
                lstR2.Items.RemoveAt(contor);
                lstR3.Items.RemoveAt(contor);
                lstR4.Items.RemoveAt(contor);
                lstRC.Items.RemoveAt(contor);
                lbScor1.Text = ScorR1.ToString();
            }
            else
            {
                if (flag3 == 1)
                {
                    tmr.Enabled = true;
                    flag3 = 0;
                }
            }
        }

        private void pbFloriopolis_Click(object sender, EventArgs e)
        {
            //     MessageBox.Show(RUNDA1.ToString());
            if (RUNDA1 > 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                alegere = 8;
                Random random = new Random();
                contor = random.Next(0, lstIntrebare.Items.Count);
                tbIntrebare.Text = lstIntrebare.Items[contor].ToString();
                tbRaspuns1.Text = lstR1.Items[contor].ToString();
                tbRaspuns2.Text = lstR2.Items[contor].ToString();
                tbRaspuns3.Text = lstR3.Items[contor].ToString();
                tbRaspuns4.Text = lstR4.Items[contor].ToString();
                RC = lstRC.Items[contor].ToString();
                tbINTR2.Text = lbID.Items[contor].ToString();

                pbGalicia.Visible = false;
                pbAndaluz.Visible = false;
                pbSwagonia.Visible = false;
                pbVoivodina.Visible = false;
                pbAmpulentia.Visible = false;
                pbClobaria.Visible = false;
                pbTortis.Visible = false;
                pbFloriopolis.Visible = false;

                tbIntrebare.Visible = true;
                tbRaspuns1.Visible = true;
                tbRaspuns2.Visible = true;
                tbRaspuns3.Visible = true;
                tbRaspuns4.Visible = true;
                RUNDA1--;
                lblture.Text = RUNDA1.ToString();
                lstIntrebare.Items.RemoveAt(contor);
                lstR1.Items.RemoveAt(contor);
                lstR2.Items.RemoveAt(contor);
                lstR3.Items.RemoveAt(contor);
                lstR4.Items.RemoveAt(contor);
                lstRC.Items.RemoveAt(contor);
                lbScor1.Text = ScorR1.ToString();
            }
            else
            {
                if (flag3 == 1)
                {
                    tmr.Enabled = true;
                    flag3 = 0;
                }
            }
        }

        //   public int Galicia, Andaluz, Swagonia, Voivodina, Ampulentia, Clobaria, Tortis, Floriopolis;
        private void tbRaspuns4_Click(object sender, EventArgs e)
        {
            RA = tbRaspuns4.Text.ToString();
            if (RA == RC)
            {
                if (alegere == 1)
                {
                    pbGalicia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                    pbGalicia.Size = new Size(100, 64);
                    if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                }
                else
                {
                    if (alegere == 2)
                    {
                        pbAndaluz.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                        pbAndaluz.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                    }
                    else
                    {
                        if (alegere == 3)
                        {
                            pbSwagonia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                            pbSwagonia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                        }
                        else
                        {
                            if (alegere == 4)
                            {
                                pbVoivodina.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                pbVoivodina.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                            }
                            else
                            {
                                if (alegere == 5)
                                {
                                    pbAmpulentia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                    pbAmpulentia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                }
                                else
                                {
                                    if (alegere == 6)
                                    {
                                        pbClobaria.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                        pbClobaria.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                    }
                                    else
                                    {
                                        if (alegere == 7)
                                        {
                                            pbTortis.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                            pbTortis.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                        }
                                        else
                                        {
                                            if (alegere == 8)
                                            {
                                                pbFloriopolis.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                                pbFloriopolis.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
       //         if (RUNDA1 >= 0)
                {
                    if (alegere == 1)
                    {
                        ScorFR++;
                        pbGalicia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                        pbGalicia.Size = new Size(100, 64);
                    }
                    else
                    {
                        if (alegere == 2)
                        {
                            ScorFR++;
                            pbAndaluz.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                            pbAndaluz.Size = new Size(100, 64);
                        }
                        else
                        {
                            if (alegere == 3)
                            {
                                ScorFR++;
                                pbSwagonia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                pbSwagonia.Size = new Size(100, 64);
                            }
                            else
                            {
                                if (alegere == 4)
                                {
                                    ScorFR++;
                                    pbVoivodina.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                    pbVoivodina.Size = new Size(100, 64);
                                }
                                else
                                {
                                    if (alegere == 5)
                                    {
                                        ScorFR++;
                                        pbAmpulentia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                        pbAmpulentia.Size = new Size(100, 64);
                                    }
                                    else
                                    {
                                        if (alegere == 6)
                                        {
                                            ScorFR++;
                                            pbClobaria.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                            pbClobaria.Size = new Size(100, 64);
                                        }
                                        else
                                        {
                                            if (alegere == 7)
                                            {
                                                ScorFR++;
                                                pbTortis.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                                pbTortis.Size = new Size(100, 64);
                                            }
                                            else
                                            {
                                                if (alegere == 8)
                                                {
                                                    ScorFR++;
                                                    pbFloriopolis.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                                    pbFloriopolis.Size = new Size(100, 64);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            panel2.Visible = false;
            panel1.Visible = true;

            pbGalicia.Visible = true;
            pbAndaluz.Visible = true;
            pbSwagonia.Visible = true;
            pbVoivodina.Visible = true;
            pbAmpulentia.Visible = true;
            pbClobaria.Visible = true;
            pbTortis.Visible = true;
            pbFloriopolis.Visible = true;

            tbIntrebare.Visible = false;
            tbRaspuns1.Visible = false;
            tbRaspuns2.Visible = false;
            tbRaspuns3.Visible = false;
            tbRaspuns4.Visible = false;
        }

        private void tbRaspuns3_Click(object sender, EventArgs e)
        {
            RA = tbRaspuns3.Text.ToString();
            if (RA == RC)
            {
                if (alegere == 1)
                {
                    pbGalicia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                    pbGalicia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                }
                else
                {
                    if (alegere == 2)
                    {
                        pbAndaluz.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                        pbAndaluz.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                    }
                    else
                    {
                        if (alegere == 3)
                        {
                            pbSwagonia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                            pbSwagonia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                        }
                        else
                        {
                            if (alegere == 4)
                            {
                                pbVoivodina.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                pbVoivodina.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                            }
                            else
                            {
                                if (alegere == 5)
                                {
                                    pbAmpulentia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                    pbAmpulentia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                }
                                else
                                {
                                    if (alegere == 6)
                                    {
                                        pbClobaria.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                        pbClobaria.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                    }
                                    else
                                    {
                                        if (alegere == 7)
                                        {
                                            pbTortis.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                            pbTortis.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                        }
                                        else
                                        {
                                            if (alegere == 8)
                                            {
                                                pbFloriopolis.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                                pbFloriopolis.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
          //      if (RUNDA1 >= 0)
                {
                    if (alegere == 1)
                    {
                        ScorFR++;
                        pbGalicia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                        pbGalicia.Size = new Size(100, 64);
                    }
                    else
                    {
                        if (alegere == 2)
                        {
                            ScorFR++;
                            pbAndaluz.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                            pbAndaluz.Size = new Size(100, 64);
                        }
                        else
                        {
                            if (alegere == 3)
                            {
                                ScorFR++;
                                pbSwagonia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                pbSwagonia.Size = new Size(100, 64);
                            }
                            else
                            {
                                if (alegere == 4)
                                {
                                    ScorFR++;
                                    pbVoivodina.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                    pbVoivodina.Size = new Size(100, 64);
                                }
                                else
                                {
                                    if (alegere == 5)
                                    {
                                        ScorFR++;
                                        pbAmpulentia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                        pbAmpulentia.Size = new Size(100, 64);
                                    }
                                    else
                                    {
                                        if (alegere == 6)
                                        {
                                            ScorFR++;
                                            pbClobaria.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                            pbClobaria.Size = new Size(100, 64);
                                        }
                                        else
                                        {
                                            if (alegere == 7)
                                            {
                                                ScorFR++;
                                                pbTortis.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                                pbTortis.Size = new Size(100, 64);
                                            }
                                            else
                                            {
                                                if (alegere == 8)
                                                {
                                                    ScorFR++;
                                                    pbFloriopolis.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                                    pbFloriopolis.Size = new Size(100, 64);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            panel2.Visible = false;
            panel1.Visible = true;

            pbGalicia.Visible = true;
            pbAndaluz.Visible = true;
            pbSwagonia.Visible = true;
            pbVoivodina.Visible = true;
            pbAmpulentia.Visible = true;
            pbClobaria.Visible = true;
            pbTortis.Visible = true;
            pbFloriopolis.Visible = true;

            tbIntrebare.Visible = false;
            tbRaspuns1.Visible = false;
            tbRaspuns2.Visible = false;
            tbRaspuns3.Visible = false;
            tbRaspuns4.Visible = false;
        }

        private void tbRaspuns1_Click(object sender, EventArgs e)
        {
            RA = tbRaspuns1.Text.ToString();
            if (RA == RC)
            {
                if (alegere == 1)
                {
                    pbGalicia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                    pbGalicia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                }
                else
                {
                    if (alegere == 2)
                    {
                        pbAndaluz.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                        pbAndaluz.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                    }
                    else
                    {
                        if (alegere == 3)
                        {
                            pbSwagonia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                            pbSwagonia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                        }
                        else
                        {
                            if (alegere == 4)
                            {
                                pbVoivodina.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                pbVoivodina.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                            }
                            else
                            {
                                if (alegere == 5)
                                {
                                    pbAmpulentia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                    pbAmpulentia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                }
                                else
                                {
                                    if (alegere == 6)
                                    {
                                        pbClobaria.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                        pbClobaria.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                    }
                                    else
                                    {
                                        if (alegere == 7)
                                        {
                                            pbTortis.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                            pbTortis.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                        }
                                        else
                                        {
                                            if (alegere == 8)
                                            {
                                                pbFloriopolis.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                                pbFloriopolis.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
              //  if (RUNDA1 >= 0)
                {
                    if (alegere == 1)
                    {
                        ScorFR++;
                        pbGalicia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                        pbGalicia.Size = new Size(100, 64);
                    }
                    else
                    {
                        if (alegere == 2)
                        {
                            ScorFR++;
                            pbAndaluz.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                            pbAndaluz.Size = new Size(100, 64);
                        }
                        else
                        {
                            if (alegere == 3)
                            {
                                ScorFR++;
                                pbSwagonia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                pbSwagonia.Size = new Size(100, 64);
                            }
                            else
                            {
                                if (alegere == 4)
                                {
                                    ScorFR++;
                                    pbVoivodina.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                    pbVoivodina.Size = new Size(100, 64);
                                }
                                else
                                {
                                    if (alegere == 5)
                                    {
                                        ScorFR++;
                                        pbAmpulentia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                        pbAmpulentia.Size = new Size(100, 64);
                                    }
                                    else
                                    {
                                        if (alegere == 6)
                                        {
                                            ScorFR++;
                                            pbClobaria.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                            pbClobaria.Size = new Size(100, 64);
                                        }
                                        else
                                        {
                                            if (alegere == 7)
                                            {
                                                ScorFR++;
                                                pbTortis.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                                pbTortis.Size = new Size(100, 64);
                                            }
                                            else
                                            {
                                                if (alegere == 8)
                                                {
                                                    ScorFR++;
                                                    pbFloriopolis.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                                    pbFloriopolis.Size = new Size(100, 64);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            panel2.Visible = false;
            panel1.Visible = true;

            pbGalicia.Visible = true;
            pbAndaluz.Visible = true;
            pbSwagonia.Visible = true;
            pbVoivodina.Visible = true;
            pbAmpulentia.Visible = true;
            pbClobaria.Visible = true;
            pbTortis.Visible = true;
            pbFloriopolis.Visible = true;

            tbIntrebare.Visible = false;
            tbRaspuns1.Visible = false;
            tbRaspuns2.Visible = false;
            tbRaspuns3.Visible = false;
            tbRaspuns4.Visible = false;
        }

        private void tbRaspuns2_Click(object sender, EventArgs e)
        {
            RA = tbRaspuns2.Text.ToString();
            if (RA == RC)
            {
                if (alegere == 1)
                {
                    pbGalicia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                    pbGalicia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } } //if (RUNDA2 == 0) { MessageBox.Show("Jocul s-a terminat , media punctelor tale din cele 2 runde este " + (ScorR1 + ScorR2) / 2 + 1); }
                }
                else
                {
                    if (alegere == 2)
                    {
                        pbAndaluz.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                        pbAndaluz.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }// if (RUNDA2 == 0) { MessageBox.Show("Jocul s-a terminat , media punctelor tale din cele 2 runde este " + (ScorR1 + ScorR2) / 2 + 1); }
                    }
                    else
                    {
                        if (alegere == 3)
                        {
                            pbSwagonia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                            pbSwagonia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }// if (RUNDA2 == 0) { MessageBox.Show("Jocul s-a terminat , media punctelor tale din cele 2 runde este " + (ScorR1 + ScorR2) / 2 + 1); }
                        }
                        else
                        {
                            if (alegere == 4)
                            {
                                pbVoivodina.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                pbVoivodina.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } } //if (RUNDA2 == 0) { MessageBox.Show("Jocul s-a terminat , media punctelor tale din cele 2 runde este " + (ScorR1 + ScorR2) / 2 + 1); }
                            }
                            else
                            {
                                if (alegere == 5)
                                {
                                    pbAmpulentia.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                    pbAmpulentia.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } } //if (RUNDA2 == 0) { MessageBox.Show("Jocul s-a terminat , media punctelor tale din cele 2 runde este " + (ScorR1 + ScorR2) / 2 + 1); }
                                }
                                else
                                {
                                    if (alegere == 6)
                                    {
                                        pbClobaria.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                        pbClobaria.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } } //if (RUNDA2 == 0) { MessageBox.Show("Jocul s-a terminat , media punctelor tale din cele 2 runde este " + (ScorR1 + ScorR2) / 2 + 1); }
                                    }
                                    else
                                    {
                                        if (alegere == 7)
                                        {
                                            pbTortis.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                            pbTortis.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } } //if (RUNDA2 == 0) { MessageBox.Show("Jocul s-a terminat , media punctelor tale din cele 2 runde este " + (ScorR1 + ScorR2) / 2 + 1); }
                                        }
                                        else
                                        {
                                            if (alegere == 8)
                                            {
                                                pbFloriopolis.Image = System.Drawing.Image.FromFile(cale + "\\art\\uk-flag-small.jpg");
                                                pbFloriopolis.Size = new Size(100, 64); if (RUNDA1 > 0) { ScorR1++; } else { if (RUNDA2 > 0) { ScorR1++; flag2 = 1; } }// if (RUNDA2 == 0) { MessageBox.Show("Jocul s-a terminat , media punctelor tale din cele 2 runde este " + (ScorR1 + ScorR2) / 2 + 1); }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
             //   if (RUNDA1 >= 0)
                {
                    if (alegere == 1)
                    {
                        ScorFR++;
                        pbGalicia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                        pbGalicia.Size = new Size(100, 64);
                    }
                    else
                    {
                        if (alegere == 2)
                        {
                            ScorFR++;
                            pbAndaluz.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                            pbAndaluz.Size = new Size(100, 64);
                        }
                        else
                        {
                            if (alegere == 3)
                            {ScorFR++;
                                pbSwagonia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                pbSwagonia.Size = new Size(100, 64);
                            }
                            else
                            {
                                if (alegere == 4)
                                {
                                    ScorFR++;
                                    pbVoivodina.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                    pbVoivodina.Size = new Size(100, 64);
                                }
                                else
                                {
                                    if (alegere == 5)
                                    {
                                        ScorFR++;
                                        pbAmpulentia.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                        pbAmpulentia.Size = new Size(100, 64);
                                    }
                                    else
                                    {
                                        if (alegere == 6)
                                        {
                                            ScorFR++;
                                            pbClobaria.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                            pbClobaria.Size = new Size(100, 64);
                                        }
                                        else
                                        {
                                            if (alegere == 7)
                                            {
                                                ScorFR++;
                                                pbTortis.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                                pbTortis.Size = new Size(100, 64);
                                            }
                                            else
                                            {
                                                if (alegere == 8)
                                                {
                                                    ScorFR++;
                                                    pbFloriopolis.Image = System.Drawing.Image.FromFile(cale + "\\art\\france-flag-small.jpg");
                                                    pbFloriopolis.Size = new Size(100, 64);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            panel2.Visible = false;
            panel1.Visible = true;

            pbGalicia.Visible = true;
            pbAndaluz.Visible = true;
            pbSwagonia.Visible = true;
            pbVoivodina.Visible = true;
            pbAmpulentia.Visible = true;
            pbClobaria.Visible = true;
            pbTortis.Visible = true;
            pbFloriopolis.Visible = true;

            tbIntrebare.Visible = false;
            tbRaspuns1.Visible = false;
            tbRaspuns2.Visible = false;
            tbRaspuns3.Visible = false;
            tbRaspuns4.Visible = false;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                MessageBox.Show("Runda 2 a inceput ! Raspunde la intrebari pentru a-ti mari scorul! Acestea apar la un interval setat de secunde si dispar in acelasi interval , asa ca pregateste-te! .");
                flag = 0;
            }
            Random random = new Random();
            contor = random.Next(0, lstIntrebare.Items.Count);
            tbIntrebare.Text = lstIntrebare.Items[contor].ToString();
            tbRaspuns1.Text = lstR1.Items[contor].ToString();
            tbRaspuns2.Text = lstR2.Items[contor].ToString();
            tbRaspuns3.Text = lstR3.Items[contor].ToString();
            tbRaspuns4.Text = lstR4.Items[contor].ToString();
            RC = lstRC.Items[contor].ToString();
            panel1.Visible = false;
            panel2.Visible = true;
            pbGalicia.Visible = false;
            pbAndaluz.Visible = false;
            pbSwagonia.Visible = false;
            pbVoivodina.Visible = false;
            pbAmpulentia.Visible = false;
            pbClobaria.Visible = false;
            pbTortis.Visible = false;
            pbFloriopolis.Visible = false;

            tbIntrebare.Visible = true;
            tbRaspuns1.Visible = true;
            tbRaspuns2.Visible = true;
            tbRaspuns3.Visible = true;
            tbRaspuns4.Visible = true;
            RUNDA2--;
            lblR2.Text = RUNDA2.ToString();
            lblScor2.Text = ScorR2.ToString();
            lstIntrebare.Items.RemoveAt(contor);
            lstR1.Items.RemoveAt(contor);
            lstR2.Items.RemoveAt(contor);
            lstR3.Items.RemoveAt(contor);
            lstR4.Items.RemoveAt(contor);
            lstRC.Items.RemoveAt(contor);

            lblR2.Text = RUNDA2.ToString();
            lblScor2.Text = ScorR2.ToString();
            if (RUNDA2 == 0)
            {
                
                tmr.Enabled = false;
                pbGalicia.Visible = true;
                pbAndaluz.Visible = true;
                pbSwagonia.Visible = true;
                pbVoivodina.Visible = true;
                pbAmpulentia.Visible = true;
                pbClobaria.Visible = true;
                pbTortis.Visible = true;
                pbFloriopolis.Visible = true;

                tbIntrebare.Visible = false;
                tbRaspuns1.Visible = false;
                tbRaspuns2.Visible = false;
                tbRaspuns3.Visible = false;
                tbRaspuns4.Visible = false;
                H = (ScorR1 + ScorR2) / 2;
                string h = H.ToString();
                lblFinal.Text = h;
                lblScorUK.Text = ScorR1.ToString();
                lblScorFR.Text = ScorFR.ToString();
                MessageBox.Show("Felicitari! Ai terminat testul, speram ca ai invatat ceva .");

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                con.Open();
                string qs = "Insert into Scoruri (Mail,Joc,Scor) values (@mail,@joc,@scor)";
                OleDbCommand com = new OleDbCommand(qs, con);
                com.Parameters.AddWithValue("Mail", ((Main)this.MdiParent).nume);
                com.Parameters.AddWithValue("Joc", "Cucerire");
                com.Parameters.AddWithValue("Scor", lblScorUK.Text.ToString());
                int asd = com.ExecuteNonQuery();
                con.Close();
            }

        }

        private void FrmJoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Main)this.MdiParent).fCopil6 = null;
        }
        Point lastPoint;
        private void FrmJoc_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void FrmJoc_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }


    }