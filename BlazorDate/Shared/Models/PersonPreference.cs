﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorDate.Shared.Models
{
    public class PersonPreference
    {
        public int Id { get; set; }
        [NotMapped]
        public Person? Person { get; set; }
        public Preference? Preference { get; set; }
        public Seriousness? Seriousness { get; set; }
        public bool IsVisible { get; set; } = true;
    }
}
