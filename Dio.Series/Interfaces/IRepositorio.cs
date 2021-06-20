using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> List();

        T ReturnByID(int id);

        void Add(T entity);
        void Update(int id,T entity);
        void Delete(int id);

        int NextId();
    }
}
