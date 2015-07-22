namespace Imperiul_Britanic
{
    partial class frmSpanzura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpanzura));
            this.label3 = new System.Windows.Forms.Label();
            this.btnJn = new System.Windows.Forms.Button();
            this.lblJP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJC = new System.Windows.Forms.Label();
            this.pbG = new System.Windows.Forms.PictureBox();
            this.lblModel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbG)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(478, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // btnJn
            // 
            this.btnJn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJn.ForeColor = System.Drawing.Color.Firebrick;
            this.btnJn.Location = new System.Drawing.Point(563, 332);
            this.btnJn.Name = "btnJn";
            this.btnJn.Size = new System.Drawing.Size(180, 27);
            this.btnJn.TabIndex = 10;
            this.btnJn.Text = "Joacă din  nou !";
            this.btnJn.UseVisualStyleBackColor = true;
            this.btnJn.Click += new System.EventHandler(this.btnJn_Click);
            // 
            // lblJP
            // 
            this.lblJP.AutoSize = true;
            this.lblJP.BackColor = System.Drawing.Color.Transparent;
            this.lblJP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJP.Location = new System.Drawing.Point(524, 336);
            this.lblJP.Name = "lblJP";
            this.lblJP.Size = new System.Drawing.Size(19, 20);
            this.lblJP.TabIndex = 5;
            this.lblJP.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(435, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Scor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(510, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // lblJC
            // 
            this.lblJC.AutoSize = true;
            this.lblJC.BackColor = System.Drawing.Color.Transparent;
            this.lblJC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJC.Location = new System.Drawing.Point(494, 336);
            this.lblJC.Name = "lblJC";
            this.lblJC.Size = new System.Drawing.Size(19, 20);
            this.lblJC.TabIndex = 8;
            this.lblJC.Text = "0";
            // 
            // pbG
            // 
            this.pbG.BackColor = System.Drawing.Color.Transparent;
            this.pbG.Location = new System.Drawing.Point(445, 33);
            this.pbG.Name = "pbG";
            this.pbG.Size = new System.Drawing.Size(298, 274);
            this.pbG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbG.TabIndex = 9;
            this.pbG.TabStop = false;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(24, 33);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(21, 20);
            this.lblModel.TabIndex = 12;
            this.lblModel.Text = "A";
            this.lblModel.Visible = false;
            // 
            // frmSpanzura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(125)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 434);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnJn);
            this.Controls.Add(this.lblJP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblJC);
            this.Controls.Add(this.pbG);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmSpanzura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSpanzura";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSpanzura_FormClosed);
            this.Load += new System.EventHandler(this.frmSpanzura_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSpanzura_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSpanzura_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnJn;
        private System.Windows.Forms.Label lblJP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJC;
        private System.Windows.Forms.PictureBox pbG;
        private System.Windows.Forms.Label lblModel;
    }
}