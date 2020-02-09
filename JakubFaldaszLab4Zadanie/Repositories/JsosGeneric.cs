using JakubFaldaszLab4Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubFaldaszLab4Zadanie.Repositories
{
    class JsosGeneric<T> : IJsosGeneric<T> where T : class
    {
        /// <summary>
        /// Kontekst bazy danych - połączenie z bazą
        /// </summary>
        private readonly JsosContext _context;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public JsosGeneric()
        {
            _context = new JsosContext();
        }
                          
        /// <summary>
        /// Sprawdza czy dany login jest zajęty
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool LoginTaken(string login)
        {
            Student entity = _context.Set<Student>().Where(x => x.Login == login).FirstOrDefault();
            if (entity == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Sprawdza czy dane logowania są poprawne
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int ProperLoginDetails(string login, string password)
        {
            Student entity = _context.Set<Student>().Where(x => x.Login == login && x.Password == password).FirstOrDefault();
            if (entity == null)
                return -1;
            else
                return entity.Id;
        }

        /// <summary>
        /// Zwraca oceny danego studenta
        /// </summary>
        /// <param name="studentsId"></param>
        /// <returns></returns>
        public List<Grade> GetStudentsGrades(int studentsId)
        {
            List<Grade> grades = _context.Set<Grade>().Where(x => x.StudentId == studentsId).ToList<Grade>();
            return grades;
        }

        /// <summary>
        /// Zwraca wiadomości danego studenta
        /// </summary>
        /// <param name="studentsId"></param>
        /// <returns></returns>
        public List<Message> GetStudentsMessages(int studentsId)
        {
            List<Message> messages = _context.Set<Message>().Where(x => x.StudentId == studentsId).ToList<Message>();
            return messages;
        }

        /// <summary>
        /// Dodanie nowego rekordu
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        /// <summary>
        /// Usunięcie rekordu
        /// </summary>
        /// <param name="id"></param>
        public void DeleteById(int id)
        {
            T entities = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entities);
        }

        /// <summary>
        /// Pobranie Query z bazy
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Get()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pobranie wszystkich danych z tabeli
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        /// <summary>
        /// Pobranie obiektu z bazy po Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        /// <summary>
        /// Zapisanie dkononaych zmian
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Aktualizacja danych rekordu
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            _context.Entry(entity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }

    }
}
