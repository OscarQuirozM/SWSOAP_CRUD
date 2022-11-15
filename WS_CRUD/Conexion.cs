using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WS_CRUD
{
    public class BDConexion
    {
        public string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;//VISTAS
    }

    public class RetornoData
    {
        public int respuesta { get; set; }

    }
}