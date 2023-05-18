namespace MyFirstFormAppProject
{
    partial class Form4
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
            this.Evet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Hayir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Evet
            // 
            this.Evet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Evet.BackColor = System.Drawing.Color.YellowGreen;
            this.Evet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Evet.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Evet.ForeColor = System.Drawing.Color.White;
            this.Evet.Location = new System.Drawing.Point(509, 151);
            this.Evet.Name = "Evet";
            this.Evet.Size = new System.Drawing.Size(181, 104);
            this.Evet.TabIndex = 0;
            this.Evet.Text = "Evet";
            this.Evet.UseVisualStyleBackColor = false;
            this.Evet.Click += new System.EventHandler(this.Evet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1173, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maaşınızdan memnun musunuz ? ";
            // 
            // Hayir
            // 
            this.Hayir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Hayir.BackColor = System.Drawing.Color.Brown;
            this.Hayir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hayir.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hayir.ForeColor = System.Drawing.Color.White;
            this.Hayir.Location = new System.Drawing.Point(826, 151);
            this.Hayir.Name = "Hayir";
            this.Hayir.Size = new System.Drawing.Size(181, 104);
            this.Hayir.TabIndex = 3;
            this.Hayir.Text = "Hayır";
            this.Hayir.UseVisualStyleBackColor = false;
            this.Hayir.MouseEnter += new System.EventHandler(this.Hayir_MouseEnter);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(728, 731);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çıkış";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1517, 771);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hayir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Evet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Evet;
        private Label label1;
        private Button Hayir;
        private Label label2;
    }
}