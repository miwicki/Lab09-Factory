using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class Degree : Page
    {
        public string SchoolName { get; set; } = "School";
        public string DegreeLevel { get; set; } = "Degree";
        public string Major { get; set; } = "Major";

        public Education(int pageNumber)
        {
            PageNumber = pageNumber;
        }

        public override void Print()
        {
            Console.WriteLine($"Degree: Page {PageNumber}");
            Console.WriteLine(SchoolName);
            Console.WriteLine(DegreeLevel);
            Console.WriteLine("Major: " + Major);
           
        }

        
    }
}