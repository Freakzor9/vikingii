namespace Imperiul_Britanic
{
    partial class FrmLectii
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLectii));
            this.pbInainte = new System.Windows.Forms.PictureBox();
            this.pbInapoi = new System.Windows.Forms.PictureBox();
            this.pbImagineMare = new System.Windows.Forms.PictureBox();
            this.tbIstoricTitlu = new System.Windows.Forms.TextBox();
            this.rtInceputuri = new System.Windows.Forms.RichTextBox();
            this.lstImagini = new System.Windows.Forms.ListBox();
            this.panMare = new System.Windows.Forms.Panel();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.panMic = new System.Windows.Forms.Panel();
            this.lblVizualizare = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lstTitlu = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbAdaugare = new System.Windows.Forms.PictureBox();
            this.pbTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInainte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInapoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagineMare)).BeginInit();
            this.panMare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdaugare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInainte
            // 
            this.pbInainte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInainte.Image = ((System.Drawing.Image)(resources.GetObject("pbInainte.Image")));
            this.pbInainte.Location = new System.Drawing.Point(829, 284);
            this.pbInainte.Name = "pbInainte";
            this.pbInainte.Size = new System.Drawing.Size(44, 43);
            this.pbInainte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInainte.TabIndex = 12;
            this.pbInainte.TabStop = false;
            this.pbInainte.Click += new System.EventHandler(this.pbInainte_Click);
            // 
            // pbInapoi
            // 
            this.pbInapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInapoi.Image = ((System.Drawing.Image)(resources.GetObject("pbInapoi.Image")));
            this.pbInapoi.Location = new System.Drawing.Point(413, 284);
            this.pbInapoi.Name = "pbInapoi";
            this.pbInapoi.Size = new System.Drawing.Size(44, 43);
            this.pbInapoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInapoi.TabIndex = 11;
            this.pbInapoi.TabStop = false;
            this.pbInapoi.Click += new System.EventHandler(this.pbInapoi_Click);
            // 
            // pbImagineMare
            // 
            this.pbImagineMare.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbImagineMare.Image = ((System.Drawing.Image)(resources.GetObject("pbImagineMare.Image")));
            this.pbImagineMare.Location = new System.Drawing.Point(8, 6);
            this.pbImagineMare.Name = "pbImagineMare";
            this.pbImagineMare.Size = new System.Drawing.Size(345, 346);
            this.pbImagineMare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagineMare.TabIndex = 10;
            this.pbImagineMare.TabStop = false;
            // 
            // tbIstoricTitlu
            // 
            this.tbIstoricTitlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(108)))), ((int)(((byte)(137)))));
            this.tbIstoricTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIstoricTitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.tbIstoricTitlu.Location = new System.Drawing.Point(227, 47);
            this.tbIstoricTitlu.Name = "tbIstoricTitlu";
            this.tbIstoricTitlu.ReadOnly = true;
            this.tbIstoricTitlu.Size = new System.Drawing.Size(381, 38);
            this.tbIstoricTitlu.TabIndex = 8;
            this.tbIstoricTitlu.Text = "Inceputurile Imperiului Britanic";
            this.tbIstoricTitlu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtInceputuri
            // 
            this.rtInceputuri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(108)))), ((int)(((byte)(137)))));
            this.rtInceputuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtInceputuri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.rtInceputuri.Location = new System.Drawing.Point(33, 108);
            this.rtInceputuri.Name = "rtInceputuri";
            this.rtInceputuri.ReadOnly = true;
            this.rtInceputuri.Size = new System.Drawing.Size(368, 444);
            this.rtInceputuri.TabIndex = 16;
            this.rtInceputuri.Text = "";
            // 
            // lstImagini
            // 
            this.lstImagini.Location = new System.Drawing.Point(414, 333);
            this.lstImagini.MultiColumn = true;
            this.lstImagini.Name = "lstImagini";
            this.lstImagini.Size = new System.Drawing.Size(45, 199);
            this.lstImagini.TabIndex = 1;
            this.lstImagini.UseTabStops = false;
            this.lstImagini.Visible = false;
            // 
            // panMare
            // 
            this.panMare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(108)))), ((int)(((byte)(137)))));
            this.panMare.Controls.Add(this.pbImagineMare);
            this.panMare.Controls.Add(this.txtTitlu);
            this.panMare.Location = new System.Drawing.Point(465, 135);
            this.panMare.Name = "panMare";
            this.panMare.Size = new System.Drawing.Size(360, 383);
            this.panMare.TabIndex = 22;
            // 
            // txtTitlu
            // 
            this.txtTitlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(108)))), ((int)(((byte)(137)))));
            this.txtTitlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.txtTitlu.Location = new System.Drawing.Point(7, 358);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.ReadOnly = true;
            this.txtTitlu.Size = new System.Drawing.Size(347, 22);
            this.txtTitlu.TabIndex = 11;
            this.txtTitlu.Text = "Descrierea imaginii";
            this.txtTitlu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panMic
            // 
            this.panMic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panMic.Location = new System.Drawing.Point(465, 135);
            this.panMic.Name = "panMic";
            this.panMic.Size = new System.Drawing.Size(360, 360);
            this.panMic.TabIndex = 22;
            this.panMic.Visible = false;
            // 
            // lblVizualizare
            // 
            this.lblVizualizare.AutoSize = true;
            this.lblVizualizare.BackColor = System.Drawing.Color.Transparent;
            this.lblVizualizare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVizualizare.Location = new System.Drawing.Point(710, 118);
            this.lblVizualizare.Name = "lblVizualizare";
            this.lblVizualizare.Size = new System.Drawing.Size(115, 13);
            this.lblVizualizare.TabIndex = 23;
            this.lblVizualizare.Text = "Vezi imaginile in paralel";
            this.lblVizualizare.Click += new System.EventHandler(this.lblVizualizare_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg";
            this.ofd.Title = "Adaugare imagine";
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(465, 105);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(25, 25);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 24;
            this.pbAdd.TabStop = false;
            this.toolTip.SetToolTip(this.pbAdd, "Adauga imagine");
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbDel
            // 
            this.pbDel.BackColor = System.Drawing.Color.Transparent;
            this.pbDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDel.Image = ((System.Drawing.Image)(resources.GetObject("pbDel.Image")));
            this.pbDel.Location = new System.Drawing.Point(496, 106);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(25, 25);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDel.TabIndex = 24;
            this.pbDel.TabStop = false;
            this.toolTip.SetToolTip(this.pbDel, "Sterge imaginea selectata");
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(849, 18);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 24;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lstTitlu
            // 
            this.lstTitlu.FormattingEnabled = true;
            this.lstTitlu.Location = new System.Drawing.Point(413, 131);
            this.lstTitlu.Name = "lstTitlu";
            this.lstTitlu.Size = new System.Drawing.Size(44, 147);
            this.lstTitlu.TabIndex = 2;
            this.lstTitlu.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(902, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pbAdaugare
            // 
            this.pbAdaugare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdaugare.Image = ((System.Drawing.Image)(resources.GetObject("pbAdaugare.Image")));
            this.pbAdaugare.Location = new System.Drawing.Point(526, 524);
            this.pbAdaugare.Name = "pbAdaugare";
            this.pbAdaugare.Size = new System.Drawing.Size(198, 44);
            this.pbAdaugare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAdaugare.TabIndex = 25;
            this.pbAdaugare.TabStop = false;
            this.pbAdaugare.Visible = false;
            this.pbAdaugare.Click += new System.EventHandler(this.pbAdaugare_Click_1);
            // 
            // pbTest
            // 
            this.pbTest.BackColor = System.Drawing.Color.Transparent;
            this.pbTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTest.Image = ((System.Drawing.Image)(resources.GetObject("pbTest.Image")));
            this.pbTest.Location = new System.Drawing.Point(848, 49);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(25, 25);
            this.pbTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTest.TabIndex = 24;
            this.pbTest.TabStop = false;
            this.pbTest.Click += new System.EventHandler(this.pbTest_Click);
            // 
            // FrmLectii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(125)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 595);
            this.Controls.Add(this.pbAdaugare);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstTitlu);
            this.Controls.Add(this.pbTest);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.lblVizualizare);
            this.Controls.Add(this.lstImagini);
            this.Controls.Add(this.rtInceputuri);
            this.Controls.Add(this.pbInainte);
            this.Controls.Add(this.pbInapoi);
            this.Controls.Add(this.tbIstoricTitlu);
            this.Controls.Add(this.panMare);
            this.Controls.Add(this.panMic);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLectii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inceputul Expansiunii Britanice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInceputuri_FormClosed);
            this.Load += new System.EventHandler(this.FrmInceputuri_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmInceputuri_KeyPress);
            this.Leave += new System.EventHandler(this.FrmInceputuri_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLectii_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLectii_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbInainte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInapoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagineMare)).EndInit();
            this.panMare.ResumeLayout(false);
            this.panMare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdaugare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInainte;
        private System.Windows.Forms.PictureBox pbInapoi;
        private System.Windows.Forms.PictureBox pbImagineMare;
        private System.Windows.Forms.TextBox tbIstoricTitlu;
        private System.Windows.Forms.RichTextBox rtInceputuri;
        private System.Windows.Forms.ListBox lstImagini;
        private System.Windows.Forms.Panel panMare;
        private System.Windows.Forms.Panel panMic;
        private System.Windows.Forms.Label lblVizualizare;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.ListBox lstTitlu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbAdaugare;
        private System.Windows.Forms.PictureBox pbTest;
    }
}