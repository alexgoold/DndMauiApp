using DndMauiApp.Data.Models;
using MongoDB.Bson.IO;

namespace DndMauiApp.Services;

public class CharacterService : ICharacterService
{
	private string _baseUrl = "https://localhost";
	public async Task<List<CharacterModel>> GetCharacterListAsync()
	{
		using (var client = new HttpClient())
		{
			var response = await client.GetAsync($"{_baseUrl}/api/character");
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				return new List<CharacterModel>();
			}
			else
			{
				return new List<CharacterModel>();
			}
		}
	}
}