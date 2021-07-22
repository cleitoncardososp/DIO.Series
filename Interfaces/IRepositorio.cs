using System;
using System.Collections.Generic;
using DIO.Series.Classes;

namespace DIO.Series.Interfaces
{
    public interface ISerieRepositorio<T>
    {
        List<T> GetAll();

        T GetById(int id);

        void Insert(T objeto);

        void Delete(int id);

        void Update(int id, T objeto);

        int NextId();
    }
}