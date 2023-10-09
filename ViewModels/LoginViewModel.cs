using WPFNavigationTemplate.Core;
using WPFNavigationTemplate.Services.NavigationService;

namespace WPFNavigationTemplate.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        private INavigationService navigation;

        public LoginViewModel(INavigationService navigationService)
        {
            Navigation = navigationService;
        }

        [RelayCommand]
        async Task NavigateHomeAsync()
        {
            Navigation.NavigateTo<HomeViewModel>();
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}
