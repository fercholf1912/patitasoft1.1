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
    public class NPersona
    {
        public static DataTable ListarPropietario()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarPropietario();
        }
        public static DataTable BuscarPropietario(string valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarPropietario(valor);
        }
        public static DataTable ListarUsuario()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarUsuario();
        }
        public static DataTable BuscarUsuario(string valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarUsuario(valor);
        }
        public static string Insertar(string cedula, string nombre, string direccion, string telefono, string genero, string rol, string correo, string clave)
        {
            DPersona Datos = new DPersona();
            Usuario Obj = new Usuario();
            Obj.Cedula = cedula;
            Obj.Nombre = nombre;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Genero = genero;
            Obj.Rol = rol;
            Obj.Correo = correo;
            Obj.Clave = clave;
            return Datos.Insertar(Obj);
        }
        public static string Insertar(string cedula, string nombre, string direccion, string telefono, string genero)
        {
            DPersona Datos = new DPersona();
            Propietario Obj = new Propietario();
            Obj.Cedula = cedula;
            Obj.Nombre = nombre;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Genero = genero;
            return Datos.Insertar(Obj);
        }
        public static string Actualizar(int id_usuario, string cedula, string nombre, string direccion, string telefono, string genero, string rol, string correo, string clave)
        {
            DPersona Datos = new DPersona();
            Usuario Obj = new Usuario();
            Obj.IdPersona = id_usuario;
            Obj.Cedula = cedula;
            Obj.Nombre = nombre;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Genero = genero;
            Obj.Rol = rol;
            Obj.Correo = correo;
            Obj.Clave = clave;
            return Datos.Actualizar(Obj);
        }
        public static string Actualizar(int id_usuario, string cedula, string nombre, string direccion, string telefono, string genero)
        {
            DPersona Datos = new DPersona();
            Propietario Obj = new Propietario();

            Obj.IdPersona = id_usuario;
            Obj.Cedula = cedula;
            Obj.Nombre = nombre;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Genero = genero;
            return Datos.Actualizar(Obj);
        }
        public static DataTable Login(string email, string clave)
        {
            DPersona Datos = new DPersona();
            return Datos.Login(email, clave);
        }
        public static DataTable SeleccionarUsuario()
        {
            DPersona Datos = new DPersona();
            return Datos.SeleccionarUsuario();
        }
        public static DataTable SeleccionarPropietario()
        {
            DPersona Datos = new DPersona();
            return Datos.SeleccionarPropietario();
        }
        public static string Eliminar(int id)
        {
            DPersona Datos = new DPersona();
            return Datos.Eliminar(id);
        }
    }
}
