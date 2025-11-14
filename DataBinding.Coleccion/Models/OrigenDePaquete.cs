
using System.ComponentModel;

namespace DataBinding.Coleccion.Models
{
    public class OrigenDePaquete : INotifyPropertyChanged
    {
        //public string Nombre {  get; set; } = string.Empty;
        //public string Origen { get; set; } = string.Empty;
        //public bool EstaHabilitado { get; set; } = false;

        private string? _nombre = string.Empty;
        private string? _origen = string.Empty;
        private bool? _estahabilitado = false;

        public string? Nombre
        {
            get => _nombre;
            set
            {
                if (value != _nombre)
                {
                    _nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }
        }

        public string? Origen
        {
            get => _origen;
            set
            {
                if (value != _origen)
                {
                    _origen = value;
                    OnPropertyChanged(nameof(Origen));
                }
            }
        }


    public bool? EstaHabilitado
        {
            get => _estahabilitado;
            set
            {
                if (_estahabilitado != value)
                {
                    _estahabilitado = value;
                    OnPropertyChanged(nameof(EstaHabilitado));
                }

                  
            }

            }
        
            
            

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return $"{Nombre} - ( {Origen} )";
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke
                (this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
