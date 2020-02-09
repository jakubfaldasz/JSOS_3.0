namespace JakubFaldaszLab4Zadanie
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.labelBack = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.labelField = new System.Windows.Forms.Label();
            this.textBoxField = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxLevels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBack
            // 
            this.labelBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBack.Location = new System.Drawing.Point(290, 191);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(492, 352);
            this.labelBack.TabIndex = 0;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegister.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegister.Location = new System.Drawing.Point(299, 200);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(105, 23);
            this.labelRegister.TabIndex = 1;
            this.labelRegister.Text = "Rejestracja";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(454, 257);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(205, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(415, 258);
            this.labelName.Name = "labelName";
            this.labelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelName.Size = new System.Drawing.Size(33, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Imię";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLastName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(384, 284);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelLastName.Size = new System.Drawing.Size(64, 16);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Nazwisko";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(454, 283);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(205, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBirthDate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBirthDate.Location = new System.Drawing.Point(353, 310);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelBirthDate.Size = new System.Drawing.Size(95, 16);
            this.labelBirthDate.TabIndex = 7;
            this.labelBirthDate.Text = "Data urodzenia";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFaculty.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFaculty.Location = new System.Drawing.Point(396, 335);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFaculty.Size = new System.Drawing.Size(52, 16);
            this.labelFaculty.TabIndex = 9;
            this.labelFaculty.Text = "Wydział";
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.Location = new System.Drawing.Point(454, 335);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(205, 20);
            this.textBoxFaculty.TabIndex = 8;
            // 
            // labelField
            // 
            this.labelField.AutoSize = true;
            this.labelField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelField.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelField.Location = new System.Drawing.Point(388, 362);
            this.labelField.Name = "labelField";
            this.labelField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelField.Size = new System.Drawing.Size(60, 16);
            this.labelField.TabIndex = 11;
            this.labelField.Text = "Kierunek";
            // 
            // textBoxField
            // 
            this.textBoxField.Location = new System.Drawing.Point(454, 361);
            this.textBoxField.Name = "textBoxField";
            this.textBoxField.Size = new System.Drawing.Size(205, 20);
            this.textBoxField.TabIndex = 10;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLevel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevel.Location = new System.Drawing.Point(397, 387);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelLevel.Size = new System.Drawing.Size(51, 16);
            this.labelLevel.TabIndex = 13;
            this.labelLevel.Text = "Stopień";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIndex.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIndex.Location = new System.Drawing.Point(401, 413);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelIndex.Size = new System.Drawing.Size(47, 16);
            this.labelIndex.TabIndex = 15;
            this.labelIndex.Text = "Indeks";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(454, 413);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(205, 20);
            this.textBoxIndex.TabIndex = 14;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(454, 309);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerBirthDate.TabIndex = 16;
            // 
            // comboBoxLevels
            // 
            this.comboBoxLevels.FormattingEnabled = true;
            this.comboBoxLevels.Location = new System.Drawing.Point(454, 387);
            this.comboBoxLevels.Name = "comboBoxLevels";
            this.comboBoxLevels.Size = new System.Drawing.Size(205, 21);
            this.comboBoxLevels.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(391, 450);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(455, 453);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(205, 20);
            this.textBoxLogin.TabIndex = 19;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(455, 479);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(205, 20);
            this.textBoxPassword.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(389, 476);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hasło";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRegister.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegister.Location = new System.Drawing.Point(508, 505);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(87, 31);
            this.buttonRegister.TabIndex = 22;
            this.buttonRegister.Text = "Zarejestruj";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonGoBack.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(293, 517);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(76, 26);
            this.buttonGoBack.TabIndex = 23;
            this.buttonGoBack.Text = "Powrót";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 631);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLevels);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelField);
            this.Controls.Add(this.textBoxField);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.textBoxFaculty);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelBack);
            this.Location = new System.Drawing.Point(677, 441);
            this.Name = "FormRegister";
            this.Text = "JSOS 3.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegister_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.TextBox textBoxField;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.ComboBox comboBoxLevels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonGoBack;
    }
}