using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestbookGip.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public ApplicationUser User { get; set; }
    }
}
