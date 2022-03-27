using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_EDDAW
{
    internal class Competicion
    {
        private String _nombre;
        private List<Equipos> _equipos;

        public Competicion(string nombre, List<Equipos> equipos)
        {
            _nombre = nombre;
            _equipos = equipos;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        internal List<Equipos> Equipos { get => _equipos; set => _equipos = value; }

        public override string ToString()
        {
            return ">> Competicion: " +_nombre + "\nEquipos: " + _equipos;
        }
    }
}
