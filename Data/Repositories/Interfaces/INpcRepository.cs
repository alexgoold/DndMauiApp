using DndMauiApp.Data.Models;
using MongoDB.Bson;

namespace DndMauiApp.Data.Repositories.Interfaces;

public interface INpcRepository:IRepository<Npc>
{
	public Task<Npc> GetAsync(ObjectId id);
}