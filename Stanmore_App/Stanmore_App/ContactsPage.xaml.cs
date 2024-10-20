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
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
        }

        private async void PravinButton_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pravin(), true);
        }

        private async void RuhinaButton_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ruhina(), true);
        }

        private async void AbsenceButton_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Absence(), true);
        }

        private async void JerryButton_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Jerry(), true);
        }

        private async void SaidButton_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Said(), true);
        }

        private async void KousikButton_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kousik(), true);
        }

        private async void SydneyButton_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sydney(), true);
        }

        private async void JeyaButton_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Jeya(), true);
        }

    }
}