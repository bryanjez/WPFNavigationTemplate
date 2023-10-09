namespace WPFNavigationTemplate.Services.SessionNavigationService
{
    public interface ISessionNavigationService
    {
        BaseViewModel CurrentView { get; }
        void NavigateTo<TViewModel>() where TViewModel : BaseViewModel;
    }
}
