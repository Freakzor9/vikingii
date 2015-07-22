namespace Imperiul_Britanic
{
    partial class FrmAutentificare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutentificare));
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbNume2 = new System.Windows.Forms.TextBox();
            this.tbParola1 = new System.Windows.Forms.TextBox();
            this.tbParola2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Enabled = false;
            this.tbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNume.Location = new System.Drawing.Point(40, 52);
            this.tbNume.Multiline = true;
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(296, 32);
            this.tbNume.TabIndex = 0;
            this.tbNume.Text = "Nume Utilizator";
            // 
            // tbNume2
            // 
            this.tbNume2.Location = new System.Drawing.Point(40, 101);
            this.tbNume2.Multiline = true;
            this.tbNume2.Name = "tbNume2";
            this.tbNume2.Size = new System.Drawing.Size(296, 32);
            this.tbNume2.TabIndex = 1;
            // 
            // tbParola1
            // 
            this.tbParola1.Enabled = false;
            this.tbParola1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbParola1.Location = new System.Drawing.Point(40, 148);
            this.tbParola1.Multiline = true;
            this.tbParola1.Name = "tbParola1";
            this.tbParola1.Size = new System.Drawing.Size(296, 32);
            this.tbParola1.TabIndex = 2;
            this.tbParola1.Text = "Parola";
            // 
            // tbParola2
            // 
            this.tbParola2.Location = new System.Drawing.Point(40, 198);
            this.tbParola2.Multiline = true;
            this.tbParola2.Name = "tbParola2";
            this.tbParola2.PasswordChar = '*';
            this.tbParola2.Size = new System.Drawing.Size(296, 32);
            this.tbParola2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 396);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(122, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nu ai cont? Inregistreaza-te aici";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(125)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(385, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbParola2);
            this.Controls.Add(this.tbParola1);
            this.Controls.Add(this.tbNume2);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAutentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAutentificare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAutentificare_FormClosed);
            this.Load += new System.EventHandler(this.FrmAutentificare_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmAutentificare_KeyPress);
            this.Leave += new System.EventHandler(this.FrmAutentificare_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAutentificare_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAutentificare_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbNume2;
        private System.Windows.Forms.TextBox tbParola1;
        private System.Windows.Forms.TextBox tbParola2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}