namespace StudentInformation
{
    partial class StudentRegistration
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
            this.grpBoxStudentInformation = new System.Windows.Forms.GroupBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxProvince = new System.Windows.Forms.TextBox();
            this.txtBoxPostalCode = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBoxCourseInfo = new System.Windows.Forms.GroupBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.cbxDisplayCourses = new System.Windows.Forms.ComboBox();
            this.radioBtnProgrammer = new System.Windows.Forms.RadioButton();
            this.radioBtnProgrammerAnalyst = new System.Windows.Forms.RadioButton();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.txtBoxDisplay = new System.Windows.Forms.TextBox();
            this.grpBoxStudentInformation.SuspendLayout();
            this.grpBoxCourseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxStudentInformation
            // 
            this.grpBoxStudentInformation.Controls.Add(this.txtBoxPhoneNumber);
            this.grpBoxStudentInformation.Controls.Add(this.txtBoxProvince);
            this.grpBoxStudentInformation.Controls.Add(this.txtBoxPostalCode);
            this.grpBoxStudentInformation.Controls.Add(this.txtBoxCity);
            this.grpBoxStudentInformation.Controls.Add(this.txtBoxAddress);
            this.grpBoxStudentInformation.Controls.Add(this.txtBoxName);
            this.grpBoxStudentInformation.Controls.Add(this.lblPhoneNumber);
            this.grpBoxStudentInformation.Controls.Add(this.lblProvince);
            this.grpBoxStudentInformation.Controls.Add(this.lblPostalCode);
            this.grpBoxStudentInformation.Controls.Add(this.lblCity);
            this.grpBoxStudentInformation.Controls.Add(this.lblAddress);
            this.grpBoxStudentInformation.Controls.Add(this.lblName);
            this.grpBoxStudentInformation.Location = new System.Drawing.Point(12, 12);
            this.grpBoxStudentInformation.Name = "grpBoxStudentInformation";
            this.grpBoxStudentInformation.Size = new System.Drawing.Size(294, 189);
            this.grpBoxStudentInformation.TabIndex = 0;
            this.grpBoxStudentInformation.TabStop = false;
            this.grpBoxStudentInformation.Text = "Student Information";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(102, 146);
            this.txtBoxPhoneNumber.Mask = "(999) 000-0000";
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(122, 20);
            this.txtBoxPhoneNumber.TabIndex = 11;
            // 
            // txtBoxProvince
            // 
            this.txtBoxProvince.Location = new System.Drawing.Point(102, 120);
            this.txtBoxProvince.Name = "txtBoxProvince";
            this.txtBoxProvince.Size = new System.Drawing.Size(83, 20);
            this.txtBoxProvince.TabIndex = 10;
            this.txtBoxProvince.TextChanged += new System.EventHandler(this.txtBoxProvince_TextChanged);
            // 
            // txtBoxPostalCode
            // 
            this.txtBoxPostalCode.Location = new System.Drawing.Point(102, 89);
            this.txtBoxPostalCode.Name = "txtBoxPostalCode";
            this.txtBoxPostalCode.Size = new System.Drawing.Size(122, 20);
            this.txtBoxPostalCode.TabIndex = 9;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(102, 62);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(175, 20);
            this.txtBoxCity.TabIndex = 8;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(102, 37);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(175, 20);
            this.txtBoxAddress.TabIndex = 7;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(102, 12);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(175, 20);
            this.txtBoxName.TabIndex = 6;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 154);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Phone Number: ";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(7, 127);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(49, 13);
            this.lblProvince.TabIndex = 4;
            this.lblProvince.Text = "Province";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(7, 96);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 3;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 69);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 44);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // grpBoxCourseInfo
            // 
            this.grpBoxCourseInfo.Controls.Add(this.lstCourses);
            this.grpBoxCourseInfo.Controls.Add(this.cbxDisplayCourses);
            this.grpBoxCourseInfo.Controls.Add(this.radioBtnProgrammer);
            this.grpBoxCourseInfo.Controls.Add(this.radioBtnProgrammerAnalyst);
            this.grpBoxCourseInfo.Location = new System.Drawing.Point(312, 13);
            this.grpBoxCourseInfo.Name = "grpBoxCourseInfo";
            this.grpBoxCourseInfo.Size = new System.Drawing.Size(341, 188);
            this.grpBoxCourseInfo.TabIndex = 1;
            this.grpBoxCourseInfo.TabStop = false;
            this.grpBoxCourseInfo.Text = "Course Information";
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(18, 68);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(168, 108);
            this.lstCourses.TabIndex = 3;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // cbxDisplayCourses
            // 
            this.cbxDisplayCourses.FormattingEnabled = true;
            this.cbxDisplayCourses.Location = new System.Drawing.Point(18, 36);
            this.cbxDisplayCourses.Name = "cbxDisplayCourses";
            this.cbxDisplayCourses.Size = new System.Drawing.Size(168, 21);
            this.cbxDisplayCourses.TabIndex = 2;
            this.cbxDisplayCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // radioBtnProgrammer
            // 
            this.radioBtnProgrammer.AutoSize = true;
            this.radioBtnProgrammer.Location = new System.Drawing.Point(193, 13);
            this.radioBtnProgrammer.Name = "radioBtnProgrammer";
            this.radioBtnProgrammer.Size = new System.Drawing.Size(129, 17);
            this.radioBtnProgrammer.TabIndex = 1;
            this.radioBtnProgrammer.Text = "Computer Programmer";
            this.radioBtnProgrammer.UseVisualStyleBackColor = true;
            this.radioBtnProgrammer.CheckedChanged += new System.EventHandler(this.radioBtnProgrammer_CheckedChanged);
            // 
            // radioBtnProgrammerAnalyst
            // 
            this.radioBtnProgrammerAnalyst.AutoSize = true;
            this.radioBtnProgrammerAnalyst.Location = new System.Drawing.Point(18, 14);
            this.radioBtnProgrammerAnalyst.Name = "radioBtnProgrammerAnalyst";
            this.radioBtnProgrammerAnalyst.Size = new System.Drawing.Size(168, 17);
            this.radioBtnProgrammerAnalyst.TabIndex = 0;
            this.radioBtnProgrammerAnalyst.Text = "Computer Programmer/Analyst";
            this.radioBtnProgrammerAnalyst.UseVisualStyleBackColor = true;
            this.radioBtnProgrammerAnalyst.Click += new System.EventHandler(this.radioBtnProgrammerAnalyst_Click);
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Location = new System.Drawing.Point(22, 219);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(75, 23);
            this.BtnDisplay.TabIndex = 2;
            this.BtnDisplay.Text = "Display";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // txtBoxDisplay
            // 
            this.txtBoxDisplay.Location = new System.Drawing.Point(22, 249);
            this.txtBoxDisplay.Multiline = true;
            this.txtBoxDisplay.Name = "txtBoxDisplay";
            this.txtBoxDisplay.Size = new System.Drawing.Size(631, 103);
            this.txtBoxDisplay.TabIndex = 3;
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 364);
            this.Controls.Add(this.txtBoxDisplay);
            this.Controls.Add(this.BtnDisplay);
            this.Controls.Add(this.grpBoxCourseInfo);
            this.Controls.Add(this.grpBoxStudentInformation);
            this.Name = "StudentRegistration";
            this.Text = "Student Registration";
            this.grpBoxStudentInformation.ResumeLayout(false);
            this.grpBoxStudentInformation.PerformLayout();
            this.grpBoxCourseInfo.ResumeLayout(false);
            this.grpBoxCourseInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxStudentInformation;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxProvince;
        private System.Windows.Forms.TextBox txtBoxPostalCode;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.GroupBox grpBoxCourseInfo;
        private System.Windows.Forms.ComboBox cbxDisplayCourses;
        private System.Windows.Forms.RadioButton radioBtnProgrammer;
        private System.Windows.Forms.RadioButton radioBtnProgrammerAnalyst;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.TextBox txtBoxDisplay;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.MaskedTextBox txtBoxPhoneNumber;
    }
}

