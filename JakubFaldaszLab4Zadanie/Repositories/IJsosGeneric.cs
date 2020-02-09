using JakubFaldaszLab4Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubFaldaszLab4Zadanie.Repositories
{
    interface IJsosGeneric <T> where T : class
    {
        int ProperLoginDetails(string login, string password);
        bool LoginTaken(string login);
        List<Grade> GetStudentsGrades(int studentsId);
        List<Message> GetStudentsMessages(int studentsId);

        List<T> GetAll();
        IQueryable<T> Get();
        T GetById(int id);
        void DeleteById(int id);
        void Update(T entity);
        void Create(T entity);
        void Save();
    }
}
