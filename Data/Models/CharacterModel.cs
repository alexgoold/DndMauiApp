using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndMauiApp.Data.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DndMauiApp.Data.Models
{
	public class CharacterModel
	{
		[BsonId] public ObjectId Id { get; set; }

		[BsonElement]
		public string Name { get; set; } = string.Empty;
		[BsonElement]
		public Race Race { get; set; }
		[BsonElement]
		public string Description { get; set; } = string.Empty;
		[BsonElement]
		public Alignment Alignment { get; set; }
		[BsonElement]
		public int Level { get; set; }
		[BsonElement] 
		public List<ClassModel> CharacterClass { get; set; }
		[BsonElement]
		public Background Background { get; set; }
		[BsonElement]
		public int Strength { get; set; }
		[BsonElement]
		public int Dexterity { get; set; }
		[BsonElement]
		public int Constitution { get; set; }
		[BsonElement]
		public int Intelligence { get; set; }
		[BsonElement]
		public int Wisdom { get; set; }
		[BsonElement]
		public int Charisma { get; set; }
		[BsonElement]
		public string SavingThrowProficiencies { get; set; } = string.Empty;
		[BsonElement]
		public int ArmourClass { get; set; }
		[BsonElement]
		public int Initiative { get; set; }
		[BsonElement]
		public int Speed { get; set; }
		[BsonElement]
		public string ArmorAndWeaponProficiencies { get; set; } = string.Empty;
		[BsonElement]
		public string SkillProficiencies { get; set; } = string.Empty;
		[BsonElement]
		public string SpellcastingAbility { get; set; } = string.Empty;
		[BsonElement]
		public string SpellSlots { get; set; } = string.Empty;
		[BsonElement]
		public string SpellsKnown { get; set; } = string.Empty;
		[BsonElement]
		public string SpellSaveDc { get; set; } = string.Empty;
		[BsonElement]
		public string SpellAttackBonus { get; set; } = string.Empty;
		[BsonElement]
		public List<string> SpellList { get; set; }
		[BsonElement]
		public List<string> Languages { get; set; }
		[BsonElement]
		public List<string> Equipment { get; set; }
		[BsonElement]
		public List<string> FeaturesAndTraits { get; set; }


		
	}
}
