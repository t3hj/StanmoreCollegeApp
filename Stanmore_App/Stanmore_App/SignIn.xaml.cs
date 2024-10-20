using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stanmore_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignIn : ContentPage
    {
        public SignIn()
        {
            InitializeComponent();

            this.BindingContext = new LoginViewModel();


        }

        private async void Reg_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage(), true);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage(), true);
        }
    }
 }