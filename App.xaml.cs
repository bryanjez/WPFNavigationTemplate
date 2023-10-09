using Microsoft.Extensions.DependencyInjection;
using WPFNavigationTemplate.Services.HomeNavigationService;
using WPFNavigationTemplate.Services.NavigationService;
using WPFNavigationTemplate.ViewModels;
using WPFNavigationTemplate.ViewModels.Home;
using WPFNavigationTemplate.Views;
using WPFNavigationTemplate.Services.SessionNavigationService;
using WPFNavigationTemplate.Services.HomeNavigationService.SessionAddNavigationService;
using WPFNavigationTemplate.ViewModels.Home.SessionAdd;

namespace WPFNavigationTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;
        public App()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<MainView>(provider => new MainView
            {
                DataContext = provider.GetRequiredService<MainViewModel>()
            });

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<SessionViewModel>();

            // Home
            services.AddSingleton<SessionAddViewModel>();
            services.AddSingleton<ReportViewModel>();

                // SessionAdd
            services.AddSingleton<SessionListViewModel>();
            services.AddSingleton<SessionCreateViewModel>();

            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<IHomeNavigationService, HomeNavigationService>();
            services.AddSingleton<ISessionNavigationService, SessionNavigationService>();
            services.AddSingleton<ISessionAddNavigationService, SessionAddNavigationService>();

            services.AddSingleton<Func<Type, BaseViewModel>>(serviceProvider => viewModelType => (BaseViewModel)serviceProvider.GetRequiredService(viewModelType));

            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainView = _serviceProvider.GetRequiredService<MainView>();
            mainView.Show();
            base.OnStartup(e);

        }
    }
}
