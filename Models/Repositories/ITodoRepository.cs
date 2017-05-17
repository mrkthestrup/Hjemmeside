using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hjemmeside2.Models.Entities;

namespace hjemmeside2.Models.Repositories
{
   public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetAll();
        
        TodoItem Get(int id);

        void Save(TodoItem TodoItem);

        void Delete(int id);
        
        void Update(TodoItem TodoItem);
    }
}
