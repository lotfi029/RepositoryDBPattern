using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOU.Core.Models;

namespace WOU.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Authors { get; }
        IArticleRepository Articles { get; }
        IBookRepository Books { get; }
        int complete();
    }
}
