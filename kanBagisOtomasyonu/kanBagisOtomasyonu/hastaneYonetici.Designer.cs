namespace kanBagisOtomasyonu
{
    partial class hastaneYonetici
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
            this.hasta = new System.Windows.Forms.Button();
            this.hastane = new System.Windows.Forms.Button();
            this.yonetici = new System.Windows.Forms.Button();
            this.ilan = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hasta
            // 
            this.hasta.BackColor = System.Drawing.Color.Transparent;
            this.hasta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta.Location = new System.Drawing.Point(46, 36);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(158, 53);
            this.hasta.TabIndex = 3;
            this.hasta.Text = "Hastalar";
            this.hasta.UseVisualStyleBackColor = false;
            this.hasta.Click += new System.EventHandler(this.hasta_Click);
            // 
            // hastane
            // 
            this.hastane.BackColor = System.Drawing.Color.Transparent;
            this.hastane.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastane.Location = new System.Drawing.Point(46, 125);
            this.hastane.Name = "hastane";
            this.hastane.Size = new System.Drawing.Size(158, 53);
            this.hastane.TabIndex = 3;
            this.hastane.Text = "Hastaneler";
            this.hastane.UseVisualStyleBackColor = false;
            this.hastane.Click += new System.EventHandler(this.hastane_Click);
            // 
            // yonetici
            // 
            this.yonetici.BackColor = System.Drawing.Color.Transparent;
            this.yonetici.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetici.Location = new System.Drawing.Point(46, 221);
            this.yonetici.Name = "yonetici";
            this.yonetici.Size = new System.Drawing.Size(158, 53);
            this.yonetici.TabIndex = 3;
            this.yonetici.Text = "Yöneticiler";
            this.yonetici.UseVisualStyleBackColor = false;
            this.yonetici.Click += new System.EventHandler(this.yonetici_Click);
            // 
            // ilan
            // 
            this.ilan.BackColor = System.Drawing.Color.Transparent;
            this.ilan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilan.Location = new System.Drawing.Point(46, 319);
            this.ilan.Name = "ilan";
            this.ilan.Size = new System.Drawing.Size(158, 53);
            this.ilan.TabIndex = 3;
            this.ilan.Text = "İlanlar";
            this.ilan.UseVisualStyleBackColor = false;
            this.ilan.Click += new System.EventHandler(this.ilan_Click);
            // 
            // giris
            // 
            this.giris.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(909, 410);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(113, 35);
            this.giris.TabIndex = 4;
            this.giris.Text = "Çıkış";
            this.giris.UseVisualStyleBackColor = true;
            // 
            // hastaneYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::kanBagisOtomasyonu.Properties.Resources.bagis_sayfasi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 494);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.yonetici);
            this.Controls.Add(this.ilan);
            this.Controls.Add(this.hastane);
            this.Controls.Add(this.hasta);
            this.Name = "hastaneYonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hastaneYonetici";
            this.Load += new System.EventHandler(this.hastaneYonetici_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hasta;
        private System.Windows.Forms.Button hastane;
        private System.Windows.Forms.Button yonetici;
        private System.Windows.Forms.Button ilan;
        private System.Windows.Forms.Button giris;
    }
}