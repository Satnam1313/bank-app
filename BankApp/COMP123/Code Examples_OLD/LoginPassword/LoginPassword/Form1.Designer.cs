namespace LoginPassword
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblOutputLogin = new System.Windows.Forms.Label();
            this.lblOutputPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(168, 26);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 79);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasword:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(168, 128);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 29);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(65, 172);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(284, 23);
            this.lblMessage.TabIndex = 5;
            // 
            // lblOutputLogin
            // 
            this.lblOutputLogin.AutoSize = true;
            this.lblOutputLogin.Location = new System.Drawing.Point(106, 218);
            this.lblOutputLogin.Name = "lblOutputLogin";
            this.lblOutputLogin.Size = new System.Drawing.Size(0, 13);
            this.lblOutputLogin.TabIndex = 6;
            // 
            // lblOutputPassword
            // 
            this.lblOutputPassword.AutoSize = true;
            this.lblOutputPassword.Location = new System.Drawing.Point(107, 260);
            this.lblOutputPassword.Name = "lblOutputPassword";
            this.lblOutputPassword.Size = new System.Drawing.Size(0, 13);
            this.lblOutputPassword.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 315);
            this.Controls.Add(this.lblOutputPassword);
            this.Controls.Add(this.lblOutputLogin);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblOutputLogin;
        private System.Windows.Forms.Label lblOutputPassword;
    }
}

