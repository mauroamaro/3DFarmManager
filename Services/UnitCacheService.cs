using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Models;
using System.Collections.Generic;

namespace _3DFarmManager.Services
{
    internal class UnitCacheService : ICrudCache<UnitModel>
    {
        private readonly Dictionary<long, UnitModel> _cache = new Dictionary<long, UnitModel>();

        public bool Contains(long id)
        {
            return _cache.ContainsKey(id);
        }

        public UnitModel Get(long id)
        {
            return _cache[id];
        }

        public void Add(UnitModel model)
        {
            _cache[model.Id] = model;
        }
        public void Update(UnitModel model)
        {
            _cache[model.Id] = model;
        }
        public void Save(UnitModel model)
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
