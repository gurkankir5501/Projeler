namespace kanBagisOtomasyonu
{
    partial class Bagislar
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
            this.bagisEkle = new System.Windows.Forms.Button();
            this.verilisTarihi = new System.Windows.Forms.TextBox();
            this.tcKimlikNo = new System.Windows.Forms.TextBox();
            this.subeNo = new System.Windows.Forms.TextBox();
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
            this.bagisciGuncelle.Location = new System.Drawing.Point(592, 191);
            this.bagisciGuncelle.Name = "bagisciGuncelle";
            this.bagisciGuncelle.Size = new System.Drawing.Size(110, 37);
            this.bagisciGuncelle.TabIndex = 6;
            this.bagisciGuncelle.Text = "Güncelle";
            this.bagisciGuncelle.UseVisualStyleBackColor = true;
            this.bagisciGuncelle.Click += new System.EventHandler(this.bagisciGuncelle_Click);
            // 
            // bagisciSil
            // 
            this.bagisciSil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bagisciSil.Location = new System.Drawing.Point(425, 191);
            this.bagisciSil.Name = "bagisciSil";
            this.bagisciSil.Size = new System.Drawing.Size(110, 37);
            this.bagisciSil.TabIndex = 5;
            this.bagisciSil.Text = "Sil";
            this.bagisciSil.UseVisualStyleBackColor = true;
            this.bagisciSil.Click += new System.EventHandler(this.bagisciSil_Click);
            // 
            // bagisEkle
            // 
            this.bagisEkle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bagisEkle.Location = new System.Drawing.Point(222, 191);
            this.bagisEkle.Name = "bagisEkle";
            this.bagisEkle.Size = new System.Drawing.Size(110, 37);
            this.bagisEkle.TabIndex = 4;
            this.bagisEkle.Text = "Ekle";
            this.bagisEkle.UseVisualStyleBackColor = true;
            this.bagisEkle.Click += new System.EventHandler(this.bagisciEkle_Click);
            // 
            // verilisTarihi
            // 
            this.verilisTarihi.Location = new System.Drawing.Point(360, 124);
            this.verilisTarihi.Name = "verilisTarihi";
            this.verilisTarihi.Size = new System.Drawing.Size(186, 22);
            this.verilisTarihi.TabIndex = 3;
            // 
            // tcKimlikNo
            // 
            this.tcKimlikNo.Location = new System.Drawing.Point(360, 74);
            this.tcKimlikNo.Name = "tcKimlikNo";
            this.tcKimlikNo.Size = new System.Drawing.Size(186, 22);
            this.tcKimlikNo.TabIndex = 2;
            // 
            // subeNo
            // 
            this.subeNo.Location = new System.Drawing.Point(360, 31);
            this.subeNo.Name = "subeNo";
            this.subeNo.Size = new System.Drawing.Size(186, 22);
            this.subeNo.TabIndex = 1;
            this.subeNo.TextChanged += new System.EventHandler(this.subeNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(217, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Veriliş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(217, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tc Kimlik No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(255, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sube No";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(222, 247);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(480, 173);
            this.dgv.TabIndex = 7;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Bagislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 474);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bagisciGuncelle);
            this.Controls.Add(this.bagisciSil);
            this.Controls.Add(this.bagisEkle);
            this.Controls.Add(this.verilisTarihi);
            this.Controls.Add(this.tcKimlikNo);
            this.Controls.Add(this.subeNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bagislar";
            this.Text = "Bagislar";
            this.Load += new System.EventHandler(this.Bagislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bagisciGuncelle;
        private System.Windows.Forms.Button bagisciSil;
        private System.Windows.Forms.Button bagisEkle;
        private System.Windows.Forms.TextBox verilisTarihi;
        private System.Windows.Forms.TextBox tcKimlikNo;
        private System.Windows.Forms.TextBox subeNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
    }
}