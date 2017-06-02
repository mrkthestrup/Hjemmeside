using System;
using System.Collections.Generic;
using hjemmeside2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace hjemmeside2.Models.Repositories
{
    public class ArticelRepostory : IArticelRepository
    {
        private MyDbContext _db;
        private DbSet<Articel> _articel;

        public ArticelRepostory(MyDbContext db)
        {
            _db = db;
            _articel = db.Articels;
        }

        public void Create(Articel al)
        {
            _db.Articels.Add(al);
            _db.SaveChanges();
        }

        public void Delete(Articel al)
        {
            Articel articel = _db.Articels.Find(al.ArticelID);
            _db.Articels.Remove(articel);
            _db.SaveChanges();
        }

        public Articel Get(int id)
        {
            Articel al = _db.Articels.Find(id);
            return al;
        }

        public IEnumerable<Articel> GetAll()
        {
            IEnumerable<Articel> al = _articel;
            return al;
        }

        public void Update(Articel al)
        {
            _db.Articels.Update(al);
            _db.SaveChanges();
        }
    }
}