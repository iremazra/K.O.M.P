namespace FinalProjesi
{
    partial class Depo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTedarikSuresi = new System.Windows.Forms.TextBox();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.textBoxOyunKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(223)))), ((int)(((byte)(170)))));
            this.groupBox1.Controls.Add(this.textBoxTedarikSuresi);
            this.groupBox1.Controls.Add(this.textBoxStok);
            this.groupBox1.Controls.Add(this.textBoxOyunKodu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyun Bilgileri";
            // 
            // textBoxTedarikSuresi
            // 
            this.textBoxTedarikSuresi.Location = new System.Drawing.Point(156, 168);
            this.textBoxTedarikSuresi.Name = "textBoxTedarikSuresi";
            this.textBoxTedarikSuresi.Size = new System.Drawing.Size(123, 22);
            this.textBoxTedarikSuresi.TabIndex = 5;
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(156, 109);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(123, 22);
            this.textBoxStok.TabIndex = 4;
            // 
            // textBoxOyunKodu
            // 
            this.textBoxOyunKodu.Location = new System.Drawing.Point(156, 52);
            this.textBoxOyunKodu.Name = "textBoxOyunKodu";
            this.textBoxOyunKodu.Size = new System.Drawing.Size(123, 22);
            this.textBoxOyunKodu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tedarik Süresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun Kodu:";
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.buttonEkle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEkle.Location = new System.Drawing.Point(525, 21);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(182, 52);
            this.buttonEkle.TabIndex = 1;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.buttonSil.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSil.Location = new System.Drawing.Point(525, 130);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(182, 52);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.buttonGuncelle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuncelle.Location = new System.Drawing.Point(525, 223);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(182, 52);
            this.buttonGuncelle.TabIndex = 3;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(144)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(857, 316);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Depo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(882, 666);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Depo";
            this.Text = "Depo";
            this.Load += new System.EventHandler(this.Depo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTedarikSuresi;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.TextBox textBoxOyunKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}