using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : ISerieRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public List<Serie> GetAll()
        {
            return listaSerie;
        }

        public Serie GetById(int id)
        {
            return listaSerie[id];
        }

        public void Insert(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public void Update(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Delete(int id)
        {
            listaSerie[id].Excluir();
        }

        public int NextId()
        {
            return listaSerie.Count;
        }
    }
}
