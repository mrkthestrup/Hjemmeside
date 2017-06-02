using System.Collections.Generic;
using hjemmeside2.Models.Entities;

namespace hjemmeside2.Models.Repositories
{
    public interface IArticelRepository 
    {

        IEnumerable<Articel> GetAll();

        Articel Get(int id);

        void Delete(Articel id);

        void Create(Articel al);

        void Update(Articel al);
    }
}