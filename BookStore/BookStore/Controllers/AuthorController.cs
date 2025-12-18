using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("autores")]
    public class AuthorController : Controller
    {
        [Route("criar")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("listar")]
        public ActionResult Read()
        {
            return View();
        }

        [Route("update/{id:int}")]
        public ActionResult Update()
        {
            return View();
        }

        [Route("delete/{id:int}")]
        public ActionResult Delete()
        {
            return View(); 
        }
            
    }
}