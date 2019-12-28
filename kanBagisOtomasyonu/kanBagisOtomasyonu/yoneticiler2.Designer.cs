namespace kanBagisOtomasyonu
{
    partial class yoneticiler2
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.yoneticiGuncelle = new System.Windows.Forms.Button();
            this.yoneticiSil = new System.Windows.Forms.Button();
            this.yoneticiEkle = new System.Windows.Forms.Button();
            this.soyad = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.yoneticiKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(137, 288);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(723, 178);
            this.dgv.TabIndex = 19;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // yoneticiGuncelle
            // 
            this.yoneticiGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiGuncelle.Location = new System.Drawing.Point(581, 206);
            this.yoneticiGuncelle.Name = "yoneticiGuncelle";
            this.yoneticiGuncelle.Size = new System.Drawing.Size(110, 37);
            this.yoneticiGuncelle.TabIndex = 18;
            this.yoneticiGuncelle.Text = "Güncelle";
            this.yoneticiGuncelle.UseVisualStyleBackColor = true;
            this.yoneticiGuncelle.Click += new System.EventHandler(this.yoneticiGuncelle_Click);
            // 
            // yoneticiSil
            // 
            this.yoneticiSil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiSil.Location = new System.Drawing.Point(383, 206);
            this.yoneticiSil.Name = "yoneticiSil";
            this.yoneticiSil.Size = new System.Drawing.Size(110, 37);
            this.yoneticiSil.TabIndex = 16;
            this.yoneticiSil.Text = "Sil";
            this.yoneticiSil.UseVisualStyleBackColor = true;
            this.yoneticiSil.Click += new System.EventHandler(this.yoneticiSil_Click);
            // 
            // yoneticiEkle
            // 
            this.yoneticiEkle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiEkle.Location = new System.Drawing.Point(172, 206);
            this.yoneticiEkle.Name = "yoneticiEkle";
            this.yoneticiEkle.Size = new System.Drawing.Size(110, 37);
            this.yoneticiEkle.TabIndex = 15;
            this.yoneticiEkle.Text = "Ekle";
            this.yoneticiEkle.UseVisualStyleBackColor = true;
            this.yoneticiEkle.Click += new System.EventHandler(this.yoneticiEkle_Click);
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(238, 148);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(186, 22);
            this.soyad.TabIndex = 13;
            // 
            // parola
            // 
            this.parola.Location = new System.Drawing.Point(657, 55);
            this.parola.Name = "parola";
            this.parola.PasswordChar = '*';
            this.parola.Size = new System.Drawing.Size(143, 22);
            this.parola.TabIndex = 14;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(238, 98);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(186, 22);
            this.ad.TabIndex = 12;
            // 
            // yoneticiKodu
            // 
            this.yoneticiKodu.Location = new System.Drawing.Point(238, 55);
            this.yoneticiKodu.Name = "yoneticiKodu";
            this.yoneticiKodu.Size = new System.Drawing.Size(186, 22);
            this.yoneticiKodu.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(136, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(556, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Parola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(167, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Yönetici Kodu";
            // 
            // yoneticiler2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 514);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.yoneticiGuncelle);
            this.Controls.Add(this.yoneticiSil);
            this.Controls.Add(this.yoneticiEkle);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.yoneticiKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yoneticiler2";
            this.Text = "yoneticiler2";
            this.Load += new System.EventHandler(this.yoneticiler2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button yoneticiGuncelle;
        private System.Windows.Forms.Button yoneticiSil;
        private System.Windows.Forms.Button yoneticiEkle;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox yoneticiKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}