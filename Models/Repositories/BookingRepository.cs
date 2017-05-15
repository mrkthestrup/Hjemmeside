using System;
using System.Collections.Generic;
using hjemmeside2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace hjemmeside2.Models.Repositories
{
    public class BookingRepository : IBookingRepository
    {

        private MyDbContext _db;
        private DbSet<Booking> _bookings;

        public BookingRepository(MyDbContext db)
        {
            _db = db;
            _bookings = db.Bookings;
        }
        public void Create(Booking bk)
        {
            _db.Bookings.Add(bk);
            _db.SaveChanges();
        }

        public void Delete(Booking bk)
        {
            Booking booking = _db.Bookings.Find(bk.ID);
            _db.Bookings.Remove(booking);
            _db.SaveChanges();
        }

        public Booking Get(int id)
        {
            Booking booking = _db.Bookings.Find(id);
            return booking;
        }

        public IEnumerable<Booking> GetAll()
        {
            IEnumerable<Booking> booking = _bookings;
            return booking;
        }

        public void Update(Booking bk)
        {
            _db.Bookings.Update(bk);
            _db.SaveChanges();
        }
    }
}