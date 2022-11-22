using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NET_6_WEB_API.DTO.Character;

namespace NET_6_WEB_API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDTO>();

            CreateMap<AddCharacterDTO, Character>();
        }
    }
}