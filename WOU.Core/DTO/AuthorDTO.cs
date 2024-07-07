using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOU.Core.DTO
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateOnly Lastseen { get; set; }
    }
}
