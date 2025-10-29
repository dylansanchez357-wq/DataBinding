using DataBinding.DataObject.Models;

namespace DataBinding.DataObject
{
    public partial class MainPage : ContentPage
    {
        //_conteo lleva el conteo de la aplicación
        private Contador contador;

        public MainPage()
        {
            InitializeComponent();
            contador = new Contador();
            BindingContext = contador;
            //ConteoLabel.Text = contador.Conteo.ToString();
        }

        private void OnReiniciarButtomCliked(object sender, EventArgs e) // Reiniciar
        {
            contador.Reiniciar();
            //ConteoLabel.Text = contador.Conteo.ToString();
        }

        private void OnContanButtonClicked(object sender, EventArgs e) // Contar
        {
            contador.contar();
            //ConteoLabel.Text = contador.Conteo.ToString();
        }
    }
}

