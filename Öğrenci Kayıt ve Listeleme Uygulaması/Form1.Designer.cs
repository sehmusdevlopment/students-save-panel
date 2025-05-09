namespace Öğrenci_Kayıt_ve_Listeleme_Uygulaması
{
    partial class öğrencikayıt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            btnKaydet = new Button();
            btnSil = new Button();
            lstOgrenciler = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 79);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 114);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 0;
            label2.Text = "Sooyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 152);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 0;
            label3.Text = "Numara :";
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.ButtonShadow;
            txtAd.Location = new Point(183, 79);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.ButtonShadow;
            txtSoyad.Location = new Point(183, 114);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtNumara
            // 
            txtNumara.BackColor = SystemColors.ButtonShadow;
            txtNumara.Location = new Point(183, 149);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(100, 23);
            txtNumara.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaption;
            btnKaydet.Location = new Point(195, 189);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 60);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Save";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.Location = new Point(301, 189);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 60);
            btnSil.TabIndex = 2;
            btnSil.Text = "Delete";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // lstOgrenciler
            // 
            lstOgrenciler.BackColor = SystemColors.ButtonFace;
            lstOgrenciler.FormattingEnabled = true;
            lstOgrenciler.Location = new Point(289, 79);
            lstOgrenciler.Name = "lstOgrenciler";
            lstOgrenciler.Size = new Size(120, 94);
            lstOgrenciler.TabIndex = 3;
            // 
            // öğrencikayıt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstOgrenciler);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(txtNumara);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "öğrencikayıt";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNumara;
        private Button btnKaydet;
        private Button btnSil;
        private ListBox lstOgrenciler;
    }
}
