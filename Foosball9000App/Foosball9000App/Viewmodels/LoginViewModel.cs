using System.Windows.Input;
using Foosball9000App.View;
using Xamarin.Forms;

namespace Foosball9000App.Viewmodels
{
    public class LoginViewModel : BaseViewModel, IViewModel
    {
        public LoginViewModel()
        {
            IsBusy = false;
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsBusy = false;

                
                });
            }
        }
    }
}