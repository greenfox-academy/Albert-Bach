﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Reddit.Controllers
{
    public class RedditController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
