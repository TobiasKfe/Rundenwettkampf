using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rundenwettkampf.Data;
using Rundenwettkampf.Models;

namespace Rundenwettkampf.Services
{
    internal class PersonService
    {
        private readonly AppDbContext _db;

        public PersonService(AppDbContext db)
        {
            _db = db;
            _db.Database.EnsureCreated();
        }

        public List<Person> GetAll() => _db.Persons.ToList();

        public void Add(Person person)
        {
            _db.Persons.Add(person);
            _db.SaveChanges();
        }

        public Person GetByStartNo(int startNo) => _db.Persons.FirstOrDefault(p => p.StartNo == startNo);

        public void Update(Person person)
        {
            _db.Persons.Update(person);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var person = _db.Persons.Find(id);
            if (person != null)
            {
                person.Gender = "-";
                person.Handicap = "-";
                person.FirstName = "-";
                person.LastName = "-";
                person.BirthDate = DateTime.MinValue;
                Update(person);
            }
        }
    }
}
