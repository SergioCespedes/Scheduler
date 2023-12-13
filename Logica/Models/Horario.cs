using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Horario
    {
        public string nombre { get; set; }
        public string horaInicio { get; set; }
        public string horaFinal { get; set; }
        public int codigoHorario  { get; set; }
        public int idHorario { get; set; }
        public int idHora { get; set; }
        public int idDia { get; set; }
        public string dia { get; set; }
        public int idUser { get; set; }
         

        public bool Agregar()
        {
            bool ret = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@codigoHorario", this.codigoHorario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@nombre", this.nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idHora", this.idHora));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idDia", this.idDia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idUser", this.idUser));
            int resultado = MiCnn.EjecutarDML("AgregarHorario");
            if (resultado > 0) ret = true;
            return ret;
        }

        public bool Actualizar()
        {
            bool ret = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@id", this.codigoHorario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idHora", this.idHora));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idDia", this.idDia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@nombre", this.nombre));
            int resultado = MiCnn.EjecutarDML("ActualizarHorario");
            if (resultado > 0) ret = true;

            return ret;
        }

        public bool Eliminar()
        {
            bool ret = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@id", this.idHorario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@dia", this.dia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@horaInicial", this.horaInicio));
            int resultado = MiCnn.EjecutarDML("EliminarHorario");
            if (resultado > 0) ret = true;

            return ret;
        }
        public List<Horario> Listar()
        {
            Conexion MiCnn = new Conexion();
            Horario horario = new Horario();
            List<Horario> listaHorarios = new List<Horario>();
            DataTable ret = MiCnn.EjecutarSELECT("ListarHorarios");
            foreach (DataRow row in ret.Rows)
            {
                Horario horarios = new Horario
                {
                    idHorario = Convert.ToInt32(row["Id"]),
                    codigoHorario = Convert.ToInt32(row["CodigoHorario"]),
                    nombre = Convert.ToString(row["Nombre"])
                };

                listaHorarios.Add(horarios);
            }

            return listaHorarios;
        }

        public List<Horario> ConsultarPorID(int idHorario)
        {
            Conexion MiCnn = new Conexion();
            Horario horario = new Horario();
            List<Horario> listaHorarios = new List<Horario>();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@codigoHorario", idHorario));
            DataTable datosHorario = MiCnn.EjecutarSELECT("ConsultarHorarios");
            foreach (DataRow row in datosHorario.Rows)
            {
                Horario horarios = new Horario
                {
                    idHorario = Convert.ToInt32(row["Id"]),
                    codigoHorario = Convert.ToInt32(row["CodigoHorario"]),
                    nombre = Convert.ToString(row["Nombre"]),
                    horaInicio = Convert.ToString(row["HoraInicial"]),
                    horaFinal = Convert.ToString(row["HoraFinal"]),
                    dia = Convert.ToString(row["Dia"])
                };

                listaHorarios.Add(horarios);
            }
            return listaHorarios;
        }
    }
}
