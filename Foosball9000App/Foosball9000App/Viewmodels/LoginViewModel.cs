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

        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsBusy { get; set; }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsBusy = true;

                    Username = "success";
                });

            }
        }
    }
}