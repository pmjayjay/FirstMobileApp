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
    public partial class Assignment4 : ContentPage
    {
        public Assignment4()
        {
            InitializeComponent();
        }

        //void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        //{
        //    lblplaceholder.Text = $"Font Size: {args.NewValue}";
        //    lblfontchange.FontSize = args.NewValue;
        //}
    }
}