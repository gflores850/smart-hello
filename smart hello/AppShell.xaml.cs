namespace smart_hello
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(second_page), typeof(second_page));
        }
    }
}
