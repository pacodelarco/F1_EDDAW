using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_EDDAW
{
    internal class Equipos
    {

        private String _nombre;
        private String _fabricante;
        private byte _numeroMecanicos;
        private List<Piloto> _pilotos;

        public Equipos(string nombre, string fabricante, byte numeroMecanicos, List<Piloto> pilotos)
        {
            _nombre = nombre;
            _fabricante = fabricante;
            _numeroMecanicos = numeroMecanicos;
            _pilotos = pilotos;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Fabricante { get => _fabricante; set => _fabricante = value; }
        public byte NumeroMecanicos { get => _numeroMecanicos; set => _numeroMecanicos = value; }
        

        public void setPilotos(List<Piloto> _pilotos)
        {
            List<Piloto> pilotos = _pilotos;
        }
        
    }
}
