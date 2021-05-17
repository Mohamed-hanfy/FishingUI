using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testfeat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Onboarding : ContentPage
    {
        public Onboarding()
        {
            InitializeComponent();
        }
         protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            MyRadialGradient.RadiusX = width * 6;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopModalAsync(false);
        }
    }
}