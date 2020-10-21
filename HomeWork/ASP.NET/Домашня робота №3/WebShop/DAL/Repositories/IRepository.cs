﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T>
    {
        int ITEMS_PER_PAGE { get;  }
        int PagesCount { get; }
        IEnumerable<T> GetAll();
        T Get(int id);
        void CreateOrUpdate(T entity);
        void Delete(T entity);
    }
}
