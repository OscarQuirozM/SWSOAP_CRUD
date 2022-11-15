using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WS_CRUD.Controlador;
using WS_CRUD.Entities;

namespace WS_CRUD.Vista
{
    public class VProductos : BDConexion
    {   

        //Visualizar lista de productos
        public List<EProductos> ProductosVIEW()
        {
            List<EProductos> lCProductos = null;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                
                {
                    con.Open();
                    CProductos ObjProductos = new CProductos();
                    lCProductos = ObjProductos.Listar_productos(con);
                }clae
                catch (SqlException ex)
                {
                    Console.WriteLine("ERROR EN VPRODUCTOS/ProductosView: " + ex);
                }
            }
            return lCProductos;
        }

        public List<EProductos> ProductosVIEW_ID(String codigo)
        {
            List<EProductos> lCProductos = null;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    CProductos ObjProductos = new CProductos();
                    lCProductos = ObjProductos.Listar_productos_ID(con, codigo);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("ERROR EN VPRODUCTOS / ProductosView(ID): " + ex);
                }
            }
            return (lCProductos);
        }


        public List<EMantenimiento> ProductosADD(String codigo, String nombre, String descripcion, decimal precio)
        {
            List<EMantenimiento> lEMantenimiento = null;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    CProductos ObjProductos = new CProductos();
                    lEMantenimiento = ObjProductos.ADD_productos(con,codigo,nombre,descripcion,precio);
                }
                catch(SqlException ex)
                {
                    Console.WriteLine("ERROR EN VPRODUCTOS/ProductosAdd" + ex);
                }
            }
            return (lEMantenimiento);
        }

        public List<EMantenimiento> ProductosUPD(String codigo, String nombre, String descripcion, decimal precio)
        {
            List<EMantenimiento> lEMantenimiento = null;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    CProductos ObjProductos = new CProductos();
                    lEMantenimiento = ObjProductos.UPD_productos(con,codigo,nombre,descripcion,precio);
                }
                catch(SqlException ex)
                {
                    Console.WriteLine("ERROR EN VPRODUCTOS/ProductosUpdate" + ex);
                }
            }
            return (lEMantenimiento);
        }

        public List<EMantenimiento> ProductosDEL(string codigo)
        {
            List<EMantenimiento> lEMantenimiento = null;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    CProductos ObjProductos = new CProductos();
                    lEMantenimiento = ObjProductos.DEL_productos(con, codigo);
                }catch(SqlException ex)
                {
                    Console.WriteLine("ERROR EN VPRODUCTOS/ProductosDelete: "+ex);
                }
            }
            return (lEMantenimiento);
        }
    }
}







