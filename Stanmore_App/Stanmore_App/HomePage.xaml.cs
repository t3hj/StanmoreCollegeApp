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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private async void CourseInformationButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CourseInformationPage(), true);
        }

        private async void ActivitiesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActivitiesPage(), true);
        }

        private async void CafeteriaButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu(), true);
        }

        private async void WeeklyTimetableButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WeeklyTimetable(), true);
        }

        private async void TodaysTimetableButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodaysTimetable(), true);
        }

        private async void MePageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MePage(), true);
        }

        private async void ContactsPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactsPage(), true);
        }

        private async void AssignmentsPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AssignmentsPage(), true);
        }

        private async void SettingsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage(), true);
        }
    }
}