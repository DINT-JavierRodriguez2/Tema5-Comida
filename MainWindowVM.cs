using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5_Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> listaPlatos;

        public ObservableCollection<Plato> ListaPlatos
        {
            get {  return listaPlatos; }
            set 
            {
                listaPlatos = value;
                NotifyPropertyChanged("ListaPlatos");
            }
        }

        private Plato platoSeleccionado;

        public Plato? PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        private ObservableCollection<string> tiposComida;

        public ObservableCollection<string> TiposComida
        {
            get { return tiposComida; }
            set
            {
                tiposComida = value;
                NotifyPropertyChanged("TiposComida");
            }
        }


        public MainWindowVM()
        {
            ListaPlatos = Plato.GetSamples("Resources");
            TiposComida = new ObservableCollection<string> { "China", "Americana", "Mexicana" };

        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void limpiarSeleccion()
        {
            PlatoSeleccionado = null;
        }
    }
}
