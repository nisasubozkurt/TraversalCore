using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _reservationService.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult Activate(int id)
        {
            var reservation = _reservationService.TGetByID(id);
            reservation.Status = "Onaylandı";
            _reservationService.TUpdate(reservation);
            return RedirectToAction("Reservation", "Admin");
        }

        [HttpPost]
        public IActionResult Reject(int id)
        {
            var reservation = _reservationService.TGetByID(id);
            reservation.Status = "Onaylanmadı";
            _reservationService.TUpdate(reservation);
            return RedirectToAction("Reservation", "Admin");
        }
    }
}
