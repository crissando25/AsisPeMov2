using System;
using System.Collections.Generic;
using System.Text;

namespace AsisPeMov2.datos
{
    class jefatura_area
    {
      public int Tbl_jz_id { get; set; }
      public enum tbl_jz_nombre {Delicia , 
                                 Calderon, 
                                 Eugenio_Espejo,
                                 }
      public enum tbl_jz_grupo_t
        {
         manana,
         tarde, 
         amanecida,  
         refuerzo,
        }
        public string tbl_g_observaciones { get; set; }

    }
}
