namespace SporS_Uye_Takip.formlar
{
    partial class uyeGirisCikis
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
            this.veriListesi = new System.Windows.Forms.DataGridView();
            this.comboBox_aramatip = new System.Windows.Forms.ComboBox();
            this.label_ara = new System.Windows.Forms.Label();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.radioButton_cikis = new System.Windows.Forms.RadioButton();
            this.radioButton_giris = new System.Windows.Forms.RadioButton();
            this.radioButton_giriscikis = new System.Windows.Forms.RadioButton();
            this.label_adet = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_sırala = new System.Windows.Forms.ComboBox();
            this.label_sırala = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_sunum = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.veriListesi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_sunum.SuspendLayout();
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
            this.label1.TabIndex = 52;
            this.label1.Text = "Üye Giriş Çıkışları";
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
            this.label2.TabIndex = 53;
            this.label2.Text = "2020 © Zeynel Şahin\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.veriListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.veriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.veriListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.veriListesi.Location = new System.Drawing.Point(37, 5);
            this.veriListesi.Margin = new System.Windows.Forms.Padding(2);
            this.veriListesi.Name = "veriListesi";
            this.veriListesi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.veriListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.veriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.veriListesi.Size = new System.Drawing.Size(1184, 455);
            this.veriListesi.TabIndex = 54;
            this.veriListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.veriListesi_CellContentClick);
            this.veriListesi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.veriListesi_DataBindingComplete);
            // 
            // comboBox_aramatip
            // 
            this.comboBox_aramatip.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.comboBox_aramatip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.comboBox_aramatip.FormattingEnabled = true;
            this.comboBox_aramatip.Items.AddRange(new object[] {
            "Tümü Kayıtlar",
            "İsim Göre",
            "İd No Göre",
            "Soyisim Göre",
            "Kapı Ad Göre",
            "Tarih",
            "Saat"});
            this.comboBox_aramatip.Location = new System.Drawing.Point(37, 27);
            this.comboBox_aramatip.Name = "comboBox_aramatip";
            this.comboBox_aramatip.Size = new System.Drawing.Size(207, 30);
            this.comboBox_aramatip.TabIndex = 56;
            this.comboBox_aramatip.SelectedIndexChanged += new System.EventHandler(this.comboBox_aramatip_SelectedIndexChanged);
            // 
            // label_ara
            // 
            this.label_ara.AutoSize = true;
            this.label_ara.BackColor = System.Drawing.Color.Transparent;
            this.label_ara.Enabled = false;
            this.label_ara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ara.ForeColor = System.Drawing.Color.Silver;
            this.label_ara.Location = new System.Drawing.Point(33, 64);
            this.label_ara.Name = "label_ara";
            this.label_ara.Size = new System.Drawing.Size(55, 21);
            this.label_ara.TabIndex = 73;
            this.label_ara.Text = "Ara....";
            this.label_ara.Visible = false;
            // 
            // textBox_ara
            // 
            this.textBox_ara.BackColor = System.Drawing.Color.White;
            this.textBox_ara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ara.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.textBox_ara.Location = new System.Drawing.Point(37, 88);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(207, 31);
            this.textBox_ara.TabIndex = 58;
            this.textBox_ara.Visible = false;
            this.textBox_ara.TextChanged += new System.EventHandler(this.textBox_ara_TextChanged);
            // 
            // radioButton_cikis
            // 
            this.radioButton_cikis.AutoSize = true;
            this.radioButton_cikis.Location = new System.Drawing.Point(604, 94);
            this.radioButton_cikis.Name = "radioButton_cikis";
            this.radioButton_cikis.Size = new System.Drawing.Size(131, 25);
            this.radioButton_cikis.TabIndex = 76;
            this.radioButton_cikis.Text = "Yanlızca Çıkış";
            this.radioButton_cikis.UseVisualStyleBackColor = true;
            this.radioButton_cikis.CheckedChanged += new System.EventHandler(this.radioButton_cikis_CheckedChanged);
            // 
            // radioButton_giris
            // 
            this.radioButton_giris.AutoSize = true;
            this.radioButton_giris.Location = new System.Drawing.Point(469, 94);
            this.radioButton_giris.Name = "radioButton_giris";
            this.radioButton_giris.Size = new System.Drawing.Size(129, 25);
            this.radioButton_giris.TabIndex = 75;
            this.radioButton_giris.Text = "Yanlızca Giriş";
            this.radioButton_giris.UseVisualStyleBackColor = true;
            this.radioButton_giris.CheckedChanged += new System.EventHandler(this.radioButton_giris_CheckedChanged);
            // 
            // radioButton_giriscikis
            // 
            this.radioButton_giriscikis.AutoSize = true;
            this.radioButton_giriscikis.Checked = true;
            this.radioButton_giriscikis.Location = new System.Drawing.Point(343, 94);
            this.radioButton_giriscikis.Name = "radioButton_giriscikis";
            this.radioButton_giriscikis.Size = new System.Drawing.Size(120, 25);
            this.radioButton_giriscikis.TabIndex = 78;
            this.radioButton_giriscikis.TabStop = true;
            this.radioButton_giriscikis.Text = "Giriş ve Çıkış";
            this.radioButton_giriscikis.UseVisualStyleBackColor = true;
            this.radioButton_giriscikis.CheckedChanged += new System.EventHandler(this.radioButton_giriscikis_CheckedChanged);
            // 
            // label_adet
            // 
            this.label_adet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_adet.AutoSize = true;
            this.label_adet.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adet.Location = new System.Drawing.Point(49, 607);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(65, 24);
            this.label_adet.TabIndex = 78;
            this.label_adet.Text = "Adet:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox.Location = new System.Drawing.Point(37, 88);
            this.maskedTextBox.Mask = "00/00/0000";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(98, 31);
            this.maskedTextBox.TabIndex = 57;
            this.maskedTextBox.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox.Visible = false;
            this.maskedTextBox.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            this.maskedTextBox.Leave += new System.EventHandler(this.maskedTextBox_Leave);
            // 
            // comboBox_sırala
            // 
            this.comboBox_sırala.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_sırala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.comboBox_sırala.FormattingEnabled = true;
            this.comboBox_sırala.Items.AddRange(new object[] {
            "Büyükler",
            "Küçükler",
            "Eşitler"});
            this.comboBox_sırala.Location = new System.Drawing.Point(141, 88);
            this.comboBox_sırala.Name = "comboBox_sırala";
            this.comboBox_sırala.Size = new System.Drawing.Size(103, 30);
            this.comboBox_sırala.TabIndex = 79;
            this.comboBox_sırala.Visible = false;
            this.comboBox_sırala.SelectedIndexChanged += new System.EventHandler(this.comboBox_sırala_SelectedIndexChanged);
            // 
            // label_sırala
            // 
            this.label_sırala.AutoSize = true;
            this.label_sırala.BackColor = System.Drawing.Color.Transparent;
            this.label_sırala.Enabled = false;
            this.label_sırala.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sırala.ForeColor = System.Drawing.Color.Silver;
            this.label_sırala.Location = new System.Drawing.Point(124, 64);
            this.label_sırala.Name = "label_sırala";
            this.label_sırala.Size = new System.Drawing.Size(51, 21);
            this.label_sırala.TabIndex = 80;
            this.label_sırala.Text = "Sırala";
            this.label_sırala.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_aramatip);
            this.panel1.Controls.Add(this.label_sırala);
            this.panel1.Controls.Add(this.textBox_ara);
            this.panel1.Controls.Add(this.comboBox_sırala);
            this.panel1.Controls.Add(this.maskedTextBox);
            this.panel1.Controls.Add(this.label_ara);
            this.panel1.Controls.Add(this.radioButton_giriscikis);
            this.panel1.Controls.Add(this.radioButton_giris);
            this.panel1.Controls.Add(this.radioButton_cikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 128);
            this.panel1.TabIndex = 81;
            // 
            // panel_sunum
            // 
            this.panel_sunum.Controls.Add(this.veriListesi);
            this.panel_sunum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sunum.Location = new System.Drawing.Point(0, 174);
            this.panel_sunum.Name = "panel_sunum";
            this.panel_sunum.Size = new System.Drawing.Size(1264, 471);
            this.panel_sunum.TabIndex = 82;
            // 
            // uyeGirisCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_sunum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "uyeGirisCikis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.uyeGirisCikis_Load);
            this.Resize += new System.EventHandler(this.uyeGirisCikis_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.veriListesi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_sunum.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView veriListesi;
        private System.Windows.Forms.ComboBox comboBox_aramatip;
        private System.Windows.Forms.Label label_ara;
        private System.Windows.Forms.TextBox textBox_ara;
        private System.Windows.Forms.RadioButton radioButton_cikis;
        private System.Windows.Forms.RadioButton radioButton_giris;
        private System.Windows.Forms.RadioButton radioButton_giriscikis;
        private System.Windows.Forms.Label label_adet;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.ComboBox comboBox_sırala;
        private System.Windows.Forms.Label label_sırala;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_sunum;
    }
}