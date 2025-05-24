using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rundenwettkampf.Data;
using Rundenwettkampf.Models;

namespace Rundenwettkampf.Services
{
    internal class ClubService
    {
        private readonly AppDbContext _db;

        public ClubService(AppDbContext db)
        {
            _db = db;
            _db.Database.EnsureCreated();
        }

        public List<Club> GetAll() => _db.Clubs.ToList();

        public void Add(Club club)
        {
            _db.Clubs.Add(club);
            _db.SaveChanges();
        }

        public Club GetByNo(int no) => _db.Clubs.FirstOrDefault(c => c.No == no);

        public void Update(Club club)
        {
            _db.Clubs.Update(club);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var club = _db.Clubs.Find(id);
            if (club != null)
            {
                club.Name = "-";
                 Update(club);
            }
        }
    }
}
