using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class CoverLetter : Page
    {
        public string AddressedTo { get; set; } = "Recipient";
        public string BodyText { get; set; } = "Body";
        public string Signature { get; set; } = "Author";

        public CoverLetter(int pageNumber)
        {
            PageNumber = pageNumber;
        }

        public override void Print()
        {
            Console.WriteLine($"Cover Letter: Page {PageNumber} ");
            Console.WriteLine("Dear: " + AddressedTo);
            Console.WriteLine(BodyText);
            Console.WriteLine("Sincerely, " + Signature);
            Console.WriteLine("");
        }
    }
}
