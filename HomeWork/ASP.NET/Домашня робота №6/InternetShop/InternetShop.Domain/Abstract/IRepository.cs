﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InternetShop.Domain.Abstract
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        IQueryable<T> GetAllAsync();
        T Get(int id);
        Task<T> GetAsync(int id);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAsync(Expression<Func<T, bool>> predicate);
        void CreateOrUpdate(T entity);
        Task CreateOrUpdateAsync(T entity);
        Task<T> AddAsync(T entity);
        void Delete(T entity);
        Task<T> DeleteAsync(T entity);
    }
}