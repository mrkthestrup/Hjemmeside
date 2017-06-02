using System;
using System.Collections.Generic;

namespace hjemmeside2.Models.Entities
{
    public class Articel
    {
        public int ArticelID { get; set; }

        public string Title {get; set;}

        public string Author { get; set; }

        public string Body {get; set;}

        public DateTime Posted { get; set; }

    }
}