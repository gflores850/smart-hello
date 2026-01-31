

namespace smart_hello;

public partial class second_page : ContentPage
{
	public second_page()
	{
		InitializeComponent();
	}
	private async void OnReturnButtonClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MainPage");
	}
}