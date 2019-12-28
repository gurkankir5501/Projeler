namespace kanBagisOtomasyonu
{
    partial class KanDeposu
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
            this.kanDeposuId = new System.Windows.Forms.TextBox();
            this.kanGrubu = new System.Windows.Forms.TextBox();
            this.verilisTarihi = new System.Windows.Forms.TextBox();
            this.miktar = new System.Windows.Forms.TextBox();
            this.subeKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.guncellee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // kanDeposuId
            // 
            this.kanDeposuId.Location = new System.Drawing.Point(244, 66);
            this.kanDeposuId.Name = "kanDeposuId";
            this.kanDeposuId.Size = new System.Drawing.Size(147, 22);
            this.kanDeposuId.TabIndex = 0;
            // 
            // kanGrubu
            // 
            this.kanGrubu.Location = new System.Drawing.Point(244, 121);
            this.kanGrubu.Name = "kanGrubu";
            this.kanGrubu.Size = new System.Drawing.Size(147, 22);
            this.kanGrubu.TabIndex = 1;
            // 
            // verilisTarihi
            // 
            this.verilisTarihi.Location = new System.Drawing.Point(244, 177);
            this.verilisTarihi.Name = "verilisTarihi";
            this.verilisTarihi.Size = new System.Drawing.Size(147, 22);
            this.verilisTarihi.TabIndex = 2;
            // 
            // miktar
            // 
            this.miktar.Location = new System.Drawing.Point(692, 70);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(147, 22);
            this.miktar.TabIndex = 3;
            // 
            // subeKodu
            // 
            this.subeKodu.Location = new System.Drawing.Point(692, 125);
            this.subeKodu.Name = "subeKodu";
            this.subeKodu.Size = new System.Drawing.Size(147, 22);
            this.subeKodu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kan Deposu Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kan Grubu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Veriliş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Miktar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(555, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şube Kodu";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(97, 291);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(742, 184);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // ekle
            // 
            this.ekle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.Location = new System.Drawing.Point(148, 228);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(94, 39);
            this.ekle.TabIndex = 5;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(350, 228);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(94, 39);
            this.sil.TabIndex = 5;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncellee
            // 
            this.guncellee.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellee.Location = new System.Drawing.Point(549, 228);
            this.guncellee.Name = "guncellee";
            this.guncellee.Size = new System.Drawing.Size(116, 39);
            this.guncellee.TabIndex = 5;
            this.guncellee.Text = "Güncelle";
            this.guncellee.UseVisualStyleBackColor = true;
            this.guncellee.Click += new System.EventHandler(this.guncellee_Click);
            // 
            // KanDeposu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 497);
            this.Controls.Add(this.guncellee);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subeKodu);
            this.Controls.Add(this.verilisTarihi);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.kanGrubu);
            this.Controls.Add(this.kanDeposuId);
            this.Name = "KanDeposu";
            this.Text = "KanDeposu";
            this.Load += new System.EventHandler(this.KanDeposu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kanDeposuId;
        private System.Windows.Forms.TextBox kanGrubu;
        private System.Windows.Forms.TextBox verilisTarihi;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.TextBox subeKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncellee;
    }
}