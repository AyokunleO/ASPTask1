using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTask1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }
        public string Publication { get; set; }
        public string ImageUrl { get; set; }
        public bool Borrow { get; set; } = false;
    }
}
