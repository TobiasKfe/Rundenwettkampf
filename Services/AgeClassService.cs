using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rundenwettkampf.Data;
using Rundenwettkampf.Models;
using Rundenwettkampf.utils;

namespace Rundenwettkampf.Services
{
    internal class AgeClassService
    {
        private readonly AppDbContext _db;

        public AgeClassService(AppDbContext db)
        {
            _db = db;
            _db.Database.EnsureCreated();
        }

        public List<AgeClass> GetAll() => _db.AgeClasses.ToList();

        public void Add(AgeClass ageClass)
        {
            _db.AgeClasses.Add(ageClass);
            _db.SaveChanges();
        }

        public AgeClass GetByNo(int no) => _db.AgeClasses.FirstOrDefault(ac => ac.No == no);

        public void Update(AgeClass ageClass) 
        {
            _db.AgeClasses.Update(ageClass);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var ageClass = _db.AgeClasses.Find(id);
            if (ageClass != null)
            {
                ageClass.Title = "-";
                ageClass.MinAge = 0;
                ageClass.MaxAge = 0;
                ageClass.Type = AgeClassType.None;
                Update(ageClass);
            }
        }
    }
}
