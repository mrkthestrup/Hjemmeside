using System.Collections.Generic;
using hjemmeside2.Models.Entities;

namespace hjemmeside2.Models.Repositories
{
    public interface IBlogPostRepository
    {
        //Basic CRUD operationer

        IEnumerable<BlogPost> GetAll();

        void Create(BlogPost post);

        void Delete(int id);

      
    }
}