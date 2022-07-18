using eTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace eTicket.Data.Base
{
    //class means that the T should be a class and not a value type or a struct.
    //new () indicates that the T class should have a public parameter-free default constructor defined.
    public interface IEntityBaseRepository <T> where T : class , IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includePropeties);
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
