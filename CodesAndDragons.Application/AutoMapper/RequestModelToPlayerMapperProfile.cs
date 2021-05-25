using AutoMapper;
using CodesAndDragons.Application.RequestModel;
using CodesAndDragons.Domain.Models;
using CodesAndDragons.Domain.Models.Enums;

namespace CodesAndDragons.Application.AutoMapper
{
    public class RequestModelToPlayerMapperProfile : Profile
    {
        public RequestModelToPlayerMapperProfile()
        {
            CreateMap<PlayerRequest, Player>()
                .ConvertUsing<PlayerRequestModelToPlayer>();
        }
    }

    public class PlayerRequestModelToPlayer : ITypeConverter<PlayerRequest, Player>
    {
        public Player Convert(PlayerRequest source, Player destination, ResolutionContext context)
        {
            var ret = new Player();

            foreach(var item in source.Data)
            {
                switch (item.Key.ToLower())
                {
                    case "nomejogador":
                        ret.PlayerName = item.Value.ToString();
                        break;

                    case "atributos":
                        ret.PlayerAttributtes = item.Value.ToString();
                        break;

                    case "nomepersonagem":
                        ret.CharName = item.Value.ToString();
                        break;

                    case "descricaopersonagem":
                        ret.CharDescription = item.Value.ToString();
                        break;

                    case "racapersonagem":
                        ret.CharRace = (Race)int.Parse(item.Value.ToString());
                        break;

                    case "vida":
                        ret.LifePoints = int.Parse(item.Value.ToString());
                        break;

                    case "classearmadura":
                        ret.ArmorClass = int.Parse(item.Value.ToString());
                        break;

                    case "id":
                        ret.Id = int.Parse(item.Value.ToString());
                        break;

                }
            }
            return ret;
        }
    }

}
