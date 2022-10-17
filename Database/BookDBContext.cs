using Experiment.EntityFramework.Model;
using System.Data.Entity;

namespace Experiment.EntityFramework.Database
{
    public class BookDBContext : DbContext
    {
        public BookDBContext() : base() {
            string conection = @"Server=localhost\SQLEXPRESS01;Database=BooksDB_CF;Trusted_Connection=True;";
            this.Database.Connection.ConnectionString = conection;

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}
