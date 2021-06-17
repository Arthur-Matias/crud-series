using System.Collections.Generic;

namespace DIO.CrudSeries
{
    public class SeriesRepository : IRepository<Series>
    {
        private List<Series> seriesList = new List<Series>();
        public void Delete(int id)
        {
            this.seriesList[id].Delete();
        }

        public void Add(Series entity)
        {
            this.seriesList.Add(entity);
        }

        public List<Series> List()
        {
            return this.seriesList;
        }

        public int NextId()
        {
            return seriesList.Count;
        }

        public Series searchById(int id)
        {
            return seriesList[id];
        }

        public void Update(int id, Series entity)
        {
            this.seriesList[id] = entity;
        }
    }
}