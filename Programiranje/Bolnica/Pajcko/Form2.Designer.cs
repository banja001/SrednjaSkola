namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.log = new System.Windows.Forms.Button();
            this.kori = new System.Windows.Forms.TextBox();
            this.loz = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lkori = new System.Windows.Forms.PictureBox();
            this.lloz = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lloz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("log.BackgroundImage")));
            this.log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.log.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.log.FlatAppearance.BorderSize = 0;
            this.log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.log.Location = new System.Drawing.Point(177, 203);
            this.log.Margin = new System.Windows.Forms.Padding(0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(141, 54);
            this.log.TabIndex = 0;
            this.log.Text = "Uloguj se";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.button1_Click);
            // 
            // kori
            // 
            this.kori.Location = new System.Drawing.Point(177, 99);
            this.kori.Name = "kori";
            this.kori.Size = new System.Drawing.Size(141, 20);
            this.kori.TabIndex = 1;
            // 
            // loz
            // 
            this.loz.Location = new System.Drawing.Point(177, 149);
            this.loz.Name = "loz";
            this.loz.PasswordChar = '*';
            this.loz.Size = new System.Drawing.Size(141, 20);
            this.loz.TabIndex = 2;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(212, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(73, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // lkori
            // 
            this.lkori.Image = ((System.Drawing.Image)(resources.GetObject("lkori.Image")));
            this.lkori.Location = new System.Drawing.Point(115, 85);
            this.lkori.Name = "lkori";
            this.lkori.Size = new System.Drawing.Size(40, 40);
            this.lkori.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lkori.TabIndex = 6;
            this.lkori.TabStop = false;
            // 
            // lloz
            // 
            this.lloz.Image = ((System.Drawing.Image)(resources.GetObject("lloz.Image")));
            this.lloz.Location = new System.Drawing.Point(115, 140);
            this.lloz.Name = "lloz";
            this.lloz.Size = new System.Drawing.Size(40, 40);
            this.lloz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lloz.TabIndex = 7;
            this.lloz.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 253);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 315);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lloz);
            this.Controls.Add(this.lkori);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.loz);
            this.Controls.Add(this.kori);
            this.Controls.Add(this.log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijavite se";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lloz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log;
        private System.Windows.Forms.TextBox loz;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox lkori;
        private System.Windows.Forms.PictureBox lloz;
        public System.Windows.Forms.TextBox kori;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}