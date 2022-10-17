using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Experiment.EntityFramework.Model
{
    public class Book
    {
       
        public Book() {
           
        }

        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }

        public virtual List<Page> Pages { get; set; }
    }
}
