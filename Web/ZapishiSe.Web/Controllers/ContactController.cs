﻿using Microsoft.AspNetCore.Mvc;

namespace ZapishiSe.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
