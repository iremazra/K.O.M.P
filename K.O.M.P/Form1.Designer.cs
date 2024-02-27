namespace FinalProjesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonTumOyunlar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSepeteEkle = new System.Windows.Forms.Button();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.buttonKayitOl = new System.Windows.Forms.Button();
            this.buttonSepetiGoruntule = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(117, 77);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(287, 22);
            this.textBoxAra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aramak istediğiniz oyunu lütfen aşağıya yazınız!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "*İncelemek istediğiniz oyunun üzerine çift tıklayınız!";
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(120, 193);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(139, 53);
            this.buttonAra.TabIndex = 3;
            this.buttonAra.Text = "ARA";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonTumOyunlar
            // 
            this.buttonTumOyunlar.Location = new System.Drawing.Point(284, 193);
            this.buttonTumOyunlar.Name = "buttonTumOyunlar";
            this.buttonTumOyunlar.Size = new System.Drawing.Size(139, 53);
            this.buttonTumOyunlar.TabIndex = 4;
            this.buttonTumOyunlar.Text = "TÜM OYUNLAR";
            this.buttonTumOyunlar.UseVisualStyleBackColor = true;
            this.buttonTumOyunlar.Click += new System.EventHandler(this.buttonTumOyunlar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(144)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(556, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(779, 688);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(170)))));
            this.groupBox1.Controls.Add(this.richTextBox6);
            this.groupBox1.Controls.Add(this.richTextBox5);
            this.groupBox1.Controls.Add(this.richTextBox4);
            this.groupBox1.Controls.Add(this.richTextBox3);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 315);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyun Bilgileri";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(336, 237);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(126, 38);
            this.richTextBox6.TabIndex = 11;
            this.richTextBox6.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(336, 134);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(126, 38);
            this.richTextBox5.TabIndex = 10;
            this.richTextBox5.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(336, 46);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(126, 38);
            this.richTextBox4.TabIndex = 9;
            this.richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(96, 237);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(126, 38);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(96, 134);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(126, 38);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(96, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(126, 38);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Yaş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Süre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kişi Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Oyun Adı:";
            // 
            // buttonSepeteEkle
            // 
            this.buttonSepeteEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.buttonSepeteEkle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSepeteEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSepeteEkle.Location = new System.Drawing.Point(171, 645);
            this.buttonSepeteEkle.Name = "buttonSepeteEkle";
            this.buttonSepeteEkle.Size = new System.Drawing.Size(167, 55);
            this.buttonSepeteEkle.TabIndex = 12;
            this.buttonSepeteEkle.Text = "SEPETE EKLE";
            this.buttonSepeteEkle.UseVisualStyleBackColor = false;
            this.buttonSepeteEkle.Click += new System.EventHandler(this.buttonSepeteEkle_Click);
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.buttonGirisYap.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGirisYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGirisYap.Location = new System.Drawing.Point(1389, 106);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(146, 61);
            this.buttonGirisYap.TabIndex = 7;
            this.buttonGirisYap.Text = "GİRİŞ YAP";
            this.buttonGirisYap.UseVisualStyleBackColor = false;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // buttonKayitOl
            // 
            this.buttonKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.buttonKayitOl.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKayitOl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKayitOl.Location = new System.Drawing.Point(1561, 106);
            this.buttonKayitOl.Name = "buttonKayitOl";
            this.buttonKayitOl.Size = new System.Drawing.Size(146, 61);
            this.buttonKayitOl.TabIndex = 8;
            this.buttonKayitOl.Text = "KAYIT OL";
            this.buttonKayitOl.UseVisualStyleBackColor = false;
            this.buttonKayitOl.Click += new System.EventHandler(this.buttonKayitOl_Click);
            // 
            // buttonSepetiGoruntule
            // 
            this.buttonSepetiGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.buttonSepetiGoruntule.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSepetiGoruntule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSepetiGoruntule.Location = new System.Drawing.Point(1389, 17);
            this.buttonSepetiGoruntule.Name = "buttonSepetiGoruntule";
            this.buttonSepetiGoruntule.Size = new System.Drawing.Size(318, 58);
            this.buttonSepetiGoruntule.TabIndex = 9;
            this.buttonSepetiGoruntule.Text = "SEPETİ GÖRÜNTÜLE";
            this.buttonSepetiGoruntule.UseVisualStyleBackColor = false;
            this.buttonSepetiGoruntule.Click += new System.EventHandler(this.buttonSepetiGoruntule_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.buttonCikis.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCikis.Location = new System.Drawing.Point(1389, 641);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(318, 59);
            this.buttonCikis.TabIndex = 10;
            this.buttonCikis.Text = "ÇIKIŞ YAP";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1924, 722);
            this.Controls.Add(this.buttonSepeteEkle);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonSepetiGoruntule);
            this.Controls.Add(this.buttonKayitOl);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTumOyunlar);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AnaSayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonTumOyunlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.Button buttonKayitOl;
        private System.Windows.Forms.Button buttonSepetiGoruntule;
        private System.Windows.Forms.Button buttonSepeteEkle;
        private System.Windows.Forms.Button buttonCikis;
    }
}

