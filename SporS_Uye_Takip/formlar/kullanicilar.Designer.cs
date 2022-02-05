namespace SporS_Uye_Takip.formlar
{
    partial class kullanicilar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_yenile = new System.Windows.Forms.Button();
            this.label_adet = new System.Windows.Forms.Label();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.label_ara = new System.Windows.Forms.Label();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.label_kullanıcı = new System.Windows.Forms.Label();
            this.veriListesi = new System.Windows.Forms.DataGridView();
            this.button_ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.veriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1264, 46);
            this.label1.TabIndex = 53;
            this.label1.Text = "Kullanıcılar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 645);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1264, 36);
            this.label2.TabIndex = 54;
            this.label2.Text = "2020 © Zeynel Şahin\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_yenile
            // 
            this.button_yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.button_yenile.FlatAppearance.BorderSize = 0;
            this.button_yenile.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_yenile.ForeColor = System.Drawing.Color.White;
            this.button_yenile.Location = new System.Drawing.Point(329, 116);
            this.button_yenile.Margin = new System.Windows.Forms.Padding(2);
            this.button_yenile.Name = "button_yenile";
            this.button_yenile.Size = new System.Drawing.Size(171, 37);
            this.button_yenile.TabIndex = 89;
            this.button_yenile.Text = "Yenile";
            this.button_yenile.UseVisualStyleBackColor = false;
            this.button_yenile.Click += new System.EventHandler(this.button_yenile_Click);
            // 
            // label_adet
            // 
            this.label_adet.AutoSize = true;
            this.label_adet.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adet.Location = new System.Drawing.Point(47, 595);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(65, 24);
            this.label_adet.TabIndex = 88;
            this.label_adet.Text = "Adet:";
            // 
            // button_guncelle
            // 
            this.button_guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.button_guncelle.FlatAppearance.BorderSize = 0;
            this.button_guncelle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle.ForeColor = System.Drawing.Color.White;
            this.button_guncelle.Location = new System.Drawing.Point(854, 116);
            this.button_guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(189, 37);
            this.button_guncelle.TabIndex = 87;
            this.button_guncelle.Text = "Kullanıcı Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.button_sil.FlatAppearance.BorderSize = 0;
            this.button_sil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.ForeColor = System.Drawing.Color.White;
            this.button_sil.Location = new System.Drawing.Point(679, 116);
            this.button_sil.Margin = new System.Windows.Forms.Padding(2);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(171, 37);
            this.button_sil.TabIndex = 86;
            this.button_sil.Text = "Kullanıcı Sil\r\n";
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // label_ara
            // 
            this.label_ara.AutoSize = true;
            this.label_ara.BackColor = System.Drawing.Color.Transparent;
            this.label_ara.Enabled = false;
            this.label_ara.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ara.ForeColor = System.Drawing.Color.Silver;
            this.label_ara.Location = new System.Drawing.Point(48, 91);
            this.label_ara.Name = "label_ara";
            this.label_ara.Size = new System.Drawing.Size(64, 22);
            this.label_ara.TabIndex = 85;
            this.label_ara.Text = "Ara....";
            // 
            // textBox_ara
            // 
            this.textBox_ara.BackColor = System.Drawing.Color.White;
            this.textBox_ara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ara.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.textBox_ara.Location = new System.Drawing.Point(51, 116);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(204, 31);
            this.textBox_ara.TabIndex = 84;
            this.textBox_ara.TextChanged += new System.EventHandler(this.textBox_ara_TextChanged);
            // 
            // label_kullanıcı
            // 
            this.label_kullanıcı.AutoSize = true;
            this.label_kullanıcı.Enabled = false;
            this.label_kullanıcı.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullanıcı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.label_kullanıcı.Location = new System.Drawing.Point(48, 150);
            this.label_kullanıcı.Name = "label_kullanıcı";
            this.label_kullanıcı.Size = new System.Drawing.Size(121, 24);
            this.label_kullanıcı.TabIndex = 83;
            this.label_kullanıcı.Text = "Kullanıcılar";
            // 
            // veriListesi
            // 
            this.veriListesi.AllowUserToAddRows = false;
            this.veriListesi.AllowUserToDeleteRows = false;
            this.veriListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.veriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.veriListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.veriListesi.BackgroundColor = System.Drawing.Color.White;
            this.veriListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.veriListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.veriListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.veriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.veriListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.veriListesi.Location = new System.Drawing.Point(51, 179);
            this.veriListesi.Margin = new System.Windows.Forms.Padding(2);
            this.veriListesi.MultiSelect = false;
            this.veriListesi.Name = "veriListesi";
            this.veriListesi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.veriListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.veriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.veriListesi.Size = new System.Drawing.Size(1167, 402);
            this.veriListesi.TabIndex = 82;
            this.veriListesi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.veriListesi_DataBindingComplete);
            this.veriListesi.DoubleClick += new System.EventHandler(this.veriListesi_DoubleClick);
            // 
            // button_ekle
            // 
            this.button_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.button_ekle.FlatAppearance.BorderSize = 0;
            this.button_ekle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekle.ForeColor = System.Drawing.Color.White;
            this.button_ekle.Location = new System.Drawing.Point(504, 116);
            this.button_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(171, 37);
            this.button_ekle.TabIndex = 81;
            this.button_ekle.Text = "Kullanıcı Ekle";
            this.button_ekle.UseVisualStyleBackColor = false;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button_yenile);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.label_ara);
            this.Controls.Add(this.textBox_ara);
            this.Controls.Add(this.label_kullanıcı);
            this.Controls.Add(this.veriListesi);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "kullanicilar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_yenile;
        private System.Windows.Forms.Label label_adet;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Label label_ara;
        private System.Windows.Forms.TextBox textBox_ara;
        private System.Windows.Forms.Label label_kullanıcı;
        private System.Windows.Forms.DataGridView veriListesi;
        private System.Windows.Forms.Button button_ekle;
    }
}