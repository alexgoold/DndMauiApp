using DndMauiApp.Data.Models;
using DndMauiApp.Data.Repositories.Interfaces;
using MongoDB.Driver;
using System.Xml.Linq;
using MongoDB.Bson;

namespace DndMauiApp.Data.Repositories;

public class NpcRepository:INpcRepository
{

	private readonly IMongoCollection<Npc> _npcs;

	public NpcRepository()
	{
		var databaseName = "DndMauiApp";
		var settings = MongoClientSettings.FromConnectionString("mongodb+srv://mongo:mongo123@cluster0.t4yoico.mongodb.net/test");
		var client = new MongoClient(settings);
		var database = client.GetDatabase(databaseName);
		_npcs =
			database.GetCollection<Npc>("Npcs",
				new MongoCollectionSettings() { AssignIdOnInsert = true });
	}

	public async Task<Npc> GetAsync(ObjectId id)
	{
		return await _npcs.Find(x => x.Id == id).FirstOrDefaultAsync();
	}

	public async Task<Npc> GetAsync(Guid id)
	{
		throw new NotImplementedException();
	}

	public async Task<IEnumerable<Npc>> GetAllAsync()
	{
		return await _npcs.Find(x => true).ToListAsync();
	}

	public async Task<Npc> AddAsync(Npc entity)
	{
		await _npcs.InsertOneAsync(entity);
		return entity;
	}

	public async Task<Npc> UpdateAsync(Npc entity)
	{
		throw new NotImplementedException();
	}

	public async Task<Npc> DeleteAsync(Npc entity)
	{
		throw new NotImplementedException();
	}
}