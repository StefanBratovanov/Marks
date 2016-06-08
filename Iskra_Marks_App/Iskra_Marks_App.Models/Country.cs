
namespace Iskra_Marks_App.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class Country
    {
        private ICollection<Mark> marks;

        public Country()
        {
            this.marks = new HashSet<Mark>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Mark> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }
    }
}
