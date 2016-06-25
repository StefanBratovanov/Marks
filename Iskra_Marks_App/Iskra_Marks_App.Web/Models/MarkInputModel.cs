using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Iskra_Marks_App.Common.Mappings;
using Iskra_Marks_App.Models;

namespace Iskra_Marks_App.Web.Models
{
    public class MarkInputModel : IMapTo<Mark>
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required!")]
        [StringLength(200)]
        public string Name { get; set; }

        public string Number { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Expiration Date mm/dd/yyyy")]
        public DateTime? ExpirationDate { get; set; }

        public string Notes { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Display(Name = "Owner")]
        public int OwnerId { get; set; }
    }
}
