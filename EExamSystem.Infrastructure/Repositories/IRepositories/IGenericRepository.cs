﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Infrastructure.Repositories.IRepositories
{
    public interface IGenericRepository<TEntity, Tkey> where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Remove(TEntity entity);
        public TEntity Update(TEntity entity);


        TEntity? GetById(Tkey id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
