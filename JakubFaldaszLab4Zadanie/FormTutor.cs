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
    public partial class FormTutor : Form
    {
        // Połączenie z bazą
        private readonly JsosGeneric<Course> _courses;
        private readonly JsosGeneric<Student> _students;
        private readonly JsosGeneric<Models.Message> _messages;
        private readonly JsosGeneric<Grade> _grades;
        private FormMain main;
        //Dostępne oceny do wystawienia
        private double[] availableGrades = { 2.0, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0, 5.5 };

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="main"></param>
        public FormTutor(FormMain main)
        {
            _courses = new JsosGeneric<Course>();
            _students = new JsosGeneric<Student>();
            _messages = new JsosGeneric<Models.Message>();
            _grades = new JsosGeneric<Grade>();
            this.main = main;
            InitializeComponent();

            comboBoxGrades.DataSource = availableGrades;
            dataGridViewStudents.DataSource = _students.GetAll();
            dataGridViewCourses.DataSource = _courses.GetAll();
          
        }

        /// <summary>
        /// Wysłanie wiadomości danemu studentowi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            int studentsIndex = -1;
            try
            {
                studentsIndex = (int)dataGridViewStudents.SelectedRows[0].Cells[0].Value;
            } catch(Exception exc)
            {
            }

            if(textBoxAuthor.Text == "" )
            {
                MessageBox.Show("Nie wprowadzono nadawcy");
                return;
            }
            else if(studentsIndex == -1)
            {
                MessageBox.Show("Nie wybrano studenta");
            }
            else
            {
                var author = textBoxAuthor.Text;
                var subject = textBoxSubject.Text;
                var message = textBoxMessage.Text;

                Models.Message messageToSend = new Models.Message()
                {
                    From = author,
                    Subject = subject,
                    MessageContent = message,
                    StudentId = studentsIndex

                };

                _messages.Create(messageToSend);
                _messages.Save();
                textBoxAuthor.Text = "";
                textBoxSubject.Text = "";
                textBoxMessage.Text = "";
                MessageBox.Show("Wysłano wiadomość");

            }

        }

        /// <summary>
        /// Powrót do menu głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }


        /// <summary>
        /// Wystawienie oceny za dany kurs danemu uczniowi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendGrade_Click(object sender, EventArgs e)
        {
            int studentsIndex = -1;
            int courseIndex = -1;
            try
            {
                studentsIndex = (int)dataGridViewStudents.SelectedRows[0].Cells[0].Value;
                courseIndex = (int)dataGridViewCourses.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception exc)
            {
            }

            if (studentsIndex == -1)
            {
                MessageBox.Show("Nie wybrano studenta");
            } 
            else if(courseIndex == -1)
            {
                MessageBox.Show("Nie wybrano kursu");
            }
            else
            {
                var mark = Double.Parse(comboBoxGrades.Text);
                var date = DateTime.Now;

                Grade grade = new Grade()
                {
                    Mark = (float)mark,
                    Date = date,
                    CourseId = courseIndex,
                    StudentId = studentsIndex
                };

                _grades.Create(grade);
                _grades.Save();
                MessageBox.Show("Wystawiono ocenę");
            }
        }

        /// <summary>
        /// Dodanie nowego kursu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            var courseName = textBoxCourseName.Text;
            var teacherName = textBoxTutor.Text;
            var groupCode = textBoxGroupCode.Text;
            var term = textBoxTerm.Text;
            var ectsPoints = -1;
            try
            {
                ectsPoints = Int32.Parse(textBoxECTS.Text);
            } catch(Exception exc)
            {
                MessageBox.Show("Niepoprawny format ECTS");
            }

            if (ectsPoints == -1)
                return;

            Course course = new Course()
            {
                CourseName = courseName,
                TeacherName = teacherName,
                CodeOfGroup = groupCode,
                Term = term,
                ECTS = ectsPoints
            };

            try
            {
                _courses.Create(course);
                _courses.Save();
                MessageBox.Show("Pomyślnie utworzono nowy kurs.");
                textBoxCourseName.Text = "";
                textBoxTutor.Text = "";
                textBoxGroupCode.Text = "";
                textBoxGroupCode.Text = "";
                dataGridViewCourses.DataSource = _courses.GetAll();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Podano błędne wartości");
            }
        }

        /// <summary>
        /// Zamknięcie aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
