using WPFNavigationTemplate.Services.HomeNavigationService;
using WPFNavigationTemplate.Services.NavigationService;
using WPFNavigationTemplate.ViewModels.Home;

namespace WPFNavigationTemplate.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        [ObservableProperty]
        private INavigationService navigation;

        [ObservableProperty]
        private IHomeNavigationService homeNavigation;

        public HomeViewModel(INavigationService navigationService, IHomeNavigationService homeNavigationService)
        {
            Navigation = navigationService;
            HomeNavigation = homeNavigationService;

            Task task = NavigateSessionAddAsync();

        }

        [RelayCommand]
        async Task NavigateLoginAsync()
        {
            Navigation.NavigateTo<LoginViewModel>();
        }

        [RelayCommand]
        async Task NavigateSessionAddAsync()
        {
            HomeNavigation.NavigateTo<SessionAddViewModel>();
        }

        [RelayCommand]
        async Task NavigateReportAsync()
        {
            HomeNavigation.NavigateTo<ReportViewModel>();
        }
    }
}
