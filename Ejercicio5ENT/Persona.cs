namespace Ejercicio5ENT
{
    public class Persona
    {
        #region atributos
        private String nombre;
        private String apellido;
        private DateTime fechaNac;
        #endregion

        #region propiedades
        public String Nombre{
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public String Apellido {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime FechaNac {
            get { return fechaNac;  }
            set {
                if (value.Year >= 1900) {
                    fechaNac = value; 
                }
            }
        }

        public String NombreCompleto => $"{Nombre} {Apellido}";

        public int Edad {
            get { return DateTime.Now.Year - fechaNac.Year;  }
        }

        #endregion

        #region constructores
        public Persona() { }
        public Persona(String nombre) { 
            this.nombre = nombre;
        }
        public Persona(String nombre, String apellido) {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(String nombre, String apellido, DateTime fechaNac) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
        }
        #endregion constructores
    }
}
