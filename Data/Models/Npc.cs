using DndMauiApp.Data.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DndMauiApp.Data.Models;

public class Npc
{
	[BsonId]
	public ObjectId Id { get; set; }

	[BsonElement]
	public string FirstName { get; set; }

	[BsonElement]
	public string LastName { get; set; }

	[BsonElement]
	public Race Race { get; set; }

	[BsonElement]
	public Alignment Alignment { get; set; }

	[BsonElement]
	public Disposition Disposition { get; set; }

	[BsonElement]
	public Profession Profession { get; set; }

	[BsonElement]
	public EconomicStatus EconomicStatus { get; set; }

	[BsonElement]
	public int Age { get; set; }

	[BsonElement]
	public string Description { get; set; }

	[BsonElement]
	public string Notes { get; set; }
	
}