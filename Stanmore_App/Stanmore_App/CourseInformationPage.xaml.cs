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
    public partial class CourseInformationPage : ContentPage
    {
        public CourseInformationPage()
        {
            InitializeComponent();
        }

        private async void ITButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ITPage(), true);
        }

        private async void BusinessButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BusinessPage(), true);
        }

        private async void EngineeringButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EngineeringPage(), true);
        }

        private async void AccountingButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Accounting(), true);
        }

        private async void EnglishButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new English(), true);
        }

        private async void MathsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Maths(), true);
        }

        private async void ScienceButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Science(), true);
        }

    }
}