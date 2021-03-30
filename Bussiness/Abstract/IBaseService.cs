using Core.Entities;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBaseService<T> where T:IEntity
    {
        IDataResult<List<T>> GetAll();

        IDataResult<T> GetById(int id);

        IResult Add(T entity);

        IResult Update(T entity);

        IResult Delete(T entity);
    }
}
