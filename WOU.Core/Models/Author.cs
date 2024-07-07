using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOU.Core.Models
{
    public class Author
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateOnly LastSeen { get; set; }
        public ICollection<Book>? Books { get; set; }
        public ICollection<Article>? Articles { get; set; }

    }
}
