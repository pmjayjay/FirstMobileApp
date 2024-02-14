using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void authenticate(object sender, EventArgs e)
        {
            bool isSuccess = true;
            if(string.IsNullOrWhiteSpace(UserName.Text))
            {
                isSuccess = false;
                DisplayAlert("User Name", "User name must not be empty", "Ok");
            }
            if (string.IsNullOrWhiteSpace(Password.Text))
            {
                isSuccess = false;
                DisplayAlert("Password", "Password must not be empty", "Ok");
            }
            if (isSuccess)
            {
                if(UserName.Text.ToLower() == "admin" &&  Password.Text == "Admin")
                {
                    DisplayAlert("Login Success", "You are authorized to access the app", "Ok");
                }
                else
                {
                    DisplayAlert("Login Failed", "You are not authorized to access the app", "Ok");
                }
            }
        }
    }
}