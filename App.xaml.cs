namespace EgasTaller.layout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
             MainPage = new NavigationPage(new NewPage1());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
