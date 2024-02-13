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
	public partial class Assignment : ContentPage
	{
		public Assignment ()
		{
			InitializeComponent ();
		}

        private void PostData(object sender, EventArgs e)
        {
            bool IsValid = true;
            if(string.IsNullOrWhiteSpace(fName.Text))
            {
                IsValid=false;
                DisplayAlert("First Name", "First name must not be empty", "Ok");
            }
            else if (string.IsNullOrWhiteSpace(lName.Text))
            {
                IsValid = false;
                DisplayAlert("Last Name", "Last name must not be empty", "Ok");
            }
            else if (string.IsNullOrWhiteSpace(comments.Text))
            {
                IsValid = false;
                DisplayAlert("Comments", "Comments must not be empty", "Ok");
            }
            if(IsValid)
            {
                string result = $"Name: {fName.Text} {lName.Text} \n Comments: {comments.Text}";
                DisplayAlert("Assignment", result, "Ok");
            }
        }

        private void ClearData(object sender, EventArgs e)
        {
            fName.Text = string.Empty;
            lName.Text = string.Empty;
            comments.Text = string.Empty;
        }
    }
}