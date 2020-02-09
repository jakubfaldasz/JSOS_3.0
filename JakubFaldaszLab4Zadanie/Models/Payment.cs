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
    class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Kwota")]
        public float Amount { get; set; }

        [Required]
        [DisplayName("Status")]
        public String Status { get; set; }

        [Required]
        [DisplayName("Termin_platnosci")]
        public DateTime PaymentDeadline { get; set; }

        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student student{ get; set; }
    }
}
