using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FamousScientis
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailedPage : ContentPage
	{
		public DetailedPage (Scientist viewModel)
		{
			InitializeComponent ();
            BindingContext = viewModel;
        }
	}
}