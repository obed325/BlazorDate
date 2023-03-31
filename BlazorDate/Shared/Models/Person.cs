using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDate.Shared.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        //public Role Role { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Nick { get; set; } = string.Empty;
        public string ProfileText { get; set; } = string.Empty;
        //public string Description { get; set; } = string.Empty;
        public Gender? Gender { get; set; }
        public int GenderId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime Created { get; set; } = DateTime.MinValue;
        [NotMapped]
        public bool Editing { get; set; } = false;
        [NotMapped]
        public bool IsNew { get; set; } = false;
        public DateTime LastActive { get; set; } = DateTime.MinValue;
        public DateTime Updated { get; set; } = DateTime.Now;
        public List<Picture>? Pictures { get; set; }
        public virtual List<PersonPreference>? Preferences { get; set; }
        

        [ForeignKey("MatchLikedPerson")]
        public ICollection<Person>? LikedPersons { get; set; }

        [ForeignKey("MatchLikee")]
        public ICollection<Person>? Likees { get; set; }//who like this person
        public List<Person>? BlockedPersons { get; set; }
        //public List<Match>? Matches { get; set; }
        public int Stats { get; set; } = 0;
    }
}
