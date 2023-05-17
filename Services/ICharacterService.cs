using DndMauiApp.Data.Models;

namespace DndMauiApp.Services;

public interface ICharacterService
{
	Task<List<CharacterModel>> GetCharacterListAsync();
}