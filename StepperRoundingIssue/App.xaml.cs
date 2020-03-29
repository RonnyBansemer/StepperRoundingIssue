using Prism.DryIoc;
using Prism.Ioc;
using StepperRoundingIssue.ViewModels;
using StepperRoundingIssue.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace StepperRoundingIssue
{
    public partial class App : PrismApplication
    {
        public App() : base()
        {
            InitializeComponent();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync(nameof(MainPage));
        }
    }
}