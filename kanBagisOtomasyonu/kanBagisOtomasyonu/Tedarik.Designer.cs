namespace kanBagisOtomasyonu
{
    partial class Tedarik
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
            this.Guncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.miktar = new System.Windows.Forms.TextBox();
            this.alinmaTarihi = new System.Windows.Forms.TextBox();
            this.kanGrubu = new System.Windows.Forms.TextBox();
            this.hastaneKodu = new System.Windows.Forms.TextBox();
            this.subeKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Guncelle
            // 
            this.Guncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncelle.Location = new System.Drawing.Point(568, 212);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(110, 37);
            this.Guncelle.TabIndex = 8;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Sil
            // 
            this.Sil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil.Location = new System.Drawing.Point(370, 212);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(110, 37);
            this.Sil.TabIndex = 7;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Ekle
            // 
            this.Ekle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle.Location = new System.Drawing.Point(159, 212);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(110, 37);
            this.Ekle.TabIndex = 6;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // miktar
            // 
            this.miktar.Location = new System.Drawing.Point(644, 104);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(186, 22);
            this.miktar.TabIndex = 5;
            this.miktar.TextChanged += new System.EventHandler(this.miktar_TextChanged);
            // 
            // alinmaTarihi
            // 
            this.alinmaTarihi.Location = new System.Drawing.Point(225, 154);
            this.alinmaTarihi.Name = "alinmaTarihi";
            this.alinmaTarihi.Size = new System.Drawing.Size(186, 22);
            this.alinmaTarihi.TabIndex = 3;
            // 
            // kanGrubu
            // 
            this.kanGrubu.Location = new System.Drawing.Point(644, 61);
            this.kanGrubu.Name = "kanGrubu";
            this.kanGrubu.Size = new System.Drawing.Size(143, 22);
            this.kanGrubu.TabIndex = 4;
            // 
            // hastaneKodu
            // 
            this.hastaneKodu.Location = new System.Drawing.Point(225, 104);
            this.hastaneKodu.Name = "hastaneKodu";
            this.hastaneKodu.Size = new System.Drawing.Size(186, 22);
            this.hastaneKodu.TabIndex = 2;
            // 
            // subeKodu
            // 
            this.subeKodu.Location = new System.Drawing.Point(225, 61);
            this.subeKodu.Name = "subeKodu";
            this.subeKodu.Size = new System.Drawing.Size(186, 22);
            this.subeKodu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(71, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alınma Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(563, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(532, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kan Grubu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hastane Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 55);
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
            this.dgv.Location = new System.Drawing.Point(124, 277);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(703, 184);
            this.dgv.TabIndex = 9;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Tedarik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 484);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.alinmaTarihi);
            this.Controls.Add(this.kanGrubu);
            this.Controls.Add(this.hastaneKodu);
            this.Controls.Add(this.subeKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tedarik";
            this.Text = "Tedarik";
            this.Load += new System.EventHandler(this.Tedarik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.TextBox alinmaTarihi;
        private System.Windows.Forms.TextBox kanGrubu;
        private System.Windows.Forms.TextBox hastaneKodu;
        private System.Windows.Forms.TextBox subeKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
    }
}