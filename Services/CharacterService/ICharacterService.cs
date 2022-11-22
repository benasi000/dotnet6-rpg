using NET_6_WEB_API.DTO.Character;

namespace dotnet6_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);

        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);

    }
}