using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rundenwettkampf.Data;
using Rundenwettkampf.Services;

namespace Rundenwettkampf;

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

		builder.Services.AddDbContext<AppDbContext>();

        builder.Services.AddSingleton<PersonService>();
        builder.Services.AddSingleton<ClubService>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
