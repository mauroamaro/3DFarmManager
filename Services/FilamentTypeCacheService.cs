using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Models;
using System.Collections.Generic;

namespace _3DFarmManager.Services
{
    internal class FilamentTypeCacheService : ICrudCache<FilamentTypeModel>
    {

        private readonly Dictionary<long, FilamentTypeModel> _cache = new Dictionary<long, FilamentTypeModel>();

        public bool Contains(long id)
        {
            return _cache.ContainsKey(id);
        }

        public FilamentTypeModel Get(long id)
        {
            return _cache[id];
        }

        public void Add(FilamentTypeModel model)
        {
            _cache[model.Id] = model;
        }
        public void Update(FilamentTypeModel model)
        {
            _cache[model.Id] = model;
        }
        public void Save(FilamentTypeModel model)
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
