namespace WPFNavigationTemplate.Services.HomeNavigationService.SessionAddNavigationService
{
    public interface ISessionAddNavigationService
    {
        BaseViewModel CurrentView { get; }
        void NavigateTo<TViewModel>() where TViewModel : BaseViewModel;
    }        
}
