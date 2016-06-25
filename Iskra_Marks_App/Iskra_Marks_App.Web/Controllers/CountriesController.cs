using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Iskra_Marks_App.Data;
using Iskra_Marks_App.Models;
using Iskra_Marks_App.Web.Models;
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
                .OrderBy(x => x.Name)
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

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CountryInputModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                var country = Mapper.Map<Country>(model);
                this.Data.Countries.Add(country);
                this.Data.SaveChanges();

                return this.RedirectToAction("Index", "Countries");
            }

            return this.View(model);
        }

       
    }
}
