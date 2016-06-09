using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Iskra_Marks_App.Common.Mappings;
using Iskra_Marks_App.Models;

namespace Iskra_Marks_App.Web.ViewModels
{
    public class OwnerViewModel : IMapFrom<Owner>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static Expression<Func<Owner, OwnerViewModel>> ViewModel
        {
            get
            {
                return c => new OwnerViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                };
            }
        }
    }
}