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
<<<<<<< HEAD
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var markToEdit = this.Data.Marks
                .All()
                .FirstOrDefault(x => x.Id == id);

            if (markToEdit == null)
            {
                return this.RedirectToAction("Index", "Home");
            }

            var model = new MarkInputModel
            {
                Name = markToEdit.Name,
                ExpirationDate = markToEdit.ExpirationDate,
                Number = markToEdit.Number,
                Notes = markToEdit.Notes,
                CountryId = markToEdit.CountryId,
                OwnerId = markToEdit.OwnerId
            };

            this.LoadCountries();
            this.LoadOwners();

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MarkInputModel model)
        {
            var markToEdit = this.Data.Marks
                .All()
                .FirstOrDefault(x => x.Id == id);

            if (markToEdit == null)
            {
                return this.RedirectToAction("Index", "Home");
            }

            if (model != null && this.ModelState.IsValid)
            {
                markToEdit.Name = model.Name;
                markToEdit.Number = model.Number;
                markToEdit.Notes = model.Notes;
                markToEdit.ExpirationDate = model.ExpirationDate;
                markToEdit.CountryId = model.CountryId;
                markToEdit.OwnerId = model.OwnerId;

                this.Data.SaveChanges();
                return this.RedirectToAction("Details", new { id = markToEdit.Id });
            }

            return this.View(model);
        }
=======

        }

        //public ActionResult ByName()
        //{
        //    var marks = this.Data
        //        .Marks
        //        .All()
        //        .Where(x )
        //        .OrderBy(x => x.ExpirationDate)
        //        .Select(MarkViewModel.ViewModel);
        //    ;

        //    return View(marks);
        //}
>>>>>>> 02425e5f798bdde4cdec120ea93ea85095f428ab

        private void LoadCountries()
        {
            this.ViewBag.Countries = this.Data.Countries
                .All()
                .OrderBy(x => x.Name)
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
                .OrderBy(x => x.Name)
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name,
                });
        }
    }
<<<<<<< HEAD
}



//public ActionResult ByName()
//{
//    var marks = this.Data
//        .Marks
//        .All()
//        .Where(x )
//        .OrderBy(x => x.ExpirationDate)
//        .Select(MarkViewModel.ViewModel);
//    ;

//    return View(marks);
//}
=======
}
>>>>>>> 02425e5f798bdde4cdec120ea93ea85095f428ab
