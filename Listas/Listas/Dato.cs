using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Dato
    { 
        // ATRIBUTOS DE LA CLAE

        private int _valor;   // ATRIBUTO PARA GUARDAR EL VALOR DEL OBJETO
        private Dato _siguiente; // ATRIBUTO DEL TIPO DE LA CLASE PARA GUARDAR EL OBJETO SIGUIENTE DE LA CLASE

        // GET Y SET PARA ASIGNAR EL VALOR Y EL SIGIIENTE A SI MISMO PARA OBTENERLOS


        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Dato Siguente{
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public Dato (int dato) // CONSTRUCTOR
        {
            _valor = dato;
        }

        public override string ToString() // SOBREESCRIBIMOS EL METOOD TOSTRING() PARA QUE NOS REGRESE EL VALOR QUE ALMACENA EL OBJETO
        {
            return Convert.ToString(_valor);
        }
    }
}
