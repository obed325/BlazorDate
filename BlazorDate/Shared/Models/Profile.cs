using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDate.Shared.Models
{
    public class Profile
    {
        public int Id { get; set; }

        [ForeignKey("Person")]
        public Person ProfilePerson { get; set; }
        public List<Picture>? Pictures { get; set; }
        public virtual List<PersonPreference> Preferences { get; set; }
        public string ProfileText { get; set; } = string.Empty;

    }
}
