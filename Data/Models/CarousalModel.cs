﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DndMauiApp.Data.Models;

public class CarousalModel
{
	[BsonId] public ObjectId Id { get; set; }

	[BsonElement]
	public string Description { get; set; } = string.Empty;

	[BsonElement] 
	public int Number { get; set; }
}