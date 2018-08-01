using System;
using Xamarin.Forms;

namespace FamousScientis
{
	public partial class MainPage : ContentPage
	{
        private ScientistService _service;
        private Button _button;
        private StackLayout _layout;
        private ScrollView _scrollView;

		public MainPage()
		{
            _service = new ScientistService();
            Content = InitializeLayout();
            Title = "FAMOUS SCIENTISTS";
        }

        private View InitializeLayout()
        {
            _layout = new StackLayout();
            _layout.Spacing = 0;

            foreach (var name in _service.GetNames())
            {
                _button = new Button
                {
                    Text = name,
                    BackgroundColor = Color.White
                };
                _button.Clicked += OnButtonClicked;

                _layout.Children.Add(_button);
            }

            _scrollView = new ScrollView();
            _scrollView.Content = _layout;

            return _scrollView;
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            string scientistName = ((Button)sender).Text;
            await Navigation.PushAsync(new DetailedPage(_service.GetScientistByName(scientistName))
            {
                Title = scientistName
            });
        }
    }
}
