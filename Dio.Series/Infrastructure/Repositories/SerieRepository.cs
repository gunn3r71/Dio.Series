using Dio.Series.Entities;
using Dio.Series.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dio.Series.Infrastructure.Repositories
{
    public class SerieRepository : IRepositorio<Serie>
    {
        private IList<Serie> _series;

        public SerieRepository()
        {
            _series = new List<Serie>();
        }

        public void Add(Serie entity)
        {
            try
            {
                if (entity != null)
                {
                    _series.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var serie = _series.Where(x => x.GetId() == id).FirstOrDefault();
                if (serie == null)
                    throw new Exception("Cannot find a serie with id " + id);
                _series[id].Delete();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Serie> List()
        {
            return _series.ToList();
        }

        public int NextId()
        {
            return _series.Count;
        }

        public Serie ReturnByID(int id)
        {
            return _series.Where(x => x.GetId() == id).FirstOrDefault();
        }

        public void Update(int id, Serie entity)
        {
            try
            {
                var serie = _series.Where(x => x.GetId() == id).FirstOrDefault();
                if (serie != null)
                {
                    _series[id] = entity;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
