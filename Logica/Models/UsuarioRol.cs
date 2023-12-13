using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {
        //Primero digitamos las propiedades de la clase

        public int UsuarioRolID { get; set; }
        //esta forma de escribir una propiedad es autoimplementada, es más sencilla 
        //pero se pierde control en las funciones de get y set. 
        public string Rol { get; set; }

        //luego de escribir las props se digitan las funciones 
        public DataTable Listar()
        { 
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPUsuariosRolListar");

            return R;
        }


    }
}
