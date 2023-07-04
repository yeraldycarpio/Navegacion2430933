namespace Navegacion2430933;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}

	private void BtnCalcular_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(peso.Text) && !string.IsNullOrEmpty(altura.Text))
		{
			var dato1 = Convert.ToDouble(peso.Text);
			var dato2 = Convert.ToDouble(altura.Text);

			var libr = dato1 * 2.2;
			libras.Text = Convert.ToString(libr);
			var centi = (dato2 * 100) / 1;
			centimetros.Text = Convert.ToString(centi);
		}
		else
		{
			DisplayAlert("Error", "Escribe el peso y la altura", "Se le agradece");
		}
	}
}