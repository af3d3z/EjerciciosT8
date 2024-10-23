using Ejercicio5DAL;
using System.Collections.ObjectModel;

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
