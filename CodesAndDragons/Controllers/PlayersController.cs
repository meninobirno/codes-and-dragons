using AutoMapper;
using CodesAndDragons.Application.RequestModel;
using CodesAndDragons.Domain.Interfaces;
using CodesAndDragons.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodesAndDragons.Controllers
{
    [Route("api/player")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICacheRepository _repository;

        public PlayersController(IMapper mapper, ICacheRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet, Route("get-all-players")]
        public async Task<string> Get()
        {
            List<Player> players = await _repository.GetCacheList();

            if (players.Count > 0)
                return players.Count.ToString();
            else
                return "Sem personagens cadastrados";
        }

        [HttpGet, Route("get-player-by-id/{id}")]
        public async Task<string> Get(int id)
        {
            List<Player> players = await _repository.GetCacheList();

            if (players.Count > 0)
            {
                Player searchedPlayer = players.Find(x => x.Id == id);

                if (searchedPlayer != null)
                    return searchedPlayer.ToString();
                else
                    return "Jogador não encontrado!";
            }
            else
                return "A lista está vazia!";

        }

        [HttpPost, Route("add-new-player")]
        public async Task<IActionResult> Post([FromBody] PlayerRequest data)
        {
            Player player = _mapper.Map<Player>(data);

            var response = await _repository.AddNewPlayer(player);

            if (response)
                return Accepted();
            else
                return BadRequest();
        }
    }
}
