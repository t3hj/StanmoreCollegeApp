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
	public partial class Timetable2 : ContentPage
	{
		public Timetable2 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WeeklyTimetable(), true);
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timetable2(), true);
        }

        private async void Button_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timetable3(), true);
        }

    }
}