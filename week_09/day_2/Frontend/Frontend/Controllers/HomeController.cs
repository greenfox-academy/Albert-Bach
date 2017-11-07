﻿using Frontend.Models;
using Microsoft.AspNetCore.Mvc;


namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [Route("/doubling")]
        [HttpGet]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });

        }

        [Route("/greeter")]
        [HttpGet]
        public IActionResult Greeting(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }

            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }

            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });

        }

        [Route("/appenda/{appendable}")]
        [HttpGet]
        public IActionResult AppendA(string appendable)
        {
            return Json(new { appended = $"{appendable}a" });
        }

        [Route("/appenda/")]
        [HttpGet]
        public IActionResult Append()
        {
            return NotFound();
        }

        [HttpPost]
        [Route("dountil/{what}")]
        [Route("dountil/")]
        public IActionResult DoUntil([FromBody] JsonObject jsonObject, string what)
        {
            if (what == "factor")
            {
                int factorial = 1;
                for (int i = 1; i < jsonObject.Until + 1; i++)
                {
                    factorial *= i;
                }
                return Json(new { result = factorial });
            }
            else if (what == "sum")
            {
                int sum = 0;
                for (int i = 1; i < jsonObject.Until + 1; i++)
                {
                    sum += i;
                }
                return Json(new { result = sum });
            }
            return Json(new { error = "Please provide a number!" });
        }
    }
}