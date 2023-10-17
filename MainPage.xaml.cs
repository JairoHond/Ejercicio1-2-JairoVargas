namespace Ejercicio1_2_JairoVargas;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
    private async void btnenviar_Clicked(object sender, EventArgs e)
    {
        var emple = new Models.Empleado
        {
            nombres = txtnombre.Text,
            apellidos = txtapellido.Text,
            fecha = Convert.ToInt32(txtFecha.Text),
            correo = txtcorreo.Text
        };

        var pagina = new Views.Empleados();
        pagina.BindingContext = emple;
        await Navigation.PushAsync(pagina);
    }
}

