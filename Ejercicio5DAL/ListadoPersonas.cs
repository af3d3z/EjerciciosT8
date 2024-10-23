using Ejercicio5ENT;
using System.Collections.ObjectModel;

namespace Ejercicio5DAL
{
    public class ListadoPersonasDAL
    {
        /// <summary>
        /// Devuelve una lista de personas
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<Persona> GetListadoPersonas()
        {
            ObservableCollection<Persona> personitas = new ObservableCollection<Persona>();
            personitas.Add(new Persona("Pepelu", "Morilla", DateTime.Parse("01/01/1989")));
            personitas.Add(new Persona("Ana", "García", DateTime.Parse("05/05/1990")));
            personitas.Add(new Persona("Luis", "Pérez", DateTime.Parse("12/12/1988")));
            personitas.Add(new Persona("María", "López", DateTime.Parse("20/02/1991")));
            personitas.Add(new Persona("Carlos", "Fernández", DateTime.Parse("15/03/1987")));
            personitas.Add(new Persona("Laura", "Martínez", DateTime.Parse("30/04/1985")));
            personitas.Add(new Persona("Javier", "Sánchez", DateTime.Parse("10/10/1986")));
            personitas.Add(new Persona("Sofía", "Ramírez", DateTime.Parse("25/11/1992")));
            personitas.Add(new Persona("Pedro", "Hernández", DateTime.Parse("18/09/1984")));
            personitas.Add(new Persona("Lucía", "Jiménez", DateTime.Parse("29/06/1993")));
            personitas.Add(new Persona("Raúl", "González", DateTime.Parse("03/08/1983")));
            personitas.Add(new Persona("Isabel", "Torres", DateTime.Parse("22/07/1982")));
            personitas.Add(new Persona("Miguel", "Moreno", DateTime.Parse("16/01/1980")));
            personitas.Add(new Persona("Clara", "Castro", DateTime.Parse("08/03/1995")));
            personitas.Add(new Persona("Fernando", "Mendoza", DateTime.Parse("27/12/1979")));

            return personitas;
        }

    }
}
