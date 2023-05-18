using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndMauiApp.Data.Models;
using DndMauiApp.Data.Repositories.Interfaces;
using MongoDB.Driver;

namespace DndMauiApp.Data.Repositories
{
	public class NamesRepository : INamesRepository
	{
		private readonly IMongoCollection<NameModel> _names;

		public NamesRepository()
		{
			var databaseName = "DndMauiApp";
			var port = 27017;
			var settings = MongoClientSettings.FromConnectionString("mongodb+srv://mongo:mongo123@cluster0.t4yoico.mongodb.net/test");
			var client = new MongoClient(settings);
			var database = client.GetDatabase(databaseName);
			_names =
				database.GetCollection<NameModel>("Names",
					new MongoCollectionSettings() { AssignIdOnInsert = true });
		}

		public async Task<NameModel> GetAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<NameModel>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<NameModel> AddAsync(NameModel entity)
		{
			await _names.InsertOneAsync(entity);
			return entity;
		}

		public async Task<NameModel> UpdateAsync(NameModel entity)
		{
			throw new NotImplementedException();
		}

		public async Task<NameModel> DeleteAsync(NameModel entity)
		{
			throw new NotImplementedException();
		}
	}
}
