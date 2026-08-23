using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Model;
using _3DFarmManager.Models;
using System.Collections.Generic;

namespace _3DFarmManager.Services
{
    internal class ColorCacheService : ICrudCache<ColorModel>
    {
        private readonly Dictionary<long, ColorModel> _cache = new Dictionary<long, ColorModel>();

        public bool Contains(long id)
        {
            return _cache.ContainsKey(id);
        }

        public ColorModel Get(long id)
        {
            return _cache[id];
        }

        public void Add(ColorModel model)
        {
            _cache[model.Id] = model;
        }
        public void Update(ColorModel model)
        {
            _cache[model.Id] = model;
        }
        public void Save(ColorModel model)
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
