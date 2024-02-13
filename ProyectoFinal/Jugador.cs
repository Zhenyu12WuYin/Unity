using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly_CSharp
{
    internal class Jugador
    {
        private String nombre;
        private float tiempo;
        private String tiempoForm;

        public Jugador(string nombre, float tiempo, string tiempoForm)
        {
            this.Nombre = nombre;
            this.Tiempo = tiempo;
            this.TiempoForm = tiempoForm;
        }
        public Jugador() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Tiempo { get => tiempo; set => tiempo = value; }
        public string TiempoForm { get => tiempoForm; set => tiempoForm = value; }

        public override String ToString()
        {
            return $"Nombre: {nombre}, Tiempo Formateado: {tiempoForm}";
        }
    }
}
