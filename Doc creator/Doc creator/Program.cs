using System;
using Product;
using Creator;

namespace ResumeCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume myResume = new Resume();

            foreach (Page page in myResume.Pages)
            {
                page.Print();
            }

        }
    }
}
