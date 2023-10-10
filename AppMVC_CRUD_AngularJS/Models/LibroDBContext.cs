using System.Data.Entity;

namespace AppMVC_CRUD_AngularJS.Models
{
    public class LibroDBContext:DbContext
    {
        public DbSet<Libro> libro { get; set; }
    }
}