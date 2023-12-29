using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IAppUserService _appUserService;

        public CommentController(ICommentService commentService, IAppUserService appUserService)
        {
            _commentService = commentService;
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var values = _commentService.TGetListCommentWithDestination();
            foreach(var comment in values)
            {
                comment.AppUser = _appUserService.TGetByID(comment.AppUserId);
                comment.CommentUser = comment.AppUser.Name;
            }
            return View(values);
        }

        public IActionResult DeleteComment(int id)

        {
            var values = _commentService.TGetByID(id);
            _commentService.TDelete(values);
            return RedirectToAction("Comment","Admin");
        }
    }
}
