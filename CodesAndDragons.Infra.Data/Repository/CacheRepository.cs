using CodesAndDragons.Domain.Interfaces;
using CodesAndDragons.Domain.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Threading.Tasks;

namespace CodesAndDragons.Infra.Data.Repository
{
    public class CacheRepository : ICacheRepository
    {
        private readonly ObjectCache _cache = MemoryCache.Default;
        private const string _cacheKey = "charactersList";

        public Task<List<Player>> GetCacheList()
        {
            if (_cache.Contains(_cacheKey))
            {
                return Task.FromResult((List<Player>)_cache.Get(_cacheKey));
            }
            else
            {
                return Task.FromResult<List<Player>>(null);
            }
        }

        public Task<bool> AddNewPlayer(Player player)
        {
            try
            {
                List<Player> players = new List<Player>();
                CacheItemPolicy policy = new CacheItemPolicy
                {
                    AbsoluteExpiration = DateTime.Now.AddDays(30)
                };

                if (_cache.Contains(_cacheKey))
                {
                    players = (List<Player>)_cache.Get(_cacheKey);
                    players.Add(player);
                    _cache.Set(_cacheKey, players, policy);
                    return Task.FromResult(true);
                }
                else
                {
                    players.Add(player);
                    _cache.Add(_cacheKey, players, policy);
                    return Task.FromResult(true);
                }
            }
            catch (Exception e)
            {
                return Task.FromResult(false);
            }
        }
    }
}
