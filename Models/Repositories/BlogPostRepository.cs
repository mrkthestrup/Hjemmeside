using System;
using System.Collections.Generic;
using hjemmeside2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace hjemmeside2.Models.Repositories
{
    public class BlogRepository : IBlogPostRepository
    {
        private MyDbContext _db;

        private DbSet<BlogPost> _blogs;

        public BlogRepository(MyDbContext db)
        {
            _db = db;
            _blogs = db.Blogs;
        }
        public void Create(BlogPost post)
        {
            _db.Blogs.Add(post);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}