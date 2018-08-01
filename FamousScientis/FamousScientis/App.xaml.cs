using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace FamousScientis
{
	public partial class App : Application
	{
        public App ()
		{
			InitializeComponent();

            var navigationPage = new NavigationPage(new MainPage())
            {
                BarTextColor = Color.FromHex("#FFFFFF"),
                BarBackgroundColor = Color.FromHex("#0099FF")
            };
            MainPage = navigationPage;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
