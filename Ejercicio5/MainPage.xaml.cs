using System.Collections.ObjectModel;
using BibliotecaDeClases;

namespace Ejercicio5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PersonasListView.ItemsSource = ListadoPersonasDAL.GetListadoPersonas();
        }

        

    }

}
