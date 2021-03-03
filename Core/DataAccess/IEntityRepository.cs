using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{

    // Generic Constraint // generic kısıtlama
    // class : referans tip olsun
    //IEntity: IEntity olabilir yada IEntity iplemente eden bir nesne olabilir
    // new(): new'lenebilir olması gerekiyor , interface ler newlenemez

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        //Interface metotları default u public tir yazmaya gerek olmaz 

        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}

