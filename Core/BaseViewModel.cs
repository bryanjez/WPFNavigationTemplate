using CommunityToolkit.Mvvm.ComponentModel;

namespace WPFNavigationTemplate.Core
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        object currentView;
        public virtual void Dispose() { }
    }
}
