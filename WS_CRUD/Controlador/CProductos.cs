using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WS_CRUD.Entities;

namespace WS_CRUD.Controlador
{
    public class CProductos
    {
        public List<EProductos> Listar_productos(SqlConnection con)
        {
            List<EProductos> productos = null;
            SqlCommand cmd = new SqlCommand("SP_VIEWProd", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.SingleResult);

            if (dr != null)
            {
                productos = new List<EProductos>();
                EProductos Obj_Productos = null;
                while (dr.Read())
                {
                    Obj_Productos = new EProductos();
                    Obj_Productos.pro_codigo = dr["pro_codigo"].ToString();
                    Obj_Productos.pro_nombre = dr["pro_nombre"].ToString();
                    Obj_Productos.pro_descripcion = dr["pro_descripcion"].ToString();
                    Obj_Productos.pro_precio = Convert.ToDecimal(dr["pro_precio"]);
                    productos.Add(Obj_Productos);
                }
                dr.Close();
            }
            return productos;
        }

        public List<EProductos> Listar_productos_ID(SqlConnection con, String codigo)
        {

            List<EProductos> productos = null;
            SqlCommand cmd = new SqlCommand("SP_VIEWProd_ID", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo_", SqlDbType.VarChar).Value = codigo;
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult);

            if (dr != null)
            {
                productos = new List<EProductos>();
                EProductos Obj_Productos = null;
                while (dr.Read())
                {
                    Obj_Productos = new EProductos();
                    Obj_Productos.pro_codigo = dr["pro_codigo"].ToString();
                    Obj_Productos.pro_nombre = dr["pro_nombre"].ToString();
                    Obj_Productos.pro_descripcion = dr["pro_descripcion"].ToString();
                    Obj_Productos.pro_precio = Convert.ToDecimal(dr["pro_precio"]);
                    productos.Add(Obj_Productos);
                }
                dr.Close();
            }
            return productos;
        }

        public List<EMantenimiento> ADD_productos(SqlConnection con, String codigo, String nombre, String descripcion, decimal precio)
        {
            List<EMantenimiento> lEMantenimiento = null;
            SqlCommand cmd = new SqlCommand("SP_ADDProd", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigo_", SqlDbType.VarChar).Value = codigo;
            cmd.Parameters.AddWithValue("@nombre_", SqlDbType.VarChar).Value = nombre;
            cmd.Parameters.AddWithValue("@descripcion_", SqlDbType.VarChar).Value = descripcion;
            cmd.Parameters.AddWithValue("@precio_", SqlDbType.VarChar).Value = precio;

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr != null)
            {
                lEMantenimiento = new List<EMantenimiento>();
                EMantenimiento ObjEMantenimiento = null;

                while (dr.Read())
                {
                    ObjEMantenimiento = new EMantenimiento();
                    ObjEMantenimiento.v_icon = dr["v_icon"].ToString();
                    ObjEMantenimiento.v_title = dr["v_title"].ToString();
                    ObjEMantenimiento.v_text = dr["v_text"].ToString();
                    ObjEMantenimiento.i_timer = Convert.ToInt32(dr["i_timer"].ToString());
                    ObjEMantenimiento.i_case = Convert.ToInt32(dr["i_case"].ToString());
                    ObjEMantenimiento.v_progressbar = Convert.ToBoolean(dr["v_progressbar"].ToString());
                    lEMantenimiento.Add(ObjEMantenimiento);
                }
                dr.Close();
            }
            return (lEMantenimiento);
        }

        public List<EMantenimiento> UPD_productos(SqlConnection con, String codigo, String nombre, String descripcion, decimal precio)
        {
            List<EMantenimiento> lEMantenimiento = null;
            SqlCommand cmd = new SqlCommand("SP_UPDProd", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigo_", SqlDbType.VarChar).Value = codigo;
            cmd.Parameters.AddWithValue("@nombre_", SqlDbType.VarChar).Value = nombre;
            cmd.Parameters.AddWithValue("@descripcion_", SqlDbType.VarChar).Value = descripcion;
            cmd.Parameters.AddWithValue("@precio_", SqlDbType.VarChar).Value = precio;

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr != null)
            {
                lEMantenimiento = new List<EMantenimiento>();
                EMantenimiento ObjEMantenimiento = null;

                while (dr.Read())
                {
                    ObjEMantenimiento = new EMantenimiento();
                    ObjEMantenimiento.v_icon = dr["v_icon"].ToString();
                    ObjEMantenimiento.v_title = dr["v_title"].ToString();
                    ObjEMantenimiento.v_text = dr["v_text"].ToString();
                    ObjEMantenimiento.i_timer = Convert.ToInt32(dr["i_timer"].ToString());
                    ObjEMantenimiento.i_case = Convert.ToInt32(dr["i_case"].ToString());
                    ObjEMantenimiento.v_progressbar = Convert.ToBoolean(dr["v_progressbar"].ToString());
                    lEMantenimiento.Add(ObjEMantenimiento);
                }
                dr.Close();
            }
            return (lEMantenimiento);
        }

        public List<EMantenimiento> DEL_productos(SqlConnection con, String codigo)
        {
            List<EMantenimiento> lEMantenimiento = null;
            SqlCommand cmd = new SqlCommand("SP_DELProd", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigo_", SqlDbType.VarChar).Value = codigo;
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr != null)
            {
                lEMantenimiento = new List<EMantenimiento>();
                EMantenimiento ObjEMantenimiento = null;

                while (dr.Read())
                {
                    ObjEMantenimiento = new EMantenimiento();
                    ObjEMantenimiento.v_icon = dr["v_icon"].ToString();
                    ObjEMantenimiento.v_title = dr["v_title"].ToString();
                    ObjEMantenimiento.v_text = dr["v_text"].ToString();
                    ObjEMantenimiento.i_timer = Convert.ToInt32(dr["i_timer"].ToString());
                    ObjEMantenimiento.i_case = Convert.ToInt32(dr["i_case"].ToString());
                    ObjEMantenimiento.v_progressbar = Convert.ToBoolean(dr["v_progressbar"].ToString());
                    lEMantenimiento.Add(ObjEMantenimiento);
                }
                dr.Close();
            }
            return (lEMantenimiento);
        }
    }
}