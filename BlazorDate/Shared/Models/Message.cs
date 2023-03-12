using System;

namespace BlazorDate.Shared.Models
{
    public class Message
    {
        public int Id { get; set; }
        public Person? Sender { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; }
        public bool SenderDeleted { get; set; } = false;
        public bool RecipientDeleted { get; set; } = false;
    }
}
