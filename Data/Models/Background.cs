using MongoDB.Bson.Serialization.Attributes;

namespace DndMauiApp.Data.Models;

public class Background
{
	[BsonElement]
	public string Name { get; set; } = string.Empty;
	[BsonElement]
	public string Description { get; set; } = string.Empty;
	[BsonElement]
	public string SkillProficiencies { get; set; } = string.Empty;
	[BsonElement]
	public string ToolProficiencies { get; set; } = string.Empty;
	[BsonElement]
	public string Languages { get; set; } = string.Empty;
	[BsonElement]
	public string Equipment { get; set; } = string.Empty;

}