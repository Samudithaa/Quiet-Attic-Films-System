namespace Databasesys
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblus = new System.Windows.Forms.Label();
            this.lblpw = new System.Windows.Forms.Label();
            this.txtus = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.RosyBrown;
            this.lbllogin.Font = new System.Drawing.Font("Stencil Std", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(297, 82);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(307, 57);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Login Form";
            this.lbllogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblus
            // 
            this.lblus.AutoSize = true;
            this.lblus.BackColor = System.Drawing.Color.RosyBrown;
            this.lblus.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblus.Location = new System.Drawing.Point(227, 258);
            this.lblus.Name = "lblus";
            this.lblus.Size = new System.Drawing.Size(155, 41);
            this.lblus.TabIndex = 1;
            this.lblus.Text = "Username";
            this.lblus.Click += new System.EventHandler(this.lblus_Click);
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.BackColor = System.Drawing.Color.RosyBrown;
            this.lblpw.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpw.Location = new System.Drawing.Point(227, 358);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(146, 41);
            this.lblpw.TabIndex = 2;
            this.lblpw.Text = "Password";
            this.lblpw.Click += new System.EventHandler(this.lblpw_Click);
            // 
            // txtus
            // 
            this.txtus.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtus.Location = new System.Drawing.Point(428, 258);
            this.txtus.Multiline = true;
            this.txtus.Name = "txtus";
            this.txtus.Size = new System.Drawing.Size(205, 41);
            this.txtus.TabIndex = 3;
            this.txtus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpw
            // 
            this.txtpw.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.Location = new System.Drawing.Point(428, 358);
            this.txtpw.Multiline = true;
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(205, 41);
            this.txtpw.TabIndex = 4;
            this.txtpw.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(535, 456);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(98, 40);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnclr
            // 
            this.btnclr.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(428, 456);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(98, 40);
            this.btnclr.TabIndex = 6;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 641);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtus);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.lblus);
            this.Controls.Add(this.lbllogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblus;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtus;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnclr;
    }
}

