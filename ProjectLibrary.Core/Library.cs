using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.Core
{
    public class Library
    {

        public int BookId { get; set; }
        public string Author { get; set; }
        public string BookName { get; set; }
        public Genres Genre { get; set; }
    }
}
