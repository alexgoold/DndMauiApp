using DndMauiApp.Data.Models;
using DndMauiApp.Data.Repositories.Interfaces;
using MongoDB.Driver;

namespace DndMauiApp.Data.Repositories;

public class CarousalRepository :ICarousalRepository
{
	private readonly IMongoCollection<CarousalModel> _carousals;

	public CarousalRepository()
	{
		var databaseName = "DndMauiApp";
		var port = 27017;
		var settings = MongoClientSettings.FromConnectionString("mongodb+srv://mongo:mongo123@cluster0.t4yoico.mongodb.net/test");
		var client = new MongoClient(settings);
		var database = client.GetDatabase(databaseName);
		_carousals =
			database.GetCollection<CarousalModel>("Carousal",
				new MongoCollectionSettings() { AssignIdOnInsert = true });
	}



	public async Task<CarousalModel> GetAsync(Guid id)
	{
		throw new NotImplementedException();
	}

	public async Task<IEnumerable<CarousalModel>> GetAllAsync()
	{
		return await _carousals.Find(x => true).ToListAsync();
	}

	public async Task<CarousalModel> AddAsync(CarousalModel entity)
	{
		await _carousals.InsertOneAsync(entity);
		return entity;
	}

	public async Task<CarousalModel> UpdateAsync(CarousalModel entity)
	{
		throw new NotImplementedException();
	}

	public async Task<CarousalModel> DeleteAsync(CarousalModel entity)
	{
		throw new NotImplementedException();
	}
}