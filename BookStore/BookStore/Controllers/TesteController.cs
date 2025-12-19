using BookStore.Domain;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("teste")]    
    public class TesteController : Controller
    {
        
        public ViewResult Data(int Id)
        {

            ViewBag.Categoria = "Produtos de Limpeza";
            ViewData["Categoria"] = "Produtos de Informática";
            TempData["Categoria"] = "Produtos de Escritório";
            Session["Categoria"] = "Móveis";

            return View(Id);
        }
        public JsonResult Hello()
        {
            var author = new Author
            {
                Id = 1,
                Title = "Leandro"
            };

            return Json(author, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("Author")]
        public JsonResult Action2(Author author) 
        {
            return Json(author);
        }

        [Route("rota/{categoria:minlength(3)}")]
        public string MyRoute(string categoria)
        {
            return "Ok! Cheguei na Rota!" + categoria;
        }

        [Route("rota-alpha/{categoria:alpha:minlength(3)}")]
        public string MyRouteAlpha(string categoria)
        {
            return "Ok! Cheguei na Rota!" + categoria;
        }

        [Route("rota/estacao/{estacao:values(primavera|verao|outono|inverno)}")]
        public string MyRoute3(string estacao)
        {
            return "Ok! Estamos no!" + estacao;
        }
    }
}