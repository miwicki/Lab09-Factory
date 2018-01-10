using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class Degree : Page
    {
        public string SchoolName { get; set; } = "School";
        public string DegreeLevel { get; set; } = "Degree";
        public DateTime GraduationDate { get; set; } = new DateTime(2008, 12, 15);
        public string Major { get; set; } = "Major";

        public Education(int pageNumber)
        {
            PageNumber = pageNumber;
        }

        public override void Print()
        {
            Console.WriteLine($"Work History: Page {PageNumber}");
            Console.WriteLine(SchoolName + " - " + GraduationDate.ToString());
            Console.WriteLine(DegreeLevel);
            Console.WriteLine("Major: " + Major);
           
        }

        
    }
}