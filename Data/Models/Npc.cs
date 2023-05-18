using DndMauiApp.Data.Enums;

namespace DndMauiApp.Data.Models;

public class Npc
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public Race Race { get; set; }
	public Alignment Alignment { get; set; }
	public Disposition Disposition { get; set; }
	public Profession Profession { get; set; }
	public int Age { get; set; }
	public string Description { get; set; }
	public string Notes { get; set; }
	
}