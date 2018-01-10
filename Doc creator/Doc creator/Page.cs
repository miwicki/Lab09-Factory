using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public abstract class Page
    {
        public string Author { get; set; } = "Author";
        public DateTime DateCreated { get; set; } = DateTime.Today;
        public DateTime DateModified { get; set; } = DateTime.Today;
        public int PageNumber { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Printing page.");
        }

    }
}