using System;
using System.Collections.Generic;
using System.Text;

namespace Concesionario_2
{
    class Automovil
    {
        public string _marca;
        public int _año;
        public int _kilometraje;

        public Automovil(int kilometraje, string marca, int año)
        {
            _kilometraje = kilometraje;
            _marca = marca;
            _año = año;
        }

        public Automovil(string marca, int año, int kilometraje)
        {
            _marca = marca;
            _año = año;
            _kilometraje = kilometraje;
        }
    }
}
