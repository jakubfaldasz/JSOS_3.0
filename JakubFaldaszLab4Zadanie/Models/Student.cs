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
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        [DisplayName("Imie")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
        
        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        [DisplayName("Wydzial")]
        public string Faculty { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        [DisplayName("Kierunek")]
        public string FieldOfStudy { get; set; }

        [Required]
        [DisplayName("Stopien")]
        public string Level { get; set; }

        [Required]
        [DisplayName("Indeks")]
        [Range(100000, 300000)]
        public int StudentIDNumber { get; set; }

        [Required]
        [DisplayName("Login")]
        public string Login{ get; set; }

        [Required]
        [DisplayName("Haslo")]
        public string Password{ get; set; }
    }
}
