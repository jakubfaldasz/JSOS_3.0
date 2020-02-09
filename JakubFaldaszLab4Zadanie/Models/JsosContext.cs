using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubFaldaszLab4Zadanie.Models
{
    class JsosContext : DbContext
    {
        public JsosContext() : base("AppContext")
        {

        }

        public virtual DbSet<Course> courses { get; set; }
        public virtual DbSet<Payment> payments { get; set; }
        public virtual DbSet<Message> messages { get; set; }
        public virtual DbSet<Grade> grades { get; set; }
        public virtual DbSet<Student> students { get; set; }
    }
}
