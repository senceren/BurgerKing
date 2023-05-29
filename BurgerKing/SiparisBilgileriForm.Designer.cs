namespace BurgerKing
{
    partial class SiparisBilgileriForm
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
            lstOnaylananlar = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstOnaylananlar
            // 
            lstOnaylananlar.FormattingEnabled = true;
            lstOnaylananlar.ItemHeight = 20;
            lstOnaylananlar.Location = new Point(24, 46);
            lstOnaylananlar.Name = "lstOnaylananlar";
            lstOnaylananlar.Size = new Size(492, 384);
            lstOnaylananlar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 1;
            label1.Text = "Sipariş Geçmişi";
            // 
            // SiparisBilgileriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 450);
            Controls.Add(label1);
            Controls.Add(lstOnaylananlar);
            Name = "SiparisBilgileriForm";
            Text = "SiparisBilgileriForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstOnaylananlar;
        private Label label1;
    }
}