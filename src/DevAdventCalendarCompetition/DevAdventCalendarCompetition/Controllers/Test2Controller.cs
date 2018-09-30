﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DevAdventCalendarCompetition.Models;
using DevAdventCalendarCompetition.Data;

namespace DevAdventCalendarCompetition.Controllers
{
    public class Test2Controller : BaseTestController
    {
        public Test2Controller(ApplicationDbContext context) : base(context)
        {
        }

        [CanStartTest(TestNumber = 2)]
        public ActionResult Index()
        {
            var test = _context.Set<Test>().First(el => el.Number == 2);
            return View(test);
        }

        [HttpPost]
        [CanStartTest(TestNumber = 2)]
        public ActionResult Index(string answer = "")
        {
            var fixedAnswer = answer.ToUpper().Replace(" ", "");

            if (fixedAnswer != "ANVQOFUHUFKUESDQMF")
            {
                ModelState.AddModelError("", "Answer is not correct. Try again.");
                var test = _context.Set<Test>().First(el => el.Number == 2);
                return View("Index",test);
            }

            return SaveAnswerAndRedirect(2);
        }
    }
}