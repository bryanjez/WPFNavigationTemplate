namespace WPFNavigationTemplate.Services.NavigationService
{
    public interface INavigationService
    {
        BaseViewModel CurrentView { get; }
        void NavigateTo<TViewModel>() where TViewModel : BaseViewModel;

    }
}
