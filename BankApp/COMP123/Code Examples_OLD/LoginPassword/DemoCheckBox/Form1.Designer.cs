namespace DemoCheckBox
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
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkPHP = new System.Windows.Forms.CheckBox();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.lblChoice = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Location = new System.Drawing.Point(51, 68);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(113, 17);
            this.chkJava.TabIndex = 0;
            this.chkJava.Text = "Java Programming";
            this.chkJava.UseVisualStyleBackColor = true;
            // 
            // chkPHP
            // 
            this.chkPHP.AutoSize = true;
            this.chkPHP.Location = new System.Drawing.Point(51, 108);
            this.chkPHP.Name = "chkPHP";
            this.chkPHP.Size = new System.Drawing.Size(112, 17);
            this.chkPHP.TabIndex = 1;
            this.chkPHP.Text = "PHP Programming";
            this.chkPHP.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(51, 146);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(104, 17);
            this.chkCSharp.TabIndex = 2;
            this.chkCSharp.Text = "C# Programming";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice.Location = new System.Drawing.Point(76, 28);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(156, 25);
            this.lblChoice.TabIndex = 3;
            this.lblChoice.Text = "List of Courses";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(229, 146);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 264);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.chkCSharp);
            this.Controls.Add(this.chkPHP);
            this.Controls.Add(this.chkJava);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.CheckBox chkPHP;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Button btnSubmit;
    }
}

