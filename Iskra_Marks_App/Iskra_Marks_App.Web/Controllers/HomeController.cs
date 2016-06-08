using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Iskra_Marks_App.Data;
using Iskra_Marks_App.Models;
using Iskra_Marks_App.Web.ViewModels;
using AutoMapper.QueryableExtensions;

namespace Iskra_Marks_App.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IMarksData data)
           : base(data)
        {
        }

        public ActionResult Index()
        {
            var expDate = DateTime.Now.AddMonths(6);

            var marks = this.Data
                .Marks
                .All()
                .OrderBy(x => x.ExpirationDate)
                .Where(x => x.ExpirationDate <= expDate && x.ExpirationDate > DateTime.Now)
                .Select(MarkViewModel.ViewModel);
            ;

            return View(marks);
        }

        public ActionResult All()
        {
            var marks = this.Data
                .Marks
                .All()
                .OrderBy(x => x.ExpirationDate)
                .Select(MarkViewModel.ViewModel);
            ;

            return View(marks);
        }
    }
}