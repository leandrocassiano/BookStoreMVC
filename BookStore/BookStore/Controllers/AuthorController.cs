using BookStore.Domain;
using BookStore.Filters;
using BookStore.Repositories;
using BookStore.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("autores")]
    //[LogActionFilter()]
    public class AuthorController : Controller
    {
        private IAuthorRepository _authorRepository;
        public AuthorController()
        {
            _authorRepository = new AuthorRepository();
        }

        [Route("criar")]
        public ActionResult Create()
        {
            return View();
        }        

        [Route("listar")]
        public ActionResult Index()
        {
            return View(_authorRepository.Get());
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(Author author)
        {
            if (_authorRepository.Create(author))
                return RedirectToAction("Index");

            return View(author);
        }

        [Route("update/{id:int}")]
        public ActionResult Update(int id)
        {
            var author = _authorRepository.Get(id);
            return View(author);
        }

        [Route("update/{id:int}")]
        [HttpPost]
        public ActionResult Update(Author author)
        {

            if (_authorRepository.Update(author))
                return RedirectToAction("Index");

            return View(author);
        }

        [Route("delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            var author = _authorRepository.Get(id);
            return View(author);
        }

        [Route("delete/{id:int}")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            _authorRepository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}