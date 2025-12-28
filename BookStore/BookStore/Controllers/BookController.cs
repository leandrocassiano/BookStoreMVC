using BookStore.Context;
using BookStore.Domain;
using BookStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("livros")]
    public class BookController : Controller
    {
        //BookStoreDataContext _db = new BookStoreDataContext();

        [Route("listar")]
        public ActionResult Index()
        {
            /*
            var books = _db.Books.ToList();
            return View(books);
            */
            return View();
        }

        [Route("criar")]
        public ActionResult Create()
        {
            /*
            var categorys = _db.Categories.ToList();

            var model = new CreateBookViewModel
            {
                Title = "",
                ISBN = "",
                CategoryId = 0,
                CategoryOptions = new SelectList(categorys, "Id", "Title")
            };
            */
            return View();
        }

        [Route("editar")]
        public ActionResult Update()//int id
        {
            /*            
            var book = _db.Books.Find(id);
            _db.Entry<Book>(book).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            */
            return View();
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(UpdateBookViewModel model)
        {
            var book = new Book();

            book.Title = model.Title;
            book.ISBN = model.ISBN;
            book.ReleaseDate = model.ReleaseDate;
            book.CategoryId = model.CategoryId;
            // _db.Books.Add(book);
            // _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}