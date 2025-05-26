namespace EgasTaller.layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
          

            // Crear un cuadrado con varios colores usando una cuadrícula
            var grid = new Grid
            {
                WidthRequest = 200,
                HeightRequest = 200
            };

            // Definir los colores para cada sección del cuadrado
            var colors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    grid.Children.Add(new BoxView
                    {
                        BackgroundColor = colors[i * 2 + j]
                    }, i, j);
                }
            }

            Content = new StackLayout
            {
                Children = { grid },
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
        }
    }
}
