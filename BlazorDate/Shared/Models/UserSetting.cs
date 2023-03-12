using BlazorDate.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlazorDate.Shared.Models
{
    public class UserSetting
    {
        public int Id { get; set; }
        [ForeignKey("PersonId")]
        public Person Person { get; set; } //persons settings
        public List<Availability>? Availabilities { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set;}
    }
}
