using OrderControll.Repos.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OrderControll.Repos
{
    public class Utility<T> where T : Entity
    {
        private List<T> Data { get; set; }

        public T GetEntity(T entity)
        {
            Data.Add(entity);
            return entity;
        }

        public T GetbyId(int id) => Data.First(x => x.Id == id);

        public void AddItem(T item) => Data.Add(item);

        public bool RemoveItem(int id) => Data.Remove(GetbyId(id));
    }
}