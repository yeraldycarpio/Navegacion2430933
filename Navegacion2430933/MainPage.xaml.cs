namespace Navegacion2430933;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

	}
	private void cambio_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Cambio());
	}

	private void dinosaurio_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Dinosaurio());

	}

	private void BaseAltura_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new BaseAltura());

	}

	private void gasolina_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Gasolina());

	}

	
}

