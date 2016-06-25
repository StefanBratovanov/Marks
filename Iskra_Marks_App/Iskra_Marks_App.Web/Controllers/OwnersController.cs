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
    public class OwnersController : BaseController
    {
        public OwnersController(IMarksData data)
           : base(data)
        {
        }

        public ActionResult Index()
        {
            var owners = this.Data
                .Owners
                .All()
                .OrderBy(x => x.Name)
                .ProjectTo<OwnerViewModel>();

            return View(owners);
        }


        public ActionResult Details(int id)
        {
            var owner = this.Data.Owners
                .All()
                .Where(x => x.Id == id)
                .Select(OwnerDetailsViewModel.ViewModel)
                .FirstOrDefault();

            return this.View(owner);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OwnerInputModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                var owner = Mapper.Map<Owner>(model);
                this.Data.Owners.Add(owner);
                this.Data.SaveChanges();

                return this.RedirectToAction("Index", "Owners");
            }

            return this.View(model);
        }


    }
}