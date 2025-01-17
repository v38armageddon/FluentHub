using FluentHub.App.Models;
using FluentHub.App.Services;
using FluentHub.App.Services.Navigation;
using FluentHub.App.ViewModels.Repositories.PullRequests;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Media.Imaging;

namespace FluentHub.App.Views.Repositories.PullRequests
{
    public sealed partial class CommitPage : Page
    {
        public CommitPage()
        {
            InitializeComponent();

            var provider = App.Current.Services;
            ViewModel = provider.GetRequiredService<CommitViewModel>();
            _navigation = App.Current.Services.GetRequiredService<INavigationService>();
        }

        public CommitViewModel ViewModel { get; }
        private readonly INavigationService _navigation;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var param = e.Parameter as FrameNavigationArgs;
            ViewModel.Login = param.Login;
            ViewModel.Name = param.Name;
            ViewModel.Number = param.Number;
            ViewModel.CommitItem = param.Parameters.ElementAtOrDefault(0) as Commit;

            var command = ViewModel.LoadRepositoryPullRequestCommitPageCommand;
            if (command.CanExecute(null))
                command.Execute(null);
        }
    }
}
