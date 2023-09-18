using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apijuntoz.Modelos
{
    public class Pedidos
    {
        [Table("pedidos")]
        public class Usuarios
        {
            public string codigo { get; set; }
            public string descripcion { get; set; }
        }
    }
}
