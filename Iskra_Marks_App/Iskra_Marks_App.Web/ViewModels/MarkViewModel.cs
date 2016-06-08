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
    public class MarkViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string Notes { get; set; }

        public string Owner { get; set; }

        public string Country { get; set; }

        public static Expression<Func<Mark, MarkViewModel>> ViewModel
        {
            get
            {
                return m => new MarkViewModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    ExpirationDate = m.ExpirationDate,
                    Notes = m.Notes,
                    Owner = m.Owner.Name,
                    Country = m.Country.Name,
                    Number = m.Number
                };
            }
        }
    }
}