using AppMVC_CRUD_AngularJS.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace AppMVC_CRUD_AngularJS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: All books
        public JsonResult GetAllBooks()
        {
            using (LibroDBContext contextObj = new LibroDBContext())
            {
                var bookList = contextObj.libro.ToList();
                return Json(bookList, JsonRequestBehavior.AllowGet);
            }
        }
        //GET: Book by Id
        public JsonResult GetBookById(string id)
        {
            using (LibroDBContext contextObj = new LibroDBContext())
            {
                var bookId = Convert.ToInt32(id);
                var getBookById = contextObj.libro.Find(bookId);
                return Json(getBookById, JsonRequestBehavior.AllowGet);
            }
        }
        //Update Book
        public string UpdateBook(Libro book)
        {
            if (book != null)
            {
                using (LibroDBContext contextObj = new LibroDBContext())
                {
                    int bookId = Convert.ToInt32(book.Id);
                    Libro _book = contextObj.libro.Where(b => b.Id == bookId).FirstOrDefault();
                    _book.Title = book.Title;
                    _book.Author = book.Author;
                    _book.Publisher = book.Publisher;
                    _book.Isbn = book.Isbn;
                    contextObj.SaveChanges();
                    return "Libro Actualizado correctamente";
                }
            }
            else
            {
                return "Error: libro no es valido";
            }
        }
        // Add book
        public string AddBook(Libro book)
        {
            try
            {
                if (book != null)
                {
                    using (LibroDBContext contextObj = new LibroDBContext())
                    {
                        contextObj.libro.Add(book);
                        contextObj.SaveChanges();
                        return "Libro registrado correctamente";
                    }
                }
                else
                {
                    return "Error: libro no es valido";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
       
        }
        // Delete book
        public string DeleteBook(string bookId)
        {

            if (!String.IsNullOrEmpty(bookId))
            {
                try
                {
                    int _bookId = Int32.Parse(bookId);
                    using (LibroDBContext contextObj = new LibroDBContext())
                    {
                        var _book = contextObj.libro.Find(_bookId);
                        contextObj.libro.Remove(_book);
                        contextObj.SaveChanges();
                        return "Libro eliminado correctamente";
                    }
                }
                catch (Exception)
                {
                    return "Error: libro no es valido";
                }
            }
            else
            {
                return "operacion no valido";
            }
        }
    }
}