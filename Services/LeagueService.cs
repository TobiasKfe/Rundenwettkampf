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
    internal class LeagueService
    {
        private readonly AppDbContext _db;

        public LeagueService(AppDbContext db)
        {
            _db = db;
            _db.Database.EnsureCreated();
        }

        public List<League> GetAll() => _db.Leagues.ToList();

        public void Add(League league)
        {
            _db.Leagues.Add(league);
            _db.SaveChanges();
        }

        public League GetByNo(int no) => _db.Leagues.FirstOrDefault(ac => ac.No == no);

        public void Update(League league)
        {
            _db.Leagues.Update(league);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var league = _db.Leagues.Find(id);
            if (league != null)
            {
                league.Title = "-";
                league.ShortTitle = "-";
                Update(league);
            }
        }
    }
}
