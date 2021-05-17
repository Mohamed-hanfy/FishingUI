using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Testfeat
{
    public partial class MainPage : ContentPage
    {
        Page onbordingpage;
        public MainPage()
        {
            InitializeComponent();
            if(shouldShowOnboarding()==true)
            {
                App.Current.ModalPopping += Current_ModalPopping;
                onbordingpage = new Onboarding();
                Navigation.PushModalAsync(onbordingpage, false);
            }
        }

        private void Current_ModalPopping(object sender, ModalPoppingEventArgs e)
        {
            if(e.Modal ==onbordingpage)
            {
                FadeBox.FadeTo(0, 1000);
                onbordingpage =null;
                App.Current.ModalPopping -= Current_ModalPopping;
            }
        }

        private bool shouldShowOnboarding()
        {
            return true;
        }
    }
}
