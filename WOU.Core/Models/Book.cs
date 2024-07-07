using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOU.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateOnly RealseDate { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; } = null!;
    }
}
