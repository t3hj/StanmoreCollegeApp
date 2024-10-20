using System;
using Stanmore_App.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stanmore_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private void OpenOrder(object sender, EventArgs e)
        {
            if (OrderView.TranslationX >= 150)
            {
                Action<double> callback = input => OrderView.TranslationX = input;
                OrderView.Animate("anim", callback, 150, 0, 16, 300, Easing.CubicInOut);
            }
        }

        private void CloseOrder(object sender, EventArgs e)
        {
            if (OrderView.TranslationX == 0)
            {
                Action<double> callback = input => OrderView.TranslationX = input;
                OrderView.Animate("anim", callback, 0, 150, 16, 300, Easing.CubicOut);
            }
        }

        private void AddOrder(object sender, EventArgs e)
        {
            var item = (sender as Button).BindingContext as Foods;
            vm.AddOrder(item);
        }
    }
}