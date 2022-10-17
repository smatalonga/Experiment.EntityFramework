using Experiment.EntityFramework.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;



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

        protected override void OnModelCreating(DbModelBuilder modelBuilder) { 
            modelBuilder.Entity<Book>()
            .HasIndex(abook => new { abook.BookId })
            .IsUnique(true);
        }
    }
}
