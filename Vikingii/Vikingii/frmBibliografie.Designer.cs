﻿namespace Imperiul_Britanic
{
    partial class frmBibliografie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBibliografie));
            this.pbInainte = new System.Windows.Forms.PictureBox();
            this.pbInapoi = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lbltext = new System.Windows.Forms.Label();
            this.lstImagini = new System.Windows.Forms.ListBox();
            this.lstLink = new System.Windows.Forms.ListBox();
            this.pbImagineMare = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbInainte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInapoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagineMare)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInainte
            // 
            this.pbInainte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInainte.Image = ((System.Drawing.Image)(resources.GetObject("pbInainte.Image")));
            this.pbInainte.Location = new System.Drawing.Point(455, 510);
            this.pbInainte.Name = "pbInainte";
            this.pbInainte.Size = new System.Drawing.Size(44, 43);
            this.pbInainte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInainte.TabIndex = 14;
            this.pbInainte.TabStop = false;
            this.pbInainte.Click += new System.EventHandler(this.pbInainte_Click);
            // 
            // pbInapoi
            // 
            this.pbInapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInapoi.Image = ((System.Drawing.Image)(resources.GetObject("pbInapoi.Image")));
            this.pbInapoi.Location = new System.Drawing.Point(50, 510);
            this.pbInapoi.Name = "pbInapoi";
            this.pbInapoi.Size = new System.Drawing.Size(44, 43);
            this.pbInapoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInapoi.TabIndex = 13;
            this.pbInapoi.TabStop = false;
            this.pbInapoi.Click += new System.EventHandler(this.pbInapoi_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(505, 23);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 25;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lbltext
            // 
            this.lbltext.BackColor = System.Drawing.Color.Transparent;
            this.lbltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.Location = new System.Drawing.Point(50, 438);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(449, 62);
            this.lbltext.TabIndex = 26;
            // 
            // lstImagini
            // 
            this.lstImagini.FormattingEnabled = true;
            this.lstImagini.Items.AddRange(new object[] {
            "norden.png",
            "varangian.jpg",
            "medieval.jpg",
            "logo.png"});
            this.lstImagini.Location = new System.Drawing.Point(13, 23);
            this.lstImagini.Name = "lstImagini";
            this.lstImagini.Size = new System.Drawing.Size(56, 17);
            this.lstImagini.TabIndex = 28;
            this.lstImagini.Visible = false;
            // 
            // lstLink
            // 
            this.lstLink.FormattingEnabled = true;
            this.lstLink.Items.AddRange(new object[] {
            "Norden och kontinenten i gammal tid : https://books.google.ro/books?id=7FTUAAAAMA" +
                "AJ&redir_esc=y",
            "The Varangian Guard : https://books.google.ro/books?id=rKj8_W9wL7kC&pg=PA3&redir_" +
                "esc=y#v=onepage&q&f=false",
            resources.GetString("lstLink.Items"),
            "http://www.britannica.com/topic/Viking-people"});
            this.lstLink.Location = new System.Drawing.Point(13, 46);
            this.lstLink.Name = "lstLink";
            this.lstLink.Size = new System.Drawing.Size(56, 17);
            this.lstLink.TabIndex = 28;
            this.lstLink.Visible = false;
            // 
            // pbImagineMare
            // 
            this.pbImagineMare.BackColor = System.Drawing.Color.Transparent;
            this.pbImagineMare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagineMare.Location = new System.Drawing.Point(50, 57);
            this.pbImagineMare.Name = "pbImagineMare";
            this.pbImagineMare.Size = new System.Drawing.Size(449, 375);
            this.pbImagineMare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagineMare.TabIndex = 29;
            this.pbImagineMare.TabStop = false;
            this.pbImagineMare.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(189, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bibliografie";
            // 
            // frmBibliografie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(108)))), ((int)(((byte)(137)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagineMare);
            this.Controls.Add(this.lstLink);
            this.Controls.Add(this.lstImagini);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbInainte);
            this.Controls.Add(this.pbInapoi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBibliografie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBibliografie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBibliografie_FormClosed);
            this.Load += new System.EventHandler(this.frmBibliografie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInainte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInapoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagineMare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInainte;
        private System.Windows.Forms.PictureBox pbInapoi;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.ListBox lstImagini;
        private System.Windows.Forms.ListBox lstLink;
        private System.Windows.Forms.PictureBox pbImagineMare;
        private System.Windows.Forms.Label label1;
    }
}