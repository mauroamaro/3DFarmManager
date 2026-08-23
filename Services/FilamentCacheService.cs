using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Models;
using System.Collections.Generic;

namespace _3DFarmManager.Services
{
    internal class FilamentCacheService : ICrudCache<FilamentModel>
    {
        private readonly Dictionary<long, FilamentModel> _cache = new Dictionary<long, FilamentModel>();

        public bool Contains(long id)
        {
            return _cache.ContainsKey(id);
        }

        public FilamentModel Get(long id)
        {
            return _cache[id];
        }

        public void Add(FilamentModel model)
        {
            _cache[model.Id] = model;
        }
        public void Update(FilamentModel model)
        {
            _cache[model.Id] = model;
        }
        public void Save(FilamentModel model)
        {
            _cache[model.Id] = model;
        }
        public void Remove(long id)
        {
            if (_cache.ContainsKey(id))
                _cache.Remove(id);
        }
        public void Clear()
        {
            _cache.Clear();
        }

    }
}
