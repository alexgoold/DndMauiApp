using DndMauiApp.Data.Models;
using DndMauiApp.Data.Repositories;
using DndMauiApp.Data.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace DndMauiApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();
		builder.Services.AddScoped<ICarousalRepository, CarousalRepository>();

		var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FirstNames.txt");

		var FirstNames = File.ReadAllLines(path)
			.Select(x => x.Split('.'))
			.Select(x => new CarousalModel
			{
				Number = int.Parse(x[0]),
				Description = x[1].Remove(0, 1)
			});

		foreach (var result in FirstNames)
		{
			_namesRepository.AddAsync(result);
		}

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif


		return builder.Build();

	}
}
