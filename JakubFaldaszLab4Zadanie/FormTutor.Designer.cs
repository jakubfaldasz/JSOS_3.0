namespace JakubFaldaszLab4Zadanie
{
    partial class FormTutor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.labelStudents = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.labelGrade = new System.Windows.Forms.Label();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.labelCourses = new System.Windows.Forms.Label();
            this.comboBoxGrades = new System.Windows.Forms.ComboBox();
            this.buttonSendGrade = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.labelGroupCode = new System.Windows.Forms.Label();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelECTS = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxTutor = new System.Windows.Forms.TextBox();
            this.textBoxGroupCode = new System.Windows.Forms.TextBox();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.textBoxECTS = new System.Windows.Forms.TextBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudents.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(209, 406);
            this.dataGridViewStudents.TabIndex = 24;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStudents.Location = new System.Drawing.Point(12, 7);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(84, 22);
            this.labelStudents.TabIndex = 25;
            this.labelStudents.Text = "Studenci";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(331, 272);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(201, 20);
            this.textBoxSubject.TabIndex = 26;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(245, 298);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(287, 111);
            this.textBoxMessage.TabIndex = 27;
            this.textBoxMessage.Text = "Wiadomość";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(331, 246);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(201, 20);
            this.textBoxAuthor.TabIndex = 28;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Arial", 11F);
            this.labelAuthor.Location = new System.Drawing.Point(260, 249);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(69, 17);
            this.labelAuthor.TabIndex = 29;
            this.labelAuthor.Text = "Nadawca";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Arial", 11F);
            this.labelSubject.Location = new System.Drawing.Point(281, 272);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(48, 17);
            this.labelSubject.TabIndex = 30;
            this.labelSubject.Text = "Temat";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(245, 415);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(287, 23);
            this.buttonSendMessage.TabIndex = 31;
            this.buttonSendMessage.Text = "Wyślij";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Arial", 11F);
            this.labelGrade.Location = new System.Drawing.Point(542, 388);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(52, 17);
            this.labelGrade.TabIndex = 32;
            this.labelGrade.Text = "Ocena";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AllowUserToAddRows = false;
            this.dataGridViewCourses.AllowUserToDeleteRows = false;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCourses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCourses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewCourses.Location = new System.Drawing.Point(245, 32);
            this.dataGridViewCourses.MultiSelect = false;
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.ReadOnly = true;
            this.dataGridViewCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCourses.Size = new System.Drawing.Size(543, 187);
            this.dataGridViewCourses.TabIndex = 34;
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCourses.Location = new System.Drawing.Point(241, 7);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(58, 22);
            this.labelCourses.TabIndex = 35;
            this.labelCourses.Text = "Kursy";
            // 
            // comboBoxGrades
            // 
            this.comboBoxGrades.FormattingEnabled = true;
            this.comboBoxGrades.Location = new System.Drawing.Point(600, 388);
            this.comboBoxGrades.Name = "comboBoxGrades";
            this.comboBoxGrades.Size = new System.Drawing.Size(59, 21);
            this.comboBoxGrades.TabIndex = 36;
            // 
            // buttonSendGrade
            // 
            this.buttonSendGrade.Location = new System.Drawing.Point(545, 415);
            this.buttonSendGrade.Name = "buttonSendGrade";
            this.buttonSendGrade.Size = new System.Drawing.Size(114, 23);
            this.buttonSendGrade.TabIndex = 37;
            this.buttonSendGrade.Text = "Wstaw ocenę";
            this.buttonSendGrade.UseVisualStyleBackColor = true;
            this.buttonSendGrade.Click += new System.EventHandler(this.buttonSendGrade_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(702, 390);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(86, 48);
            this.buttonGoBack.TabIndex = 38;
            this.buttonGoBack.Text = "Powrót";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Arial", 11F);
            this.labelCourseName.Location = new System.Drawing.Point(548, 222);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(93, 17);
            this.labelCourseName.TabIndex = 39;
            this.labelCourseName.Text = "Nazwa kursu";
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Font = new System.Drawing.Font("Arial", 11F);
            this.labelTeacherName.Location = new System.Drawing.Point(552, 246);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(89, 17);
            this.labelTeacherName.TabIndex = 40;
            this.labelTeacherName.Text = "Prowadzący";
            // 
            // labelGroupCode
            // 
            this.labelGroupCode.AutoSize = true;
            this.labelGroupCode.Font = new System.Drawing.Font("Arial", 11F);
            this.labelGroupCode.Location = new System.Drawing.Point(567, 272);
            this.labelGroupCode.Name = "labelGroupCode";
            this.labelGroupCode.Size = new System.Drawing.Size(74, 17);
            this.labelGroupCode.TabIndex = 41;
            this.labelGroupCode.Text = "Kod grupy";
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Font = new System.Drawing.Font("Arial", 11F);
            this.labelTerm.Location = new System.Drawing.Point(589, 298);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(52, 17);
            this.labelTerm.TabIndex = 42;
            this.labelTerm.Text = "Termin";
            // 
            // labelECTS
            // 
            this.labelECTS.AutoSize = true;
            this.labelECTS.Font = new System.Drawing.Font("Arial", 11F);
            this.labelECTS.Location = new System.Drawing.Point(592, 323);
            this.labelECTS.Name = "labelECTS";
            this.labelECTS.Size = new System.Drawing.Size(48, 17);
            this.labelECTS.TabIndex = 43;
            this.labelECTS.Text = "ECTS";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(647, 222);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(141, 20);
            this.textBoxCourseName.TabIndex = 44;
            // 
            // textBoxTutor
            // 
            this.textBoxTutor.Location = new System.Drawing.Point(647, 246);
            this.textBoxTutor.Name = "textBoxTutor";
            this.textBoxTutor.Size = new System.Drawing.Size(141, 20);
            this.textBoxTutor.TabIndex = 45;
            // 
            // textBoxGroupCode
            // 
            this.textBoxGroupCode.Location = new System.Drawing.Point(647, 272);
            this.textBoxGroupCode.Name = "textBoxGroupCode";
            this.textBoxGroupCode.Size = new System.Drawing.Size(141, 20);
            this.textBoxGroupCode.TabIndex = 46;
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Location = new System.Drawing.Point(647, 298);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(141, 20);
            this.textBoxTerm.TabIndex = 47;
            // 
            // textBoxECTS
            // 
            this.textBoxECTS.Location = new System.Drawing.Point(647, 324);
            this.textBoxECTS.Name = "textBoxECTS";
            this.textBoxECTS.Size = new System.Drawing.Size(141, 20);
            this.textBoxECTS.TabIndex = 48;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(647, 350);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(141, 23);
            this.buttonAddCourse.TabIndex = 49;
            this.buttonAddCourse.Text = "Dodaj nowy kurs";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // FormTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.textBoxECTS);
            this.Controls.Add(this.textBoxTerm);
            this.Controls.Add(this.textBoxGroupCode);
            this.Controls.Add(this.textBoxTutor);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.labelECTS);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.labelGroupCode);
            this.Controls.Add(this.labelTeacherName);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonSendGrade);
            this.Controls.Add(this.comboBoxGrades);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "FormTutor";
            this.Text = "FormTutor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTutor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Label labelCourses;
        private System.Windows.Forms.ComboBox comboBoxGrades;
        private System.Windows.Forms.Button buttonSendGrade;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.Label labelGroupCode;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Label labelECTS;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxTutor;
        private System.Windows.Forms.TextBox textBoxGroupCode;
        private System.Windows.Forms.TextBox textBoxTerm;
        private System.Windows.Forms.TextBox textBoxECTS;
        private System.Windows.Forms.Button buttonAddCourse;
    }
}