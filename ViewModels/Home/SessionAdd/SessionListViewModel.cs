using WPFNavigationTemplate.Models;
using WPFNavigationTemplate.Services.HomeNavigationService.SessionAddNavigationService;
using System.Collections.ObjectModel;

namespace WPFNavigationTemplate.ViewModels.Home.SessionAdd
{
    public partial class SessionListViewModel : BaseViewModel
    {
        public ObservableCollection<Session> Sessions { get; } = new();

        [ObservableProperty]
        public ISessionAddNavigationService sessionAddNavigation;

        int count = 0;

        public SessionListViewModel(ISessionAddNavigationService _sessionAddNavigation)
        {
            count++;
            Sessions.Add(new Session
            {
                Id = count,
                SessionType = "Active",
                Name = "No. " + count,
            });

            SessionAddNavigation = _sessionAddNavigation;
        }

        [RelayCommand]
        async Task CreateSessionAsync()
        {
            count++;

            Sessions.Add(new Session
            {
                Id = count,
                SessionType = "Active",
                Name = "No. " + count,
            });
        }


        [RelayCommand]
        async Task UserSelectedAsync(Session session)
        {
            MessageBox.Show(session.Name);
        }

        [RelayCommand]
        async Task NavigateCreateAsync()
        {
            SessionAddNavigation.NavigateTo<SessionCreateViewModel>();
        }
    }
}
