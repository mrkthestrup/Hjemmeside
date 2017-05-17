using System;

namespace hjemmeside2.Models.Entities
{
    public class TodoItem
    {
        public int TodoItemID { get; set; }
        public string Task { get; set; }
        public Boolean IsComplete { get; set; }
        
    }
}