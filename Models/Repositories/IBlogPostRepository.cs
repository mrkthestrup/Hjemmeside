using System.Collections.Generic;

namespace hjemmeside2.Models.Repositories
{
    public interface IBlogPostRepository
    {
        //Basic CRUD operationer

        IEnumerable<BlogPost> GetAll();

        void Create(BlogPost post);

      
    }
}