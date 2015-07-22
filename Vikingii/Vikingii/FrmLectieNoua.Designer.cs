namespace Imperiul_Britanic
{
    partial class FrmLectieNoua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLectieNoua));
            this.pbAdaugare = new System.Windows.Forms.PictureBox();
            this.lstTitlu = new System.Windows.Forms.ListBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lstImagini = new System.Windows.Forms.ListBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblVizualizare = new System.Windows.Forms.Label();
            this.rtLectie = new System.Windows.Forms.RichTextBox();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.panMare = new System.Windows.Forms.Panel();
            this.pbImagineMare = new System.Windows.Forms.PictureBox();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.pbInainte = new System.Windows.Forms.PictureBox();
            this.pbInapoi = new System.Windows.Forms.PictureBox();
            this.panMic = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdaugare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.panMare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagineMare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInainte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInapoi)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAdaugare
            // 
            this.pbAdaugare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdaugare.Image = ((System.Drawing.Image)(resources.GetObject("pbAdaugare.Image")));
            this.pbAdaugare.Location = new System.Drawing.Point(518, 492);
            this.pbAdaugare.Name = "pbAdaugare";
            this.pbAdaugare.Size = new System.Drawing.Size(198, 44);
            this.pbAdaugare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAdaugare.TabIndex = 39;
            this.pbAdaugare.TabStop = false;
            this.pbAdaugare.Visible = false;
            // 
            // lstTitlu
            // 
            this.lstTitlu.FormattingEnabled = true;
            this.lstTitlu.Location = new System.Drawing.Point(402, 131);
            this.lstTitlu.Name = "lstTitlu";
            this.lstTitlu.Size = new System.Drawing.Size(44, 147);
            this.lstTitlu.TabIndex = 28;
            this.lstTitlu.Visible = false;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(838, 18);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 36;
            this.pbClose.TabStop = false;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // pbDel
            // 
            this.pbDel.BackColor = System.Drawing.Color.Transparent;
            this.pbDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDel.Image = ((System.Drawing.Image)(resources.GetObject("pbDel.Image")));
            this.pbDel.Location = new System.Drawing.Point(488, 74);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(25, 25);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDel.TabIndex = 37;
            this.pbDel.TabStop = false;
            this.toolTip.SetToolTip(this.pbDel, "Sterge imaginea selectata");
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(457, 73);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(25, 25);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 38;
            this.pbAdd.TabStop = false;
            this.toolTip.SetToolTip(this.pbAdd, "Adauga imagine");
            // 
            // lstImagini
            // 
            this.lstImagini.Location = new System.Drawing.Point(403, 333);
            this.lstImagini.MultiColumn = true;
            this.lstImagini.Name = "lstImagini";
            this.lstImagini.Size = new System.Drawing.Size(45, 199);
            this.lstImagini.TabIndex = 27;
            this.lstImagini.UseTabStops = false;
            this.lstImagini.Visible = false;
            // 
            // ofd
            // 
            this.ofd.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg";
            this.ofd.Title = "Adaugare imagine";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(894, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            // 
            // lblVizualizare
            // 
            this.lblVizualizare.AutoSize = true;
            this.lblVizualizare.BackColor = System.Drawing.Color.Transparent;
            this.lblVizualizare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVizualizare.Location = new System.Drawing.Point(702, 86);
            this.lblVizualizare.Name = "lblVizualizare";
            this.lblVizualizare.Size = new System.Drawing.Size(115, 13);
            this.lblVizualizare.TabIndex = 35;
            this.lblVizualizare.Text = "Vezi imaginile in paralel";
            // 
            // rtLectie
            // 
            this.rtLectie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.rtLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtLectie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.rtLectie.Location = new System.Drawing.Point(28, 88);
            this.rtLectie.Name = "rtLectie";
            this.rtLectie.ReadOnly = true;
            this.rtLectie.Size = new System.Drawing.Size(368, 444);
            this.rtLectie.TabIndex = 32;
            this.rtLectie.Text = "";
            // 
            // tbTitlu
            // 
            this.tbTitlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.tbTitlu.Location = new System.Drawing.Point(227, 29);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.ReadOnly = true;
            this.tbTitlu.Size = new System.Drawing.Size(381, 38);
            this.tbTitlu.TabIndex = 29;
            this.tbTitlu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panMare
            // 
            this.panMare.Controls.Add(this.pbImagineMare);
            this.panMare.Controls.Add(this.txtTitlu);
            this.panMare.Location = new System.Drawing.Point(457, 103);
            this.panMare.Name = "panMare";
            this.panMare.Size = new System.Drawing.Size(360, 383);
            this.panMare.TabIndex = 33;
            // 
            // pbImagineMare
            // 
            this.pbImagineMare.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbImagineMare.Location = new System.Drawing.Point(7, 11);
            this.pbImagineMare.Name = "pbImagineMare";
            this.pbImagineMare.Size = new System.Drawing.Size(345, 346);
            this.pbImagineMare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagineMare.TabIndex = 10;
            this.pbImagineMare.TabStop = false;
            // 
            // txtTitlu
            // 
            this.txtTitlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtTitlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.txtTitlu.Location = new System.Drawing.Point(7, 358);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.ReadOnly = true;
            this.txtTitlu.Size = new System.Drawing.Size(345, 22);
            this.txtTitlu.TabIndex = 11;
            this.txtTitlu.Text = "Descrierea imaginii";
            this.txtTitlu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbInainte
            // 
            this.pbInainte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInainte.Image = ((System.Drawing.Image)(resources.GetObject("pbInainte.Image")));
            this.pbInainte.Location = new System.Drawing.Point(821, 252);
            this.pbInainte.Name = "pbInainte";
            this.pbInainte.Size = new System.Drawing.Size(44, 43);
            this.pbInainte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInainte.TabIndex = 31;
            this.pbInainte.TabStop = false;
            // 
            // pbInapoi
            // 
            this.pbInapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInapoi.Image = ((System.Drawing.Image)(resources.GetObject("pbInapoi.Image")));
            this.pbInapoi.Location = new System.Drawing.Point(402, 284);
            this.pbInapoi.Name = "pbInapoi";
            this.pbInapoi.Size = new System.Drawing.Size(44, 43);
            this.pbInapoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInapoi.TabIndex = 30;
            this.pbInapoi.TabStop = false;
            // 
            // panMic
            // 
            this.panMic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panMic.Location = new System.Drawing.Point(457, 103);
            this.panMic.Name = "panMic";
            this.panMic.Size = new System.Drawing.Size(360, 360);
            this.panMic.TabIndex = 34;
            this.panMic.Visible = false;
            // 
            // FrmLectieNoua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 557);
            this.Controls.Add(this.pbAdaugare);
            this.Controls.Add(this.lstTitlu);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.lstImagini);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblVizualizare);
            this.Controls.Add(this.rtLectie);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.panMare);
            this.Controls.Add(this.pbInainte);
            this.Controls.Add(this.pbInapoi);
            this.Controls.Add(this.panMic);
            this.DoubleBuffered = true;
            this.Name = "FrmLectieNoua";
            this.Text = "Lectie noua";
            ((System.ComponentModel.ISupportInitialize)(this.pbAdaugare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.panMare.ResumeLayout(false);
            this.panMare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagineMare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInainte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInapoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAdaugare;
        private System.Windows.Forms.ListBox lstTitlu;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.ListBox lstImagini;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblVizualizare;
        private System.Windows.Forms.RichTextBox rtLectie;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.Panel panMare;
        private System.Windows.Forms.PictureBox pbImagineMare;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.PictureBox pbInainte;
        private System.Windows.Forms.PictureBox pbInapoi;
        private System.Windows.Forms.Panel panMic;

    }
}