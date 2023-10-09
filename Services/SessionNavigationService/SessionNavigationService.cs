﻿namespace WPFNavigationTemplate.Services.SessionNavigationService
{
    public class SessionNavigationService : ObservableObject, ISessionNavigationService
    {
        private BaseViewModel _currentView;
        private readonly Func<Type, BaseViewModel> _viewModelFactory;

        public BaseViewModel CurrentView
        {
            get => _currentView;
            private set
            {
                _currentView?.Dispose();
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public SessionNavigationService(Func<Type, BaseViewModel> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        public void NavigateTo<TViewModel>() where TViewModel : BaseViewModel
        {
            BaseViewModel viewModel = _viewModelFactory.Invoke(typeof(TViewModel));
            CurrentView?.Dispose();
            CurrentView = viewModel;
        }
    }
}
