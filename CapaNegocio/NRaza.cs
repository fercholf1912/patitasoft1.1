using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class NRaza
    {
        public static DataTable Listar()
        {
            DRaza Datos = new DRaza();
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            DRaza Datos = new DRaza();
            return Datos.Buscar(valor);
        }
        public static string Insertar(int idtipoespecie,string nombre, string peligrosidad)
        {
            DRaza Datos = new DRaza();

            //string Existe = Datos.Existe(Nombre, idpresentacion);
            //string ExisteC = Datos.ExisteCodigo(Codigo);

            //if (Existe.Equals("1") || (ExisteC.Equals("1")))
            //{
            //    return "El artículo ya existe";
            //}
            //else
            //{

            Raza Obj = new Raza();
            Obj.IdTipoEspecie = idtipoespecie;
            Obj.Nombre = nombre;
            Obj.Peligrosidad = peligrosidad;
            return Datos.Insertar(Obj);

            //}
        }
        public static string Actualizar(int idraza, int idtipoespecie, string nombre, string peligrosidad)
        {
            DRaza Datos = new DRaza();

            //string Existe = Datos.Existe(Nombre, idpresentacion);
            //string ExisteC = Datos.ExisteCodigo(Codigo);

            //if (Existe.Equals("1") || (ExisteC.Equals("1")))
            //{
            //    return "El artículo ya existe";
            //}
            //else
            //{

            Raza Obj = new Raza();
            Obj.IdRaza = idraza;
            Obj.IdTipoEspecie = idtipoespecie;
            Obj.Nombre = nombre;
            Obj.Peligrosidad = peligrosidad;
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
            DRaza Datos = new DRaza();
            return Datos.Eliminar(id);
        }
        public static DataTable Seleccionar(int idtipoespecie)
        {
            DRaza Datos = new DRaza();
            return Datos.Seleccionar(idtipoespecie);
        }
    }
}
