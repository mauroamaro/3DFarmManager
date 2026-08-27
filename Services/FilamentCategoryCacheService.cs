using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Services
{
    internal class FilamentCategoryCacheService : ICrudCache<FilamentCategoryModel>
    {

        private readonly Dictionary<long, FilamentCategoryModel> _cache = new Dictionary<long, FilamentCategoryModel>();

        public bool Contains(long id)
        {
            return _cache.ContainsKey(id);
        }

        public FilamentCategoryModel Get(long id)
        {
            return _cache[id];
        }

        public void Add(FilamentCategoryModel model)
        {
            _cache[model.Id] = model;
        }
        public void Update(FilamentCategoryModel model)
        {
            _cache[model.Id] = model;
        }
        public void Save(FilamentCategoryModel model)
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
