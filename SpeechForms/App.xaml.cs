using Microsoft.Extensions.DependencyInjection;
using SpeechForms.Services;
using SpeechForms.ViewModels;
using SpeechForms.Views;
using SpeechSynthesis;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;

namespace SpeechForms
{
    public partial class App : Application
    {
        private static IServiceProvider? _Services;
        public App()
        {
            //StyleManager.ApplicationTheme = new Windows11Theme(Windows11Palette.ColorVariation.Dark);
            try
            {
                PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Critical;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static IServiceProvider Services => _Services ??= InitializeServices().BuildServiceProvider();

        private static IServiceCollection InitializeServices()
        {
            ServiceCollection services = new ServiceCollection();

            #region Views
            services.AddSingleton<MainWindow>();
            services.AddSingleton<WindowDialogServices>();
            services.AddSingleton<SpeechRecognizerService>();

          

            services.AddSingleton<SpeechText>();
            #endregion

            #region VM
            services.AddSingleton<MainVM>();
            #endregion

            #region AddTransient

            
            services.AddScoped(
                s =>
                {
                    var dataContext = s.GetService<MainVM>();
                  

                    //TODO Model From DATA CONTEXT
                    MainWindow window = new MainWindow
                    {
                        /* DataContext = model*/
                        DataContext = dataContext
                    };

                    return window;
                });


            #endregion






            return services;
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Services.GetRequiredService<WindowDialogServices>().OpenMainWindow();
            Current.DispatcherUnhandledException += AppDispatcherUnhandledException;
        }


        private void AppDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {

            Console.WriteLine(e.Exception.Message + "Аварийное завершение работы");
            e.Handled = true; // Предотвращение закрытия приложения
        }
    }
}