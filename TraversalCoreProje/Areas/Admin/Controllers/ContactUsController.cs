using BusinessLayer.Abstarct;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var values = _contactUsService.TGetListContactUsByTrue();
            return View(values);
        }
        public IActionResult Details(int id)
        {
            var values = _contactUsService.TGetByID(id);
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var contactUs = _contactUsService.TGetByID(id);
            _contactUsService.TDelete(contactUs);
            return RedirectToAction("ContactUs", "Admin");
        }
    }
}
