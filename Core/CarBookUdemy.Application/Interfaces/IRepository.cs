using CarBookUdemy.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GeAllAsync();
        Task<T> GeByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
