namespace BurgerKing
{
    partial class EkstraMalzemeEkleForm
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
            btnEkstraEkle = new Button();
            nudEkstraFiyat = new NumericUpDown();
            label3 = new Label();
            txtEkstraAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudEkstraFiyat).BeginInit();
            SuspendLayout();
            // 
            // btnEkstraEkle
            // 
            btnEkstraEkle.Location = new Point(169, 160);
            btnEkstraEkle.Name = "btnEkstraEkle";
            btnEkstraEkle.Size = new Size(212, 46);
            btnEkstraEkle.TabIndex = 11;
            btnEkstraEkle.Text = "Ekstra Malzeme Ekle";
            btnEkstraEkle.UseVisualStyleBackColor = true;
            btnEkstraEkle.Click += btnEkstraEkle_Click;
            // 
            // nudEkstraFiyat
            // 
            nudEkstraFiyat.Location = new Point(169, 108);
            nudEkstraFiyat.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudEkstraFiyat.Name = "nudEkstraFiyat";
            nudEkstraFiyat.Size = new Size(204, 27);
            nudEkstraFiyat.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 110);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 9;
            label3.Text = "Fiyat:";
            // 
            // txtEkstraAd
            // 
            txtEkstraAd.Location = new Point(163, 68);
            txtEkstraAd.Name = "txtEkstraAd";
            txtEkstraAd.Size = new Size(210, 27);
            txtEkstraAd.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 71);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 7;
            label2.Text = "Ekstra Malzeme Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(220, 20);
            label1.TabIndex = 6;
            label1.Text = "Ekstra Malzeme Ekleme Bölümü";
            // 
            // EkstraMalzemeEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEkstraEkle);
            Controls.Add(nudEkstraFiyat);
            Controls.Add(label3);
            Controls.Add(txtEkstraAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EkstraMalzemeEkleForm";
            Text = "EkstraMalzemeEkleForm";
            ((System.ComponentModel.ISupportInitialize)nudEkstraFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkstraEkle;
        private NumericUpDown nudEkstraFiyat;
        private Label label3;
        private TextBox txtEkstraAd;
        private Label label2;
        private Label label1;
    }
}