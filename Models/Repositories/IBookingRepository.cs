using System.Collections.Generic;

namespace hjemmeside2.Models.Repositories
{
    public interface IBookingRepository
    {
        //Basic CRUD operationer

        IEnumerable<Booking> GetAll();

        Booking Get(int id);

        void Delete(Booking id);

        void Create(Booking bk);

        void Update(Booking bk);
    }
}