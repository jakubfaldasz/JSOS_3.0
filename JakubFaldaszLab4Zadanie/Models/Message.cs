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
    class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nadawca")]
        public string From { get; set; }

        [Required]
        [DisplayName("Temat")]
        public string Subject { get; set; }

        [DisplayName("Wiadomosc")]
        public string MessageContent{ get; set; }

        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student student{ get; set; }
    }
}
