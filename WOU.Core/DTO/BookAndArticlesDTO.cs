using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOU.Core.DTO
{
    public class BookAndArticlesDTO
    {
        public IEnumerable<BookDTO> Books { get; set; }
        public IEnumerable<ArticleDTO> Articles {get; set; }
    }
}
