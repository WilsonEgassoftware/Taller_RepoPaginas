namespace EgasTaller.layout;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

   

    private void GotoMainPage_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());

    }
}