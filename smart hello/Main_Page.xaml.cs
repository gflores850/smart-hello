namespace smart_hello
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void When_do_Clicked(object sender, EventArgs e)
        {
            string name = Name.Text;
            string lastName = LastName.Text;

            if (!string.IsNullOrWhiteSpace(name))
            {
                await DisplayAlertAsync("Smart Salute", $"Hello, {name} {lastName}!", "OK");
                await Shell.Current.GoToAsync(nameof(second_page));
            }
            
        }

    }


}
