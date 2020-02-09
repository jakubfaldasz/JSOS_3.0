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
    public partial class FormMain : Form
    {
        /// <summary>
        /// Połączenie z baza danych
        /// </summary>
        private readonly JsosGeneric<Student> _students;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public FormMain()
        {
            _students = new JsosGeneric<Student>();
            _students.Save();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        /// <summary>
        /// Przejście do rejestracji użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister(this);
            formRegister.Location = this.Location;
            formRegister.Show();
            this.Hide();
        }

        /// <summary>
        /// Zalgoowanie i przejście do panelu użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            int studentId = _students.ProperLoginDetails(login, password);

            if (studentId != -1)
            {
                Student student = _students.GetById(studentId);
                FormIndex formIndex = new FormIndex(this, student);
                formIndex.Location = this.Location;
                formIndex.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wprowadzono niepoprawne dane logowania.");
            }
        }

        /// <summary>
        /// Przejście do panelu prowadzącego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTutor_Click(object sender, EventArgs e)
        {
            FormTutor formTutor = new FormTutor(this);
            formTutor.Show();
            this.Hide();
        }
    }
}
