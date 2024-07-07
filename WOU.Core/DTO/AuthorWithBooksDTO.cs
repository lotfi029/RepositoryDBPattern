using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOU.Core.DTO
{
    public class AuthorWithBooksDTO
    {
        public AuthorDTO authorDTO { get; set; }
        public IEnumerable<BookDTO> Books { get; set; }
    }
}
