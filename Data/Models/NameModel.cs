using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DndMauiApp.Data.Models
{
	public class NameModel
	{
		[BsonId]
		public ObjectId Id { get; set; }

		[BsonElement]
		public string Name { get; set; } = string.Empty;

		[BsonElement] 
		public bool IsFirstName { get; set; } = true;
		

	}
}
