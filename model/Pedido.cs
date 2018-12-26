using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SpG.model
{
    class Pedido
    {
        public string pedido_id { get; set; }
        public string pedido_mesa { get; set; }
        public string pedido_cliente { get; set; }
        public string pedido_prato { get; set; }
        public string pedido_bebida { get; set; }
        public string pedido_status { get; set; }

        
    }


}
