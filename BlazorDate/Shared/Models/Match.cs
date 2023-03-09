using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBlazor.Shared.Models
{
    public class Match
    {
        public int Id { get; set; }

        public Person? MatchLikedPerson { get; set; }

        public Person? MatchLikee { get; set; } //Who like this person

        public DateTime MatchDate { get; set; } = DateTime.Now;
        public Chat? Chat { get; set; }
    }
}
