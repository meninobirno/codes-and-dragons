using CodesAndDragons.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodesAndDragons.Domain.Interfaces
{
    public interface IDiceRepository
    {
        Task<string> RollDice(Dices dice, int rolls);
    }
}
