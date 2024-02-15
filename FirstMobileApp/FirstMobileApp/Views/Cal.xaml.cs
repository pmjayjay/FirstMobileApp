using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cal : ContentPage
    {
        //private readonly Models.Calcualtor _cal;
        public Cal()
        {
            InitializeComponent();
            //_cal = new Models.Calcualtor();
        }

        //private void Add(object sender, EventArgs e)
        //{
        //    lblResult.Text = _cal.Add(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
        //}

        //private void Sub(object sender, EventArgs e)
        //{

        //}

        //private void Mul(object sender, EventArgs e)
        //{

        //}

        //private void Div(object sender, EventArgs e)
        //{

        //}
    }
}