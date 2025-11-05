using DataBinding.Coleccion.Models;

namespace DataBinding.Coleccion.Views;

public partial class MainPage : ContentPage
{
	private List<OrigenDePaquete> _origenes;
	public MainPage()
	{
		InitializeComponent();
		_origenes=new List<OrigenDePaquete>();
		CargarDatos();
		OrigenesListView.ItemsSource = _origenes;
	}

	private void CargarDatos()
	{
		_origenes.Add(new OrigenDePaquete
		{
			Nombre = "nuget.org",
			Origen = "https://api.nuget.org/v3/index.json",
			EstaHabilitado = true
		});
        _origenes.Add(new OrigenDePaquete
        {
            Nombre = "Microsoft Visual Studio Offline Packages",
            Origen = @"C:\Program Files(x86)\Microsoft SDKs\NuGetPackages",
            EstaHabilitado = false
        });
    }

    private void OnAgregarButtonClicked(object sender, EventArgs e)
    {
        _origenes.Add(new OrigenDePaquete
        {
            Nombre = "Origen del paquete",
            Origen = "URL o ruta del origen del paquete",
            EstaHabilitado = false
        });
        OrigenesListView.ItemsSource = null;
        OrigenesListView.ItemsSource = _origenes;
    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        OrigenDePaquete seleccionado = 
            (OrigenDePaquete)OrigenesListView.SelectedItem;
        if (seleccionado != null)
        {
            _origenes.Remove(seleccionado);
            OrigenesListView.ItemsSource = null;
            OrigenesListView.ItemsSource = _origenes;

        }

    }
}