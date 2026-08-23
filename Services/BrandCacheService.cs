using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Model;
using System.Collections.Generic;

namespace _3DFarmManager.Services
{
    internal class BrandCacheService : ICrudCache<BrandModel>
    {
        private readonly Dictionary<long, BrandModel> _cache = new Dictionary<long, BrandModel>();

        public bool Contains(long id)
        {
            return _cache.ContainsKey(id);
        }

        public BrandModel Get(long id)
        {
            return _cache[id];
        }

        public void Add(BrandModel model)
        {
            _cache[model.Id] = model;
        }
        public void Update(BrandModel model)
        {
            _cache[model.Id] = model;
        }
        public void Save(BrandModel model)
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
