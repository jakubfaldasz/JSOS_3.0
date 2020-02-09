using JakubFaldaszLab4Zadanie.Models;
using JakubFaldaszLab4Zadanie.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubFaldaszLab4Zadanie
{
    public partial class FormIndex : Form
    {
        private FormMain main;
        private Student student;
        private readonly JsosGeneric<Grade> _grades;
        private readonly JsosGeneric<Course> _courses;
        private readonly JsosGeneric<Models.Message> _messages;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="main"></param>
        /// <param name="student"></param>
        public FormIndex(FormMain main, Student student)
        {
            this.student = student;
            _courses = new JsosGeneric<Course>();
            _grades = new JsosGeneric<Grade>();
            _messages = new JsosGeneric<Models.Message>();


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.main = main;
            InitializeComponent();
        }

        /// <summary>
        /// Wyświetla dane studenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDaneStudenta_Click(object sender, EventArgs e)
        {
            DisplayStudentsData();
        }

        /// <summary>
        /// Zapełnia labele odpowiednimi danymi o studencie
        /// </summary>
        private void DisplayStudentsData()
        {
            HideAllSections();
            groupBoxStudentData.Visible = true;
            labelFacultyValue.Text = student.Faculty;
            labelFieldValue.Text = student.FieldOfStudy;
            labelLevelValue.Text = student.Level;
            labelIndexValue.Text = "" + student.StudentIDNumber;
            labelNameValue.Text = student.FirstName;
            labelLastNameValue.Text = student.LastName;
            labelBirthDateValue.Text = student.BirthDate.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Ukrywa wszystkie groupboxy
        /// </summary>
        private void HideAllSections()
        {
            groupBoxCourses.Visible = false;
            groupBoxStudentData.Visible = false;
            groupBoxMessages.Visible = false;
            groupBoxGrades.Visible = false;
        }

        /// <summary>
        /// Wyloguj uzytkownika, powrót do menu głownego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            main.Location = this.Location;
            main.Show();
            this.Hide();
        }

        /// <summary>
        /// Przejście do widoku ocen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOceny_Click(object sender, EventArgs e)
        {
            dataGridViewGrades.DataSource = _grades.GetStudentsGrades(student.Id);
            HideAllSections();
            groupBoxGrades.Visible = true;

            labelTutor.Text = "";
            labelCourseName.Text = "";
            labelGrade.Text = "";
            labelGradeDate.Text = "";
            labelECTS.Text = "";

            showSelectedGrade();
        }

        /// <summary>
        /// Wyświetlenie danej oceny po naciśnięciu na wiersz w tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!showSelectedGrade())
                MessageBox.Show("Brak oceny");
        }

        /// <summary>
        /// Wyświetl daną ocene
        /// </summary>
        /// <returns></returns>
        private bool showSelectedGrade()
        {
            try
            {
                int courseIndex = (int)dataGridViewGrades.SelectedRows[0].Cells[3].Value;
                int gradeIndex = (int)dataGridViewGrades.SelectedRows[0].Cells[0].Value;
                Course course = _courses.GetById(courseIndex);
                Grade grade = _grades.GetById(gradeIndex);

                labelTutor.Text = course.TeacherName;
                labelCourseName.Text = course.CourseName;
                labelGrade.Text = "" + grade.Mark;
                labelGradeDate.Text = grade.Date.ToString("dd/MM/yyyy");
                labelECTS.Text = "" + course.ECTS;
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        
        /// <summary>
        /// Wyswietlenie danej oceny po nacisnieciu na przycisk "wybierz"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowGrades_Click(object sender, EventArgs e)
        {
            if (!showSelectedGrade())
                MessageBox.Show("Brak oceny");
        }

        /// <summary>
        /// Przełączenie na widok kursów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCourses_Click(object sender, EventArgs e)
        {
            HideAllSections();
            groupBoxCourses.Visible = true;
            dataGridViewCourses.Visible = true;
            dataGridViewCourses.DataSource = _courses.GetAll();
            dataGridViewCourses.Columns[0].Visible = false;
        }

        /// <summary>
        /// przełączenie na widok wiadomości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMessages_Click(object sender, EventArgs e)
        {
            HideAllSections();
            groupBoxMessages.Visible = true;
            dataGridViewMessages.DataSource = _messages.GetStudentsMessages(student.Id);
            dataGridViewMessages.Columns[0].Visible = false;
            dataGridViewMessages.Columns[4].Visible = false;
            dataGridViewMessages.Columns[5].Visible = false;
            dataGridViewMessages.Columns[1].Width = groupBoxMessages.Width;
        }


        /// <summary>
        /// Wyświetlenie konkretnej wiadomości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMessages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                int messageId = (int)dataGridViewMessages.SelectedRows[0].Cells[0].Value;
                Models.Message message = _messages.GetById(messageId);

                labelTitle.Text = message.Subject;
                labelMessage.Text = message.MessageContent;
            } catch(Exception exc)
            {

            }
        }
        
        /// <summary>
        /// Wyjście z aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Usuń wiadomość
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteMessage_Click(object sender, EventArgs e)
        {
            int messageId = -1;

            try
            {
                messageId = (int)dataGridViewMessages.SelectedRows[0].Cells[0].Value;
            } catch(Exception exc)
            {
            }

            if (messageId == -1)
                return;
            else
            {
                _messages.DeleteById(messageId);
                _messages.Save();
                dataGridViewMessages.DataSource = _messages.GetStudentsMessages(student.Id);
            }
        }
    }
}
