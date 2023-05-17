using DndMauiApp.Data.Models;
using Newtonsoft.Json;

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
				return JsonConvert.DeserializeObject<List<CharacterModel>>(content);
			}
			else
			{
				return new List<CharacterModel>();
			}
		}
	}
}