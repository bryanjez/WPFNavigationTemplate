using WPFNavigationTemplate.Services.HomeNavigationService.SessionAddNavigationService;

namespace WPFNavigationTemplate.ViewModels.Home.SessionAdd
{
    public partial class SessionCreateViewModel : BaseViewModel
    {
        public SessionCreateViewModel(ISessionAddNavigationService _sessionAddNavigation)
        {
            SessionAddNavigation = _sessionAddNavigation;
        }

        [ObservableProperty]
        public ISessionAddNavigationService sessionAddNavigation;

        [RelayCommand]
        async Task NavigateBackAsync()
        {
            SessionAddNavigation.NavigateTo<SessionListViewModel>();
        }

        [RelayCommand]
        async Task CreateSessionAsync()
        {
            SessionAddNavigation.NavigateTo<SessionListViewModel>();
        }
    }
}
