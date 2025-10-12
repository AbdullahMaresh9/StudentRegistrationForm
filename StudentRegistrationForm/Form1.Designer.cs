namespace StudentRegistrationForm
{
    partial class fmRegistration
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblBrithdate = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.lblSelectedColor = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.btnSubmot = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(60, 58);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(60, 135);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 37);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(60, 212);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(158, 37);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(60, 288);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(123, 37);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(60, 365);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(218, 37);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Favorite Color";
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // lblBrithdate
            // 
            this.lblBrithdate.AutoSize = true;
            this.lblBrithdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrithdate.Location = new System.Drawing.Point(60, 442);
            this.lblBrithdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrithdate.Name = "lblBrithdate";
            this.lblBrithdate.Size = new System.Drawing.Size(145, 37);
            this.lblBrithdate.TabIndex = 5;
            this.lblBrithdate.Text = "Birthdate";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(60, 519);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(225, 37);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Select Country";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(300, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(396, 44);
            this.txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(300, 135);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(396, 44);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(300, 212);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(396, 44);
            this.txtPassword.TabIndex = 9;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoOther);
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Location = new System.Drawing.Point(300, 269);
            this.grpGender.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpGender.Name = "grpGender";
            this.grpGender.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpGender.Size = new System.Drawing.Size(400, 84);
            this.grpGender.TabIndex = 10;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(280, 38);
            this.rdoOther.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(96, 29);
            this.rdoOther.TabIndex = 2;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(140, 38);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(114, 29);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(20, 38);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(90, 29);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(300, 365);
            this.btnPickColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(180, 44);
            this.btnPickColor.TabIndex = 11;
            this.btnPickColor.Text = "Choose Color";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // lblSelectedColor
            // 
            this.lblSelectedColor.AutoSize = true;
            this.lblSelectedColor.Location = new System.Drawing.Point(496, 375);
            this.lblSelectedColor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectedColor.Name = "lblSelectedColor";
            this.lblSelectedColor.Size = new System.Drawing.Size(186, 25);
            this.lblSelectedColor.TabIndex = 12;
            this.lblSelectedColor.Text = "No Color Selected";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(300, 442);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(396, 31);
            this.dtpBirthdate.TabIndex = 13;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Yemen",
            "Egypt",
            "Oman",
            "Qatar",
            "Palestine",
            "Syria"});
            this.cmbCountry.Location = new System.Drawing.Point(300, 519);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(238, 33);
            this.cmbCountry.TabIndex = 14;
            // 
            // btnSubmot
            // 
            this.btnSubmot.Location = new System.Drawing.Point(300, 615);
            this.btnSubmot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubmot.Name = "btnSubmot";
            this.btnSubmot.Size = new System.Drawing.Size(200, 58);
            this.btnSubmot.TabIndex = 15;
            this.btnSubmot.Text = "Register";
            this.btnSubmot.UseVisualStyleBackColor = true;
            this.btnSubmot.Click += new System.EventHandler(this.btnSubmot_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(60, 769);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblResult.Multiline = true;
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(998, 94);
            this.lblResult.TabIndex = 16;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(520, 615);
            this.btnResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(200, 58);
            this.btnResult.TabIndex = 17;
            this.btnResult.Text = "Reset";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // picStudent
            // 
            this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.picStudent.Location = new System.Drawing.Point(800, 58);
            this.picStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(238, 229);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 18;
            this.picStudent.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(800, 308);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(240, 58);
            this.btnUpload.TabIndex = 19;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 692);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 58);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(760, 692);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(200, 58);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // fmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1168, 887);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSubmot);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.lblSelectedColor);
            this.Controls.Add(this.btnPickColor);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblBrithdate);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmRegistration";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Student Registration Form";
            this.Load += new System.EventHandler(this.fmRegistration_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblBrithdate;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.Label lblSelectedColor;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Button btnSubmot;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

