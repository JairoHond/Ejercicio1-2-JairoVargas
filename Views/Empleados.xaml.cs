namespace Ejercicio1_2_JairoVargas.Views;


[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Empleados : ContentPage
{
	public Empleados()
	{
		InitializeComponent();
	}

    public Empleados(String pmessage)
    {
        InitializeComponent();

        lbnombres.Text = pmessage;
        lbapellidos.Text = pmessage;
        lbfecha.Text = pmessage;
        lbcorreo.Text = pmessage;


    }
}