namespace Navegacion2430933;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

	private void btnCambio_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(Costo.Text) || (!string.IsNullOrEmpty(Dinero.Text)))


		{
			double costo, dinero, cambio;

			costo = Convert.ToDouble(Costo.Text);
			dinero = Convert.ToDouble(Dinero.Text);

			cambio = dinero - costo;

			vuelto.Text = cambio.ToString();

		}
		else
		{
			DisplayAlert("Error", "Ingrese bien los datos", "Gracias");
		}
	}
}