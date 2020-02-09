using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubFaldaszLab4Zadanie.Models
{
    class Grade
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Ocena")]
        [Range(2.0, 5.5)]
        public float Mark { get; set; }

        [DisplayName("Data_wystawienia")]
        public DateTime Date { get; set; }

        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course course{ get; set; }

        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student student{ get; set; }
    }
}
