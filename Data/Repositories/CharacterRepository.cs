using DndMauiApp.Data.Models;
using DndMauiApp.Data.Repositories.Interfaces;
using MongoDB.Driver;

namespace DndMauiApp.Data.Repositories;

public class CharacterRepository : ICharacterRepository
{
	private readonly IMongoCollection<CharacterModel> _characters;

	public CharacterRepository()
	{
		var databaseName = "DndMauiApp";
		var port = 27017;
		var settings = MongoClientSettings.FromConnectionString("mongodb+srv://mongo:mongo123@cluster0.t4yoico.mongodb.net/test");
		var client = new MongoClient(settings);
		var database = client.GetDatabase(databaseName);
		_characters =
			database.GetCollection<CharacterModel>("Characters",
				new MongoCollectionSettings() { AssignIdOnInsert = true });
	}


	public async Task<CharacterModel> GetAsync(Guid id)
	{
		throw new NotImplementedException();
	}

	public async Task<IEnumerable<CharacterModel>> GetAllAsync()
	{
		var filter = Builders<CharacterModel>.Filter.Empty;
		var result = await _characters.Find(filter).ToListAsync();
		if (result == null)
		{
			result = new List<CharacterModel>();
		}
		return result;
	}

	public async Task<CharacterModel> AddAsync(CharacterModel entity)
	{
		await _characters.InsertOneAsync(entity);
		return entity;
	}

	public async Task<CharacterModel> UpdateAsync(CharacterModel entity)
	{
		await _characters.ReplaceOneAsync(x => x.Id == entity.Id, entity);
		return entity;
	}

	public async Task<CharacterModel> DeleteAsync(CharacterModel entity)
	{
		await _characters.DeleteOneAsync(x => x.Id == entity.Id);
		return entity;

	}
}