using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using hjemmeside2.Models.Entities;
using hjemmeside2.Models.Repositories;
using hjemmeside2.Models;

namespace hjemmeside2.Models.Repositories
{
    public class InMenTodoRepository : ITodoRepository
    {     
      
       private MyDbContext _db;
        private DbSet<TodoItem> _TodoItem;
      //  List<TodoItem> todoList;

    
        public InMenTodoRepository(MyDbContext db)
        {
            _db = db;
            _TodoItem = db.todoitems;   
        }

        public void Delete(int id)
        {
            var itemx = _TodoItem.Find(id);
           _db.todoitems.Remove(itemx);
           _db.SaveChanges();
        }

        public TodoItem Get(int id)
        {
            return _TodoItem.Find(id);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _TodoItem;
        }

        public void Save(TodoItem todo)
        {
            _db.Add(todo);
            _db.SaveChanges();
        }

        public void Update(TodoItem todo)
        {
            _db.Update(todo);
            _db.SaveChanges();
        }
    }
}
