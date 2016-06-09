using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Iskra_Marks_App.Common.Mappings;
using Iskra_Marks_App.Models;

namespace Iskra_Marks_App.Web.Models
{
    public class CountryInputModel : IMapTo<Country>
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required!")]
        [StringLength(200)]
        [Display(Name = "Country Name")]
        public string Name { get; set; }
    }
}