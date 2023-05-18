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
		builder.Services.AddScoped<INamesRepository, NamesRepository>();

		//var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LastNames.txt");

		//var FirstNames = File.ReadAllLines(path)
		//	.Select(x => new NameModel()
		//	{
		//		Name = x,
		//		IsFirstName = false
		//	});

		//foreach (var result in FirstNames)
		//{
		//	_namesRepository.AddAsync(result);
		//}

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif


		return builder.Build();

	}
}
