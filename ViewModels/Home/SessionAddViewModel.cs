using WPFNavigationTemplate.Services.HomeNavigationService.SessionAddNavigationService;
using WPFNavigationTemplate.ViewModels.Home.SessionAdd;

namespace WPFNavigationTemplate.ViewModels.Home
{
    public partial class SessionAddViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ISessionAddNavigationService sessionAddNavigation;

        public SessionAddViewModel(ISessionAddNavigationService _sessionAddNavigationService)
        {
            sessionAddNavigation = _sessionAddNavigationService;

            Task task = NavigateSessionListAsync();
        }

        [RelayCommand]
        async Task NavigateSessionListAsync()
        {
            SessionAddNavigation.NavigateTo<SessionListViewModel>();
        }
    }
}
