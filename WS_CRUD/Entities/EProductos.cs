using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_CRUD.Entities
{
    public class EProductos
    {

        public string pro_codigo { get; set; }
        public string pro_nombre { get; set; }
        public string pro_descripcion { get; set; }
        public decimal pro_precio { get; set; }

    }
}