using WPFNavigationTemplate.Services.NavigationService;

namespace WPFNavigationTemplate.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        private INavigationService navigation;

        public MainViewModel(INavigationService navigationService)
        {
            Title = Globals.Name;

            Navigation = navigationService;

            Navigation.NavigateTo<LoginViewModel>();
        }
        
    }
}
