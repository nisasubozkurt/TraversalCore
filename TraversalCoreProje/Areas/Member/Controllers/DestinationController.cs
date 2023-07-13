﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace TraversalCoreProje.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    public class DestinationController : Controller
    {
        DestinationManager desinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = desinationManager.TGetList();
            return View(values);
        }
    }
}
