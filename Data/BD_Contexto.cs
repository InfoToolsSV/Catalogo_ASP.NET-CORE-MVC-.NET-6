using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo.Data
{
    public class BD_Contexto
    {
        public BD_Contexto(string valor) => Conexion = valor;

        public string Conexion { get; }
    }
}