using System.ComponentModel.DataAnnotations;

namespace AppMVC_CRUD_AngularJS.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
    }
}