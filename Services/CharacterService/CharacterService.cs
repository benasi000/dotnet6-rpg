namespace dotnet6_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {        
        private static List<Character> characters = new  List<Character> {
            new Character(),
            new Character { Id = 1,  Name= "Jan" }
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceRespopnse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceRespopnse.Data = characters;

            return serviceRespopnse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            return new ServiceResponse<List<Character>> {Data = characters};
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceRespopnse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            serviceRespopnse.Data = character;
            
            return serviceRespopnse;
        }
    }
}