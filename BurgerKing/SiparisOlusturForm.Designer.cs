namespace BurgerKing
{
    partial class SiparisOlusturForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlusturForm));
            label1 = new Label();
            cmbMenu = new ComboBox();
            rdbKucuk = new RadioButton();
            label3 = new Label();
            rdbOrta = new RadioButton();
            rdbBuyuk = new RadioButton();
            label4 = new Label();
            nudAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            lstSiparisOzet = new ListBox();
            label5 = new Label();
            lblToplamTutar = new Label();
            label7 = new Label();
            btnSiparisTamamla = new Button();
            pictureBox1 = new PictureBox();
            grbEkstraMalzemeler = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 155);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Menü Seçiniz:";
            // 
            // cmbMenu
            // 
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new Point(20, 178);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new Size(217, 28);
            cmbMenu.TabIndex = 1;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Location = new Point(20, 242);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(69, 24);
            rdbKucuk.TabIndex = 4;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 219);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Boyut:";
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Location = new Point(95, 242);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(59, 24);
            rdbOrta.TabIndex = 6;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Location = new Point(168, 242);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(69, 24);
            rdbBuyuk.TabIndex = 7;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 274);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 8;
            label4.Text = "Adet";
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(20, 297);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(217, 27);
            nudAdet.TabIndex = 9;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(11, 388);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(259, 29);
            btnSiparisEkle.TabIndex = 10;
            btnSiparisEkle.Text = "Sipariş Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // lstSiparisOzet
            // 
            lstSiparisOzet.FormattingEnabled = true;
            lstSiparisOzet.ItemHeight = 20;
            lstSiparisOzet.Location = new Point(606, 53);
            lstSiparisOzet.Name = "lstSiparisOzet";
            lstSiparisOzet.Size = new Size(525, 284);
            lstSiparisOzet.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(978, 357);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 12;
            label5.Text = "Toplam Tutar:";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(1081, 357);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(21, 20);
            lblToplamTutar.TabIndex = 13;
            lblToplamTutar.Text = " 0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(606, 20);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 14;
            label7.Text = "Sipariş Özeti";
            // 
            // btnSiparisTamamla
            // 
            btnSiparisTamamla.Location = new Point(606, 388);
            btnSiparisTamamla.Name = "btnSiparisTamamla";
            btnSiparisTamamla.Size = new Size(525, 29);
            btnSiparisTamamla.TabIndex = 15;
            btnSiparisTamamla.Text = "Sipariş Tamamla";
            btnSiparisTamamla.UseVisualStyleBackColor = true;
            btnSiparisTamamla.Click += btnSiparisTamamla_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // grbEkstraMalzemeler
            // 
            grbEkstraMalzemeler.Location = new Point(291, 155);
            grbEkstraMalzemeler.Name = "grbEkstraMalzemeler";
            grbEkstraMalzemeler.Size = new Size(250, 253);
            grbEkstraMalzemeler.TabIndex = 17;
            grbEkstraMalzemeler.TabStop = false;
            grbEkstraMalzemeler.Text = "Ekstra Malzemeler";
            // 
            // SiparisOlusturForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 446);
            Controls.Add(grbEkstraMalzemeler);
            Controls.Add(pictureBox1);
            Controls.Add(btnSiparisTamamla);
            Controls.Add(label7);
            Controls.Add(lblToplamTutar);
            Controls.Add(label5);
            Controls.Add(lstSiparisOzet);
            Controls.Add(btnSiparisEkle);
            Controls.Add(nudAdet);
            Controls.Add(label4);
            Controls.Add(rdbBuyuk);
            Controls.Add(rdbOrta);
            Controls.Add(label3);
            Controls.Add(rdbKucuk);
            Controls.Add(cmbMenu);
            Controls.Add(label1);
            Name = "SiparisOlusturForm";
            Text = "SiparisOlusturForm";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMenu;
        private RadioButton rdbKucuk;
        private Label label3;
        private RadioButton rdbOrta;
        private RadioButton rdbBuyuk;
        private Label label4;
        private NumericUpDown nudAdet;
        private Button btnSiparisEkle;
        private ListBox lstSiparisOzet;
        private Label label5;
        private Label lblToplamTutar;
        private Label label7;
        private Button btnSiparisTamamla;
        private PictureBox pictureBox1;
        private GroupBox grbEkstraMalzemeler;
    }
}