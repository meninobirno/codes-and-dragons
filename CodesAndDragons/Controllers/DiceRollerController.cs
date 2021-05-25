using CodesAndDragons.Domain.Interfaces;
using CodesAndDragons.Domain.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CodesAndDragons.Controllers
{
    [Route("api/dice")]
    [ApiController]
    public class DiceRollerController : ControllerBase
    {
        private readonly IDiceRepository _repository;

        public DiceRollerController(IDiceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet, Route("roll-dice/{dice}-{rolls}")]
        public async Task<string> Get(int dice, int rolls)
        {
            return await _repository.RollDice((Dices)dice, rolls);
        }
    }
}
