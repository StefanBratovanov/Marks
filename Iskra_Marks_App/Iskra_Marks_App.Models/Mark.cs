
using System;

namespace Iskra_Marks_App.Models
{
    public class Mark
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string Notes { get; set; }

        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
