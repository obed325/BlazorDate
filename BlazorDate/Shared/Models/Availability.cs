using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDate.Shared.Models
{
    public class Availability
    {
        public int Id { get; set; }
        public string Level { get; set; } = string.Empty;
    }
}
