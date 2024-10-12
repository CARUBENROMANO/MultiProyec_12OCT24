using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Recursos
{
    public class OpcionCombo
    {
        public string Texto { get; set; }  // dato de texto que va ser mostrado 
        public object  Valor { get; set; }      // dato valor que va ser interno -- objeto para almacenar lo que uno desee ej booleano o string
    }
}
