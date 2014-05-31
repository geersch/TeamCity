using System.Web.Mvc;
using System.Linq;
using PeopleFinder.UI.Web.Models;

namespace PeopleFinder.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new SearchModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(SearchModel model)
        {
            using (var context = new DatabaseEntities())
            {
                var query = from person in context.People
                            where person.Lastname.Contains(model.LastName)
                            select person;
                model.People = query.ToList();
            }
            return View(model);
        }
    }
}
