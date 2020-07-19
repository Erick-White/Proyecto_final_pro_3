﻿using System;
using System.Collections.Generic;

namespace Proyecto_final_pro_3.Models
{
    public partial class Carrito
    {
        public int IdCarrito { get; set; }
        public int? Cantidad { get; set; }
        public int IdProducto { get; set; }
        public int IdUsuario { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
