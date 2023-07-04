namespace Navegacion2430933;

public partial class Gasolina : ContentPage
{
	public Gasolina()
	{
		InitializeComponent();
	}

	private void total_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(galones.Text) && !string.IsNullOrEmpty(litros.Text))
		{
			double dato1 = Convert.ToInt32(galones.Text);
			double dato2 = Convert.ToDouble(litros.Text);
			double datos2 = dato1 * 3.7;

			litros.Text = Convert.ToString(datos2);

			double cliente = dato2 * datos2;
			pago.Text = Convert.ToString(cliente);
		}
		else
		{
			DisplayAlert("Error", "Vuelva a intentarlo", "Se le agradece");
		}
	}
}