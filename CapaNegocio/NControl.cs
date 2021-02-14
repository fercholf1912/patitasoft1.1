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
    public class NControl
    {
        public static DataTable Listar(int idmascota)
        {
            DControl Datos = new DControl();
            return Datos.Listar(idmascota);
        }
        public static string Insertar(int idmascota,int idusuario, decimal peso, decimal talla,string foto,string observacion,DataTable vacuna)
        {
            DControl Datos = new DControl();

            //string Existe = Datos.Existe(Nombre, idpresentacion);
            //string ExisteC = Datos.ExisteCodigo(Codigo);

            //if (Existe.Equals("1") || (ExisteC.Equals("1")))
            //{
            //    return "El artículo ya existe";
            //}
            //else
            //{

            ControlMascota Obj = new ControlMascota();
            Obj.IdMascota = idmascota;
            Obj.IdUsuario = idusuario;
            Obj.Peso = peso;
            Obj.Talla = talla;
            Obj.Foto = foto;
            Obj.Observacion = observacion;
            Obj.Vacuna = vacuna;


            return Datos.Insertar(Obj);

            //}
        }
    }
}
