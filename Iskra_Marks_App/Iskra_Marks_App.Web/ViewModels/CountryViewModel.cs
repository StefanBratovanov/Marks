using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Iskra_Marks_App.Common.Mappings;
using Iskra_Marks_App.Models;

namespace Iskra_Marks_App.Web.ViewModels
{
    public class CountryViewModel : IMapFrom<Country>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static Expression<Func<Country, CountryViewModel>> ViewModel
        {
            get
            {
                return c => new CountryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                };
            }
        }
    }
}