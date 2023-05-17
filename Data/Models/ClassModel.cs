using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DndMauiApp.Data.Models;

public class ClassModel
{
	[BsonId] public ObjectId Id { get; set; }
	[BsonElement]
	public string Name { get; set; } = string.Empty;
	[BsonElement]
	public string Subclasses { get; set; } = string.Empty;
	[BsonElement]
	public string HitDie { get; set; } = string.Empty;
}