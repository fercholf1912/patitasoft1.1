using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Entidades;

using CapaDatos;

namespace CapaNegocio
{
    public class NMascota
    {
        public static DataTable Listar()
        {
            DMascota Datos = new DMascota();
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            DMascota Datos = new DMascota();
            return Datos.Buscar(valor);
        }
        public static string Insertar(int idpropietario, int idtipoepecie, int idraza, string nombre, string genero, DateTime fechanacimiento, string color)
        {
            DMascota Datos = new DMascota();

            //string Existe = Datos.Existe(Nombre, idpresentacion);
            //string ExisteC = Datos.ExisteCodigo(Codigo);

            //if (Existe.Equals("1") || (ExisteC.Equals("1")))
            //{
            //    return "El artículo ya existe";
            //}
            //else
            //{

            Mascota Obj = new Mascota();
            Obj.IdPropietario = idpropietario;
            Obj.IdTipoEspecie = idtipoepecie;
            Obj.IdRaza = idraza;

            Obj.Nombre = nombre;
            Obj.Genero = genero;
            Obj.FechaNacimiento=fechanacimiento;
            Obj.Color = color;
            return Datos.Insertar(Obj);

            //}
        }
        public static string Actualizar(int idmascota, int idpropietario, int idtipoepecie, int idraza, string nombre, string genero, DateTime fechanacimiento, string color)
        {
            DMascota Datos = new DMascota();
            //string Existe = Datos.Existe(Nombre, idpresentacion);
            //string ExisteC = Datos.ExisteCodigo(Codigo);

            //if (Existe.Equals("1") || (ExisteC.Equals("1")))
            //{
            //    return "El artículo ya existe";
            //}
            //else
            //{
            Mascota Obj = new Mascota();
            Obj.IdMascota = idmascota;
            
            Obj.IdPropietario = idpropietario;
            Obj.IdTipoEspecie = idtipoepecie;
            Obj.IdRaza = idraza;

            Obj.Nombre = nombre;
            Obj.Genero = genero;
            Obj.FechaNacimiento = fechanacimiento;
            Obj.Color = color;
            return Datos.Actualizar(Obj);
            //}
        }
        //public static DataTable Seleccionar()
        //{
        //    DPropietario Datos = new DPropietario();
        //    return Datos.Seleccionar();
        //}

        public static string Eliminar(int id)
        {
            DMascota Datos = new DMascota();
            return Datos.Eliminar(id);
        }
    }
}
