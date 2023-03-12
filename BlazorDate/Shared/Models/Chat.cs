using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDate.Shared.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public ICollection<Message>? Messages { get; set; }
    }
    
}
