using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Iskra_Marks_App.Data;
using Iskra_Marks_App.Models;
using Iskra_Marks_App.Web.Models;
using Iskra_Marks_App.Web.ViewModels;

namespace Iskra_Marks_App.Web.Controllers
{
    public class MarksController : BaseController
    {
        public MarksController(IMarksData data) : base(data)
        {
        }

        public ActionResult Create()
        {
            this.LoadCountries();
            this.LoadOwners();

            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MarkInputModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                var mark = Mapper.Map<Mark>(model);
                this.Data.Marks.Add(mark);
                this.Data.SaveChanges();

                return this.RedirectToAction("Details", new { id = mark.Id });
            }

            this.LoadCountries();
            this.LoadOwners();
            return this.View(model);
        }

        public ActionResult Details(int id)
        {
            var mark = this.Data.Marks
                .All()
                .Where(x => x.Id == id)
                .Select(MarkViewModel.ViewModel)
                .FirstOrDefault();

            return this.View(mark);

        }

        private void LoadCountries()
        {
            this.ViewBag.Countries = this.Data.Countries
                .All()
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name,
                });
        }

        private void LoadOwners()
        {
            this.ViewBag.Owners = this.Data.Owners
                .All()
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name,
                });
        }
    }
}