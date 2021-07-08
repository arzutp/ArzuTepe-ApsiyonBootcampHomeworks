using Book_Homework1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Homework1.Controllers
{
    public class BookController : Controller
    {

        public List<BookViewModel> Books()   //kitaplar için bir liste eklendi
        {
            List<BookViewModel> books = new List<BookViewModel>();
            BookViewModel book1 = new BookViewModel();
            book1.Author = "Patrick Rothfuss";
            book1.BookName = "Rüzgarın Adı";
            book1.PublicationYear = 2007;
            books.Add(book1);

            BookViewModel book2 = new BookViewModel();
            book2.Author = "Robert Jordan";
            book2.BookName = "Dünyanın Gözü";
            book2.PublicationYear = 1990;
            books.Add(book2);

            BookViewModel book3 = new BookViewModel();
            book3.Author = "Stephen King";
            book3.BookName = "Mahşer";
            book3.PublicationYear = 1978;
            books.Add(book3);

            BookViewModel book4 = new BookViewModel();
            book4.Author = "Ursula K. Le Guin";
            book4.BookName = "Mülksüzler";
            book4.PublicationYear = 1974;
            books.Add(book4);

            BookViewModel book5 = new BookViewModel();
            book5.Author = "Ray Bradbury";
            book5.BookName = "Fahrenheit 451";
            book5.PublicationYear = 1953;
            books.Add(book5);

            return books;

        }

        public IActionResult Index(string search)
        {

            List<BookViewModel> books = Books();
            if (!String.IsNullOrEmpty(search))   //arama işlemi yapılıyor eğer bir search değeri varsa if e giriyor ve bulduğu değerleri listeliyor
            {
                return View(books.Where(x => x.BookName.Contains(search) || x.Author.Contains(search)).ToList());
            }
           // HttpContext.Session.Set<List<BookViewModel>>("books", books);
                
            return View(books);   //eğer bir searcj değeri yoksa tüm kitapları listeliyor
        }

        //user için favori kitap bilgisi eklenmedi
        
    }
}
