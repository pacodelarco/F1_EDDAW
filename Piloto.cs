using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_EDDAW
{
    internal class Piloto
    {
        private String _nombre;
        private String _apellidos;
        private byte _edad;

        public Piloto(string nombre, string apellidos, byte edad)
        {
            _nombre = nombre;
            _apellidos = apellidos;
            _edad = edad;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public byte Edad { get => _edad; set => _edad = value; }

        public override string ToString()
        {
            return Nombre + " " + Apellidos;
        }

        public static implicit operator List<object>(Piloto v)
        {
            throw new NotImplementedException();
        }
    }

}
