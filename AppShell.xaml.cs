namespace EgasTaller.layout
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new NewPage1());
        }
    }
}
