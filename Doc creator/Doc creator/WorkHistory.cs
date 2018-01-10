using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class WorkHistory : Page
    {
        public string CompanyName { get; set; } = "Company";
        public string JobTitle { get; set; } = "Title";
        

        public WorkHistory(int pageNumber)
        {
            PageNumber = pageNumber;
        }

        public override void Print()
        {
            Console.WriteLine($"Work History: Page {PageNumber}");
            Console.WriteLine(CompanyName + " - " + JobTitle);
        }
    }
}