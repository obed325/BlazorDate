using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDate.Shared.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public Person? Person { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public bool IsPublic { get; set; } = true;
        public bool IsExplecit { get; set; } = false;
        public DateTime Created { get; set; } = DateTime.Now;

    }
}
