using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Model;
using System.Collections.Generic;

namespace _3DFarmManager.Services
{
    internal class _3DPrinterCacheService : ICrudCache<_3DPrinterModel>
    {

        private readonly Dictionary<long, _3DPrinterModel> _cache = new Dictionary<long, _3DPrinterModel>();

        public bool Contains(long id)
        {
            return _cache.ContainsKey(id);
        }

        public _3DPrinterModel Get(long id)
        {
            return _cache[id];
        }

        public void Add(_3DPrinterModel model)
        {
            _cache[model.Id] = model;
        }
        public void Update(_3DPrinterModel model)
        {
            _cache[model.Id] = model;
        }
        public void Save(_3DPrinterModel model)
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
