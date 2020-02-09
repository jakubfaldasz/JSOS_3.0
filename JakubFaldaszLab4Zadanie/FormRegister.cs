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
    public partial class FormRegister : Form
    {
        // Stopnie studiów
        string[] levels = { "I stopień", "II stopień" };
        // Menu głowne
        FormMain main;
        
        //Studenci
        private readonly JsosGeneric<Student> _students;

        /// <summary>
        /// Konstruktor inizjalizujacy
        /// </summary>
        /// <param name="main"></param>
        public FormRegister(FormMain main)
        {
            _students = new JsosGeneric<Student>();
            this.main = main;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            comboBoxLevels.Items.AddRange(levels);
        }

        /// <summary>
        /// Powrót do menu głownego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        /// <summary>
        /// Stworzenie nowego użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var studentFirstName = textBoxName.Text;
            var studentLastName = textBoxLastName.Text;
            var birthDate = dateTimePickerBirthDate.Text;
            var faculty = textBoxFaculty.Text;
            var fieldOfStudy = textBoxField.Text;
            var level = comboBoxLevels.Text;
            int index = 0;
            try
            {
                index = Int32.Parse(textBoxIndex.Text);
            } catch(Exception exc)
            {

            }
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            Student newStudent = new Student
            {
                FirstName = studentFirstName,
                LastName = studentLastName,
                BirthDate = Convert.ToDateTime(birthDate),
                Faculty = faculty,
                FieldOfStudy = fieldOfStudy,
                Level = level,
                StudentIDNumber = index,
                Login = login,
                Password = password
            };

            if (_students.LoginTaken(login))
                MessageBox.Show("Ten login jest już zajęty!");
            else
            {
                try
                {
                    _students.Create(newStudent);
                    _students.Save();
                    main.Show();
                    this.Hide();

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Wprowadzono niepoprawne dane.");
                }
            }

        }

        /// <summary>
        /// Zamknięcie aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
