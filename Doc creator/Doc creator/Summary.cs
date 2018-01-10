using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class Summary : Page
    {
        public string FullName { get; set; } = "Name";
        public string Email { get; set; } = "Email";
        public string Phone { get; set; } = "Phone number";
        public string Address { get; set; } = "Address";
        public string Title { get; set; } = ".Net Full Stack Web Developer";
       

        public Summary(int pageNumber)
        {
            PageNumber = pageNumber;
        }

        public override void Print()
        {
            Console.WriteLine($"Summary: Page {PageNumber}");
            Console.Write(FullName + " - " + Email);
            Console.Write(Phone + " - " + Address);
            Console.WriteLine("");
            Console.WriteLine(Title);
            Console.WriteLine("");
        }
    }
}