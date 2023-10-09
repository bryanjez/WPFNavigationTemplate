namespace WPFNavigationTemplate.Services.HomeNavigationService
{
    public interface IHomeNavigationService
    {
        BaseViewModel CurrentView { get; }
        void NavigateTo<TViewModel>() where TViewModel : BaseViewModel;
    }
}
