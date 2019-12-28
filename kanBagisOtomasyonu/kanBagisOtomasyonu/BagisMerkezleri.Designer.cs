namespace kanBagisOtomasyonu
{
    partial class BagisMerkezleri
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
            this.bagisciGuncelle = new System.Windows.Forms.Button();
            this.bagisciSil = new System.Windows.Forms.Button();
            this.bagisciEkle = new System.Windows.Forms.Button();
            this.adresi = new System.Windows.Forms.TextBox();
            this.acilisTarihi = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.subeKodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bagisciGuncelle
            // 
            this.bagisciGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bagisciGuncelle.Location = new System.Drawing.Point(553, 211);
            this.bagisciGuncelle.Name = "bagisciGuncelle";
            this.bagisciGuncelle.Size = new System.Drawing.Size(110, 37);
            this.bagisciGuncelle.TabIndex = 7;
            this.bagisciGuncelle.Text = "Güncelle";
            this.bagisciGuncelle.UseVisualStyleBackColor = true;
            this.bagisciGuncelle.Click += new System.EventHandler(this.bagisciGuncelle_Click);
            // 
            // bagisciSil
            // 
            this.bagisciSil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bagisciSil.Location = new System.Drawing.Point(355, 211);
            this.bagisciSil.Name = "bagisciSil";
            this.bagisciSil.Size = new System.Drawing.Size(110, 37);
            this.bagisciSil.TabIndex = 6;
            this.bagisciSil.Text = "Sil";
            this.bagisciSil.UseVisualStyleBackColor = true;
            this.bagisciSil.Click += new System.EventHandler(this.bagisciSil_Click);
            // 
            // bagisciEkle
            // 
            this.bagisciEkle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bagisciEkle.Location = new System.Drawing.Point(144, 211);
            this.bagisciEkle.Name = "bagisciEkle";
            this.bagisciEkle.Size = new System.Drawing.Size(110, 37);
            this.bagisciEkle.TabIndex = 5;
            this.bagisciEkle.Text = "Ekle";
            this.bagisciEkle.UseVisualStyleBackColor = true;
            this.bagisciEkle.Click += new System.EventHandler(this.bagisciEkle_Click);
            // 
            // adresi
            // 
            this.adresi.Location = new System.Drawing.Point(599, 60);
            this.adresi.Multiline = true;
            this.adresi.Name = "adresi";
            this.adresi.Size = new System.Drawing.Size(411, 76);
            this.adresi.TabIndex = 4;
            this.adresi.TextChanged += new System.EventHandler(this.adresi_TextChanged);
            // 
            // acilisTarihi
            // 
            this.acilisTarihi.Location = new System.Drawing.Point(210, 153);
            this.acilisTarihi.Name = "acilisTarihi";
            this.acilisTarihi.Size = new System.Drawing.Size(186, 22);
            this.acilisTarihi.TabIndex = 3;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(210, 103);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(186, 22);
            this.ad.TabIndex = 2;
            // 
            // subeKodu
            // 
            this.subeKodu.Location = new System.Drawing.Point(210, 60);
            this.subeKodu.Name = "subeKodu";
            this.subeKodu.Size = new System.Drawing.Size(186, 22);
            this.subeKodu.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(518, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Açılış Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(156, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Şube Kodu";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(135, 272);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(750, 174);
            this.dgv.TabIndex = 8;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BagisMerkezleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 471);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bagisciGuncelle);
            this.Controls.Add(this.bagisciSil);
            this.Controls.Add(this.bagisciEkle);
            this.Controls.Add(this.adresi);
            this.Controls.Add(this.acilisTarihi);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.subeKodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BagisMerkezleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BagisMerkezleri";
            this.Load += new System.EventHandler(this.BagisMerkezleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bagisciGuncelle;
        private System.Windows.Forms.Button bagisciSil;
        private System.Windows.Forms.Button bagisciEkle;
        private System.Windows.Forms.TextBox adresi;
        private System.Windows.Forms.TextBox acilisTarihi;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox subeKodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
    }
}