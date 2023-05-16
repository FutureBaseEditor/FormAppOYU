namespace MyFirstFormAppProject
{
    partial class Form3
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
            this.Good = new System.Windows.Forms.Button();
            this.Cheap = new System.Windows.Forms.Button();
            this.Fast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Good
            // 
            this.Good.BackColor = System.Drawing.Color.Brown;
            this.Good.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Good.ForeColor = System.Drawing.Color.White;
            this.Good.Location = new System.Drawing.Point(388, 12);
            this.Good.Name = "Good";
            this.Good.Size = new System.Drawing.Size(284, 128);
            this.Good.TabIndex = 0;
            this.Good.Text = "Good";
            this.Good.UseVisualStyleBackColor = false;
            this.Good.Click += new System.EventHandler(this.Good_Click);
            // 
            // Cheap
            // 
            this.Cheap.BackColor = System.Drawing.Color.Brown;
            this.Cheap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cheap.ForeColor = System.Drawing.Color.White;
            this.Cheap.Location = new System.Drawing.Point(388, 146);
            this.Cheap.Name = "Cheap";
            this.Cheap.Size = new System.Drawing.Size(284, 128);
            this.Cheap.TabIndex = 1;
            this.Cheap.Text = "Cheap";
            this.Cheap.UseVisualStyleBackColor = false;
            this.Cheap.Click += new System.EventHandler(this.Cheap_Click);
            // 
            // Fast
            // 
            this.Fast.BackColor = System.Drawing.Color.Brown;
            this.Fast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fast.ForeColor = System.Drawing.Color.White;
            this.Fast.Location = new System.Drawing.Point(388, 280);
            this.Fast.Name = "Fast";
            this.Fast.Size = new System.Drawing.Size(284, 128);
            this.Fast.TabIndex = 2;
            this.Fast.Text = "Fast";
            this.Fast.UseVisualStyleBackColor = false;
            this.Fast.Click += new System.EventHandler(this.Fast_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 418);
            this.Controls.Add(this.Fast);
            this.Controls.Add(this.Cheap);
            this.Controls.Add(this.Good);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Good;
        private Button Cheap;
        private Button Fast;
    }
}