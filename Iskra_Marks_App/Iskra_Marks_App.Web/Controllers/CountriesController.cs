using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using Iskra_Marks_App.Data;
using Iskra_Marks_App.Web.ViewModels;

namespace Iskra_Marks_App.Web.Controllers
{
    public class CountriesController : BaseController
    {
        public CountriesController(IMarksData data)
           : base(data)
        {
        }

        public ActionResult Index()
        {
            var countries = this.Data
                .Countries
                .All()
                .Select(CountryViewModel.ViewModel)
            ;

            return View(countries);
        }


        public ActionResult Details(int id)
        {
            var country = this.Data.Countries
                .All()
                .Where(x => x.Id == id)
                .Select(CountryDetailsViewModel.ViewModel)
                .FirstOrDefault();

            return this.View(country);
        }
    }
}
