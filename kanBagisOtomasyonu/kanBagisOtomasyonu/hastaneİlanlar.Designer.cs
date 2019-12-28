namespace kanBagisOtomasyonu
{
    partial class hastaneİlanlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ilanKodu = new System.Windows.Forms.TextBox();
            this.ilanMetini = new System.Windows.Forms.TextBox();
            this.yoneticiKodu = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlan Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "İlan Metini";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yönetici Kodu";
            // 
            // ilanKodu
            // 
            this.ilanKodu.Location = new System.Drawing.Point(187, 49);
            this.ilanKodu.Name = "ilanKodu";
            this.ilanKodu.Size = new System.Drawing.Size(137, 22);
            this.ilanKodu.TabIndex = 1;
            this.ilanKodu.TextChanged += new System.EventHandler(this.ilanKodu_TextChanged);
            // 
            // ilanMetini
            // 
            this.ilanMetini.Location = new System.Drawing.Point(187, 114);
            this.ilanMetini.Name = "ilanMetini";
            this.ilanMetini.Size = new System.Drawing.Size(137, 22);
            this.ilanMetini.TabIndex = 2;
            // 
            // yoneticiKodu
            // 
            this.yoneticiKodu.Location = new System.Drawing.Point(188, 180);
            this.yoneticiKodu.Name = "yoneticiKodu";
            this.yoneticiKodu.Size = new System.Drawing.Size(137, 22);
            this.yoneticiKodu.TabIndex = 3;
            // 
            // ekle
            // 
            this.ekle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekle.Location = new System.Drawing.Point(500, 49);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(86, 38);
            this.ekle.TabIndex = 4;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // guncelle
            // 
            this.guncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelle.Location = new System.Drawing.Point(500, 164);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(98, 38);
            this.guncelle.TabIndex = 6;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.Location = new System.Drawing.Point(500, 104);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(86, 38);
            this.sil.TabIndex = 5;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(63, 253);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(639, 163);
            this.dgv.TabIndex = 4;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // hastaneİlanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.yoneticiKodu);
            this.Controls.Add(this.ilanMetini);
            this.Controls.Add(this.ilanKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "hastaneİlanlar";
            this.Text = "hastaneİlanlar";
            this.Load += new System.EventHandler(this.hastaneİlanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ilanKodu;
        private System.Windows.Forms.TextBox ilanMetini;
        private System.Windows.Forms.TextBox yoneticiKodu;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DataGridView dgv;
    }
}