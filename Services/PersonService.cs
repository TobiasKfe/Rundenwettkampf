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
            _db.Database.EnsureCreated(); // Erstellt DB beim ersten Zugriff
        }

        public List<Person> GetAll() => _db.Persons.ToList();

        public void Add(Person person)
        {
            _db.Persons.Add(person);
            _db.SaveChanges();
        }
    }
}
