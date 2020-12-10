using Prism.Navigation;

namespace PocDiiageTemplate.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private string _username;

        public string Username
        {
            get {return _username; }
            set { SetProperty(ref _username, value); }
        }


        public UserViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "User Page";
            Username = "Thomas BAILLY";
        }
    }
}