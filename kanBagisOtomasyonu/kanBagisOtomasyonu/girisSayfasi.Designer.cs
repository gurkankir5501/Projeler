namespace kanBagisOtomasyonu
{
    partial class girisSayfasi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.parola = new System.Windows.Forms.TextBox();
            this.girisButonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bagisMerkeziYonetici = new System.Windows.Forms.RadioButton();
            this.hastaneYonetici = new System.Windows.Forms.RadioButton();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // parola
            // 
            this.parola.Location = new System.Drawing.Point(800, 293);
            this.parola.Name = "parola";
            this.parola.PasswordChar = '*';
            this.parola.Size = new System.Drawing.Size(163, 22);
            this.parola.TabIndex = 2;
            this.parola.TextChanged += new System.EventHandler(this.parola_TextChanged);
            // 
            // girisButonu
            // 
            this.girisButonu.Location = new System.Drawing.Point(796, 391);
            this.girisButonu.Name = "girisButonu";
            this.girisButonu.Size = new System.Drawing.Size(75, 38);
            this.girisButonu.TabIndex = 5;
            this.girisButonu.Text = "Giris";
            this.girisButonu.UseVisualStyleBackColor = true;
            this.girisButonu.Click += new System.EventHandler(this.girisButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(629, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(693, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(790, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yönetici Girişi";
            // 
            // bagisMerkeziYonetici
            // 
            this.bagisMerkeziYonetici.AutoSize = true;
            this.bagisMerkeziYonetici.BackColor = System.Drawing.Color.Transparent;
            this.bagisMerkeziYonetici.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bagisMerkeziYonetici.Location = new System.Drawing.Point(782, 321);
            this.bagisMerkeziYonetici.Name = "bagisMerkeziYonetici";
            this.bagisMerkeziYonetici.Size = new System.Drawing.Size(214, 28);
            this.bagisMerkeziYonetici.TabIndex = 3;
            this.bagisMerkeziYonetici.TabStop = true;
            this.bagisMerkeziYonetici.Text = "Bağış Merkezi Yönetici";
            this.bagisMerkeziYonetici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bagisMerkeziYonetici.UseVisualStyleBackColor = false;
            this.bagisMerkeziYonetici.CheckedChanged += new System.EventHandler(this.bagisMerkeziYonetici_CheckedChanged);
            // 
            // hastaneYonetici
            // 
            this.hastaneYonetici.AutoSize = true;
            this.hastaneYonetici.BackColor = System.Drawing.Color.Transparent;
            this.hastaneYonetici.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaneYonetici.Location = new System.Drawing.Point(782, 355);
            this.hastaneYonetici.Name = "hastaneYonetici";
            this.hastaneYonetici.Size = new System.Drawing.Size(167, 28);
            this.hastaneYonetici.TabIndex = 4;
            this.hastaneYonetici.TabStop = true;
            this.hastaneYonetici.Text = "Hastane Yönetici";
            this.hastaneYonetici.UseVisualStyleBackColor = false;
            this.hastaneYonetici.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(800, 252);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(163, 22);
            this.kullaniciAdi.TabIndex = 1;
            this.kullaniciAdi.TextChanged += new System.EventHandler(this.kullaniciAdi_TextChanged_1);
            // 
            // girisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::kanBagisOtomasyonu.Properties.Resources._14314725_untitled_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 486);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.hastaneYonetici);
            this.Controls.Add(this.bagisMerkeziYonetici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girisButonu);
            this.Controls.Add(this.parola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "girisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "girisSayfasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Button girisButonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton bagisMerkeziYonetici;
        private System.Windows.Forms.RadioButton hastaneYonetici;
        private System.Windows.Forms.TextBox kullaniciAdi;
    }
}

