namespace WebServiceGiris
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTCKN = new System.Windows.Forms.MaskedTextBox();
            this.txtAd = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.MaskedTextBox();
            this.txtDogumYili = new System.Windows.Forms.MaskedTextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(177, 22);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(75, 23);
            this.btnUrunler.TabIndex = 1;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(74, 63);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.Size = new System.Drawing.Size(584, 142);
            this.dgvListe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Yılı";
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(839, 60);
            this.txtTCKN.Mask = "00000000000";
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(100, 20);
            this.txtTCKN.TabIndex = 7;
            this.txtTCKN.ValidatingType = typeof(int);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(839, 88);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(839, 123);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 9;
            // 
            // txtDogumYili
            // 
            this.txtDogumYili.Location = new System.Drawing.Point(839, 155);
            this.txtDogumYili.Mask = "0000";
            this.txtDogumYili.Name = "txtDogumYili";
            this.txtDogumYili.Size = new System.Drawing.Size(100, 20);
            this.txtDogumYili.TabIndex = 10;
            this.txtDogumYili.ValidatingType = typeof(int);
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(839, 204);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(75, 23);
            this.btnDogrula.TabIndex = 11;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 258);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.txtDogumYili);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTCKN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTCKN;
        private System.Windows.Forms.MaskedTextBox txtAd;
        private System.Windows.Forms.MaskedTextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox txtDogumYili;
        private System.Windows.Forms.Button btnDogrula;
    }
}

