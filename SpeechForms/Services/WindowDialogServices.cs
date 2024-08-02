
using Microsoft.Extensions.DependencyInjection;
using SpeechForms.ViewModels;
using SpeechForms.Views;

namespace SpeechForms.Services
{
    public class WindowDialogServices
    {

        private readonly IServiceProvider serviceProvider;
        private MainWindow mainWindow;

        public WindowDialogServices(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void OpenMainWindow()
        {
            if (mainWindow is { } window)
            {
                window.Show();
                return;
            }
           
            window = serviceProvider.GetRequiredService<MainWindow>();
            var dataContext = serviceProvider.GetRequiredService<MainVM>();
            window.DataContext = dataContext;

            window.Show();
        }





    }
}