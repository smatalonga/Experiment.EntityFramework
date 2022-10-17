using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Experiment.EntityFramework.Model
{
    public class Book
    {
        private static int id = 100;
        public Book() {
            this.BlogId = id;
            Book.id++;
        }

        [Key]
        public int BlogId { get; set; }
        public string Name { get; set; }

        public virtual List<Page> Pages { get; set; }
    }
}
