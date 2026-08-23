using _3DFarmManager.Framework.Interfaces;
using _3DFarmManager.Model;
using _3DFarmManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFarmManager.Services
{
    public class ExpensesFixedCacheService : ICrudCache<ExpensesFixedModel>
    {
        private readonly Dictionary<long, ExpensesFixedModel> _cache = new Dictionary<long, ExpensesFixedModel>();

        public bool Contains(long id)
        {
            return _cache.ContainsKey(id);
        }

        public ExpensesFixedModel Get(long id)
        {
            return _cache[id];
        }

        public void Add(ExpensesFixedModel model)
        {
            _cache[model.Id] = model;
        }

        public void Update(ExpensesFixedModel model)
        {
            _cache[model.Id] = model;
        }

        // Implementation required by ICrudCache<ExpensesFixedModel>
        public void Save(ExpensesFixedModel model)
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
