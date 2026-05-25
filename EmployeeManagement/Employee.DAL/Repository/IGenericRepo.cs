using Employee.DAL.DTOs;
using Employee.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.DAL.Repository
{
    public interface IGenericRepo<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}
