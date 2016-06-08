using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using AutoMapper;
using Iskra_Marks_App.Common.Mappings;
using Iskra_Marks_App.Models;

namespace Iskra_Marks_App.Web.ViewModels
{
    public class CountryDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<MarkViewModel> Marks { get; set; }

        public static Expression<Func<Country, CountryDetailsViewModel>> ViewModel
        {
            get
            {
                return c => new CountryDetailsViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Marks = c.Marks.AsQueryable().OrderBy(x => x.ExpirationDate).Select(MarkViewModel.ViewModel)
                };
            }
        }

    }
}