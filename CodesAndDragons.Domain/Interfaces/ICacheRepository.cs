using CodesAndDragons.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodesAndDragons.Domain.Interfaces
{
    public interface ICacheRepository
    {
        Task<List<Player>> GetCacheList();
        Task<bool> AddNewPlayer(Player player);
    }
}
