using Experiment.EntityFramework.Database;
using Experiment.EntityFramework.Model;
using System;
using System.Collections.Generic;

namespace Experiment.EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Book first = new Book();
            first.Name = "Dune";

            List<Page> pages = new List<Page>();
            Page page1 = new Page();
            page1.Content = "Dune 1";
            pages.Add(page1);
            Page page2 = new Page();
            page1.Content = "Dune Mesiah";
            pages.Add(page2);

            first.Pages = pages;


            BookDBContext bookDB = new BookDBContext();
            bookDB.Books.Add(first);
            //bookDB.Pages.Add(pages);

            bookDB.SaveChanges();

            Console.WriteLine("End");



        }
    }
}
