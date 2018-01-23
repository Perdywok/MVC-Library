using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; private set; }        
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public Cover Cover { get; set; }
        public int Pages { get; set; }
    }
}