namespace MyFirstFormAppProject
{
    partial class Form2
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
            this.MevcutCombo = new System.Windows.Forms.ComboBox();
            this.Deger = new System.Windows.Forms.TextBox();
            this.DonusturulecekCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MevcutCombo
            // 
            this.MevcutCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MevcutCombo.FormattingEnabled = true;
            this.MevcutCombo.Location = new System.Drawing.Point(22, 74);
            this.MevcutCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MevcutCombo.Name = "MevcutCombo";
            this.MevcutCombo.Size = new System.Drawing.Size(133, 23);
            this.MevcutCombo.TabIndex = 0;
            this.MevcutCombo.SelectedIndexChanged += new System.EventHandler(this.MevcutCombo_SelectedIndexChanged);
            // 
            // Deger
            // 
            this.Deger.Location = new System.Drawing.Point(22, 28);
            this.Deger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deger.Name = "Deger";
            this.Deger.Size = new System.Drawing.Size(133, 23);
            this.Deger.TabIndex = 2;
            this.Deger.Text = "0";
            this.Deger.TextChanged += new System.EventHandler(this.Deger_TextChanged);
            // 
            // DonusturulecekCombo
            // 
            this.DonusturulecekCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DonusturulecekCombo.FormattingEnabled = true;
            this.DonusturulecekCombo.Location = new System.Drawing.Point(22, 122);
            this.DonusturulecekCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DonusturulecekCombo.Name = "DonusturulecekCombo";
            this.DonusturulecekCombo.Size = new System.Drawing.Size(133, 23);
            this.DonusturulecekCombo.TabIndex = 3;
            this.DonusturulecekCombo.SelectedIndexChanged += new System.EventHandler(this.DonusturulecekCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Değer Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mevcut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dönüştürülecek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sonuç";
            // 
            // Sonuc
            // 
            this.Sonuc.Enabled = false;
            this.Sonuc.Location = new System.Drawing.Point(23, 175);
            this.Sonuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(133, 23);
            this.Sonuc.TabIndex = 1;
            this.Sonuc.TextChanged += new System.EventHandler(this.Sonuc_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 213);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DonusturulecekCombo);
            this.Controls.Add(this.Deger);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.MevcutCombo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox MevcutCombo;
        private TextBox Deger;
        private ComboBox DonusturulecekCombo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Sonuc;
    }
}