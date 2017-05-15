using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using hjemmeside2.Models.Entities;


namespace hjemmeside2.Models.ViewModel
{   
        public class BLogViewModdel
        {
            public BlogPost blogPost {get; set;}

            public IEnumerable<BlogPost> blogs { get; set; }

        }
}