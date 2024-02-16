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
    public partial class TootBarDemo : ContentPage
    {
        public TootBarDemo()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Item1", "Click1", "Ok");
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Item2", "Click2", "Ok");
        }
    }
}