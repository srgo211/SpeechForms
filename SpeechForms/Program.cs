using SpeechForms.Localization;
using System.Diagnostics;
using System.Globalization;
using Telerik.Windows.Controls;

namespace SpeechForms
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Critical;
                LocalizationManager.Manager = new LocalizationManager
                {
                    ResourceManager = FilteringUIResources.ResourceManager,
                    Culture = new CultureInfo("ru")
                };
                App app = new();
                app.InitializeComponent();
                app.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("ok");
            }
        }
    }
}