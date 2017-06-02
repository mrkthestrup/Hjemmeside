using System;
using System.Collections;
using System.Collections.Generic;
using hjemmeside2.Models.Entities;

namespace hjemmeside2.Models.ViewModels
{
    public class ViewArticelBlogPost 
    {

        public IEnumerable<BlogPost> blogs {get;set;}
        public IEnumerable<Articel> articels {get;set;}

 
    }
}