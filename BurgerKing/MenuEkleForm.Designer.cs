namespace BurgerKing
{
    partial class MenuEkleForm
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
            btnMenuEkle = new Button();
            nudMenuFiyat = new NumericUpDown();
            label3 = new Label();
            txtMenuAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyat).BeginInit();
            SuspendLayout();
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.Location = new Point(169, 156);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(212, 46);
            btnMenuEkle.TabIndex = 23;
            btnMenuEkle.Text = "Menü Ekle";
            btnMenuEkle.UseVisualStyleBackColor = true;
            btnMenuEkle.Click += btnMenuEkle_Click;
            // 
            // nudMenuFiyat
            // 
            nudMenuFiyat.Location = new Point(169, 104);
            nudMenuFiyat.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudMenuFiyat.Name = "nudMenuFiyat";
            nudMenuFiyat.Size = new Size(204, 27);
            nudMenuFiyat.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 106);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 21;
            label3.Text = "Fiyat:";
            // 
            // txtMenuAd
            // 
            txtMenuAd.Location = new Point(163, 64);
            txtMenuAd.Name = "txtMenuAd";
            txtMenuAd.Size = new Size(210, 27);
            txtMenuAd.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 67);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 19;
            label2.Text = "Menü Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 18;
            label1.Text = "Menü Ekleme Bölümü";
            // 
            // MenuEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenuEkle);
            Controls.Add(nudMenuFiyat);
            Controls.Add(label3);
            Controls.Add(txtMenuAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuEkleForm";
            Text = "MenuEkleForm";
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenuEkle;
        private NumericUpDown nudMenuFiyat;
        private Label label3;
        private TextBox txtMenuAd;
        private Label label2;
        private Label label1;
    }
}