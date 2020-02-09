using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubFaldaszLab4Zadanie.Models
{
    class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nazwa_kursu")]
        public string CourseName { get; set; }

        [Required]
        [DisplayName("Prowadzacy")]
        public string TeacherName { get; set; }

        [Required]
        [DisplayName("Kod_grupy")]
        public string CodeOfGroup { get; set; }

        [Required]
        [DisplayName("Termin")]
        public string Term { get; set; }

        [Required]
        [DisplayName("ECTS")]
        public int ECTS { get; set; }
    }
}
