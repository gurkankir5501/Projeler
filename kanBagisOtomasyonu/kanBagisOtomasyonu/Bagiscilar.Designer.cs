namespace kanBagisOtomasyonu
{
    partial class Bagiscilarsayfasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tcKimlikNo = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.kanGrubu = new System.Windows.Forms.TextBox();
            this.adresi = new System.Windows.Forms.TextBox();
            this.telNo = new System.Windows.Forms.TextBox();
            this.bagisciEkle = new System.Windows.Forms.Button();
            this.bagisciSil = new System.Windows.Forms.Button();
            this.bagisciGuncelle = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bagisciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kanBagisOtomasyonDataSet = new kanBagisOtomasyonu.kanBagisOtomasyonDataSet();
            this.bagisciTableAdapter = new kanBagisOtomasyonu.kanBagisOtomasyonDataSetTableAdapters.bagisciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagisciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanBagisOtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(519, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kan Grubu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(550, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adresi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(448, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon Numarası";
            // 
            // tcKimlikNo
            // 
            this.tcKimlikNo.Location = new System.Drawing.Point(212, 69);
            this.tcKimlikNo.Name = "tcKimlikNo";
            this.tcKimlikNo.Size = new System.Drawing.Size(186, 22);
            this.tcKimlikNo.TabIndex = 1;
            this.tcKimlikNo.TextChanged += new System.EventHandler(this.tcKimlikNo_TextChanged);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(212, 112);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(186, 22);
            this.ad.TabIndex = 2;
            this.ad.TextChanged += new System.EventHandler(this.ad_TextChanged);
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(212, 162);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(186, 22);
            this.soyad.TabIndex = 3;
            this.soyad.TextChanged += new System.EventHandler(this.soyad_TextChanged);
            // 
            // kanGrubu
            // 
            this.kanGrubu.Location = new System.Drawing.Point(631, 69);
            this.kanGrubu.Name = "kanGrubu";
            this.kanGrubu.Size = new System.Drawing.Size(143, 22);
            this.kanGrubu.TabIndex = 4;
            this.kanGrubu.TextChanged += new System.EventHandler(this.kanGrubu_TextChanged);
            // 
            // adresi
            // 
            this.adresi.Location = new System.Drawing.Point(631, 162);
            this.adresi.Name = "adresi";
            this.adresi.Size = new System.Drawing.Size(411, 22);
            this.adresi.TabIndex = 6;
            this.adresi.TextChanged += new System.EventHandler(this.adresi_TextChanged);
            // 
            // telNo
            // 
            this.telNo.Location = new System.Drawing.Point(631, 112);
            this.telNo.Name = "telNo";
            this.telNo.Size = new System.Drawing.Size(186, 22);
            this.telNo.TabIndex = 5;
            this.telNo.TextChanged += new System.EventHandler(this.telNo_TextChanged);
            // 
            // bagisciEkle
            // 
            this.bagisciEkle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bagisciEkle.Location = new System.Drawing.Point(146, 220);
            this.bagisciEkle.Name = "bagisciEkle";
            this.bagisciEkle.Size = new System.Drawing.Size(110, 37);
            this.bagisciEkle.TabIndex = 7;
            this.bagisciEkle.Text = "Ekle";
            this.bagisciEkle.UseVisualStyleBackColor = true;
            this.bagisciEkle.Click += new System.EventHandler(this.bagisciEkle_Click);
            // 
            // bagisciSil
            // 
            this.bagisciSil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bagisciSil.Location = new System.Drawing.Point(357, 220);
            this.bagisciSil.Name = "bagisciSil";
            this.bagisciSil.Size = new System.Drawing.Size(110, 37);
            this.bagisciSil.TabIndex = 8;
            this.bagisciSil.Text = "Sil";
            this.bagisciSil.UseVisualStyleBackColor = true;
            this.bagisciSil.Click += new System.EventHandler(this.bagisciSil_Click);
            // 
            // bagisciGuncelle
            // 
            this.bagisciGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bagisciGuncelle.Location = new System.Drawing.Point(555, 220);
            this.bagisciGuncelle.Name = "bagisciGuncelle";
            this.bagisciGuncelle.Size = new System.Drawing.Size(110, 37);
            this.bagisciGuncelle.TabIndex = 9;
            this.bagisciGuncelle.Text = "Güncelle";
            this.bagisciGuncelle.UseVisualStyleBackColor = true;
            this.bagisciGuncelle.Click += new System.EventHandler(this.bagisciGuncelle_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(146, 304);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(764, 190);
            this.dgv.TabIndex = 10;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bagisciBindingSource
            // 
            this.bagisciBindingSource.DataMember = "bagisci";
            this.bagisciBindingSource.DataSource = this.kanBagisOtomasyonDataSet;
            // 
            // kanBagisOtomasyonDataSet
            // 
            this.kanBagisOtomasyonDataSet.DataSetName = "kanBagisOtomasyonDataSet";
            this.kanBagisOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagisciTableAdapter
            // 
            this.bagisciTableAdapter.ClearBeforeFill = true;
            // 
            // Bagiscilarsayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 532);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bagisciGuncelle);
            this.Controls.Add(this.bagisciSil);
            this.Controls.Add(this.bagisciEkle);
            this.Controls.Add(this.telNo);
            this.Controls.Add(this.adresi);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.kanGrubu);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.tcKimlikNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bagiscilarsayfasi";
            this.Text = "Bagiscilar";
            this.Load += new System.EventHandler(this.Bagiscilarsayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagisciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanBagisOtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tcKimlikNo;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox kanGrubu;
        private System.Windows.Forms.TextBox adresi;
        private System.Windows.Forms.TextBox telNo;
        private System.Windows.Forms.Button bagisciEkle;
        private System.Windows.Forms.Button bagisciSil;
        private System.Windows.Forms.Button bagisciGuncelle;
        private System.Windows.Forms.DataGridView dgv;
        private kanBagisOtomasyonDataSet kanBagisOtomasyonDataSet;
        private System.Windows.Forms.BindingSource bagisciBindingSource;
        private kanBagisOtomasyonDataSetTableAdapters.bagisciTableAdapter bagisciTableAdapter;
    }
}