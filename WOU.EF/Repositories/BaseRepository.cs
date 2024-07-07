using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOU.Core.Interfaces;

namespace WOU.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            
        }

        public void Delete(T entity)
        {
            T deleted = entity;
            _context.Remove(entity);
            
            

        }

        //public IEnumerable<T> GetAll()
        //{
        //    return _context.Set<T>().ToList();
        //}

        //public T GetById(int id)
        //{
        //    return _context.Set<T>().Find(id);
        //}

        public void Update(T entity)
        {
            _context.Update(entity);
            
        }
    }
}
