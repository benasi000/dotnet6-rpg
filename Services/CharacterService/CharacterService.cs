using AutoMapper;
using NET_6_WEB_API.DTO.Character;

namespace dotnet6_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {        
        private static List<Character> characters = new  List<Character> {
            new Character(),
            new Character { Id = 1,  Name= "Jan" }
        };

        private readonly IMapper _mapper;
        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
        {
            var serviceRespopnse = new ServiceResponse<List<GetCharacterDTO>>();
            Character character = _mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c => c.Id) +  1;
            characters.Add(character);
            serviceRespopnse.Data = characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();

            return serviceRespopnse;
        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters()
        {
            return new ServiceResponse<List<GetCharacterDTO>> 
            {
                Data = characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList()
            };
        }

        public async Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id)
        {
            var serviceRespopnse = new ServiceResponse<GetCharacterDTO>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            serviceRespopnse.Data = _mapper.Map<GetCharacterDTO>(character);
            
            return serviceRespopnse;
        }
    }
}