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
    public class NTipoEspecie
    {
        public static DataTable Listar()
        {
            DTipoEspecie Datos = new DTipoEspecie();
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            DTipoEspecie Datos = new DTipoEspecie();
            return Datos.Buscar(valor);
        }
        public static DataTable Seleccionar()
        {
            DTipoEspecie Datos = new DTipoEspecie();
            return Datos.Seleccionar();
        }
        public static string Insertar(string nombre,string descripcion)
        {
            DTipoEspecie Datos = new DTipoEspecie();

            //string Existe = Datos.Existe(Nombre, idpresentacion);
            //string ExisteC = Datos.ExisteCodigo(Codigo);

            //if (Existe.Equals("1") || (ExisteC.Equals("1")))
            //{
            //    return "El artículo ya existe";
            //}
            //else
            //{

            TipoEspecie Obj = new TipoEspecie();

            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Datos.Insertar(Obj);

            //}
        }
        public static string Actualizar(int idtipoespecie, string nombre, string descripcion)
        {
            DTipoEspecie Datos = new DTipoEspecie();

            //string Existe = Datos.Existe(Nombre, idpresentacion);
            //string ExisteC = Datos.ExisteCodigo(Codigo);

            //if (Existe.Equals("1") || (ExisteC.Equals("1")))
            //{
            //    return "El artículo ya existe";
            //}
            //else
            //{

            TipoEspecie Obj = new TipoEspecie();
            Obj.IdTipoEspecie= idtipoespecie;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
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
            DTipoEspecie Datos = new DTipoEspecie();
            return Datos.Eliminar(id);
        }
    }
}
