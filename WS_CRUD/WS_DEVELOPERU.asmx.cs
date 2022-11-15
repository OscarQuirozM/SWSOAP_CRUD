using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WS_CRUD.Entities;
using WS_CRUD.Vista;

namespace WS_CRUD
{
    /// <summary>
    /// Descripción breve de WS_DEVELOPERU
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_DEVELOPERU : System.Web.Services.WebService
    {
        //VISTAS-----------------------------------------------
        public VProductos IProductos = new VProductos();
        //VISTA SIMPLE DE PRODUCTOS-----------------------------------------------
        [WebMethod]
        public string Productos_View()
        {
            List<EProductos> lista = new List<EProductos>();
            lista = IProductos.ProductosVIEW();
            string json = JsonConvert.SerializeObject(lista);
            return json;
        }
        //VISTA SIMPLE DE PRODUCTOS POR ID------------------------------------------
        [WebMethod]
        public string Productos_ViewID(String codigo)
        {   
            
            List<EProductos> lista = new List<EProductos>();
            lista = IProductos.ProductosVIEW_ID(codigo);
            string json = JsonConvert.SerializeObject(lista);
            return json;
        }
        //AÑADIR NUEVOS PRODUCTOS-------------------------------------------------
        [WebMethod]
        public string Productos_Add(String codigo, String nombre, String descripcion, decimal precio)
        {
            List<EMantenimiento> lista = new List<EMantenimiento>();
            lista = IProductos.ProductosADD(codigo,nombre, descripcion, precio);
            string json = JsonConvert.SerializeObject(lista);
            return json;
        }
        //ACTUALIZACION DE PRODUCTOS-----------------------------------------------
        [WebMethod]
        public string Productos_Upd(String codigo, String nombre, String descripcion, decimal precio)
        {
            List<EMantenimiento> lista = new List<EMantenimiento>();
            lista = IProductos.ProductosUPD(codigo,nombre,descripcion,precio);
            string json = JsonConvert.SerializeObject(lista);
            return json;
        }
        //ELIMINACION DE PRODUCTOS POR ID-------------------------------------------S
        [WebMethod]
        public string Producto_Del(String codigo)
        {
            List<EMantenimiento> lista = new List<EMantenimiento>();
            lista = IProductos.ProductosDEL(codigo);
            string json = JsonConvert.SerializeObject(lista);
            return json;
        }
        //Funciones CRUD, ejecutados como servicios
    }
}
