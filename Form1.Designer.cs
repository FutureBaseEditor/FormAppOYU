namespace MyFirstFormAppProject
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InvalidText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Orange;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(88, 258);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(187, 34);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Giriş Yap";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(88, 137);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(187, 27);
            this.Username.TabIndex = 10;
            this.Username.Text = " ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(88, 197);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(187, 27);
            this.Password.TabIndex = 11;
            this.Password.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifre:";
            // 
            // InvalidText
            // 
            this.InvalidText.AutoSize = true;
            this.InvalidText.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidText.Location = new System.Drawing.Point(58, 311);
            this.InvalidText.Name = "InvalidText";
            this.InvalidText.Size = new System.Drawing.Size(259, 20);
            this.InvalidText.TabIndex = 14;
            this.InvalidText.Text = "Bilgileri Kontrol edip tekrar deneyiniz.";
            this.InvalidText.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 429);
            this.Controls.Add(this.InvalidText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginButton;
        private TextBox Username;
        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorProvider1;
        private TextBox Password;
        private Label InvalidText;
        private Label label2;
        private Label label1;
    }
}