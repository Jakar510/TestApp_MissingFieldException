using AiForms.Settings;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using InputKit.Handlers;
using MauiIcons.Cupertino;
using MauiIcons.Fluent;
using MauiIcons.Fluent.Filled;
using MauiIcons.FontAwesome;
using MauiIcons.FontAwesome.Brand;
using MauiIcons.FontAwesome.Solid;
using MauiIcons.Material;
using MauiIcons.Material.Outlined;
using MauiIcons.Material.Rounded;
using MauiIcons.Material.Sharp;
using MauiIcons.SegoeFluent;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using Syncfusion.Maui.Toolkit.Hosting;
using UraniumUI;
using ZXing.Net.Maui.Controls;

namespace TestApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            MauiAppBuilder builder = MauiApp.CreateBuilder();

            builder.UseMauiApp<App>();
            builder.UseMauiCommunityToolkit();
            builder.ConfigureSyncfusionToolkit();
            builder.UseMauiCommunityToolkitMarkup();
            builder.UseMauiCommunityToolkitMediaElement();
            builder.UseMauiCompatibility();
            builder.UseBarcodeReader();
            builder.UseUraniumUI();
            builder.UseUraniumUIBlurs();
            builder.UseUraniumUIMaterial();
            builder.UseUraniumUIWebComponents();
            builder.ConfigureMauiHandlers(static handlers => handlers.AddInputKitHandlers());
            builder.UseSettingsView();
            builder.UseFontAwesomeMauiIcons();
            builder.UseFontAwesomeSolidMauiIcons();
            builder.UseFontAwesomeBrandMauiIcons();
            builder.UseFluentMauiIcons();
            builder.UseFluentFilledMauiIcons();
            builder.UseMaterialMauiIcons();
            builder.UseMaterialSharpMauiIcons();
            builder.UseMaterialRoundedMauiIcons();
            builder.UseMaterialOutlinedMauiIcons();
            builder.UseCupertinoMauiIcons();
            builder.UseSegoeFluentMauiIcons();

            builder.ConfigureMauiHandlers(handlers =>
                {
#if IOS || MACCATALYST
    				handlers.AddHandler<Microsoft.Maui.Controls.CollectionView, Microsoft.Maui.Controls.Handlers.Items2.CollectionViewHandler2>();
#endif
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("SegoeUI-Semibold.ttf", "SegoeSemibold");
                    fonts.AddFont("FluentSystemIcons-Regular.ttf", FluentUI.FontFamily);
                });

#if DEBUG
            builder.Logging.AddDebug();
            builder.Services.AddLogging(configure => configure.AddDebug());
#endif

            builder.Services.AddSingleton<ProjectRepository>();
            builder.Services.AddSingleton<TaskRepository>();
            builder.Services.AddSingleton<CategoryRepository>();
            builder.Services.AddSingleton<TagRepository>();
            builder.Services.AddSingleton<SeedDataService>();
            builder.Services.AddSingleton<ModalErrorHandler>();
            builder.Services.AddSingleton<MainPageModel>();
            builder.Services.AddSingleton<ProjectListPageModel>();
            builder.Services.AddSingleton<ManageMetaPageModel>();

            builder.Services.AddTransientWithShellRoute<ProjectDetailPage, ProjectDetailPageModel>("project");
            builder.Services.AddTransientWithShellRoute<TaskDetailPage, TaskDetailPageModel>("task");

            return builder.Build();
        }
    }
}