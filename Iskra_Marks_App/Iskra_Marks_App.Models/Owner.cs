
using System.Collections.Generic;

namespace Iskra_Marks_App.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Owner
    {
        private ICollection<Mark> marks;

        public Owner()
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
