using System;
using System.Collections.Generic;
using System.Text;

namespace AsisPeMov2.datos
{
      class act_empleado
    {
        public int tbl_act_id { get; set; }
        public string tbl_act_nombre { get; set; }
        public string tbl_act_apellido { get; set; }
        public int tbl_act_cedula { get; set; }
        public string tbl_act_codigo { get; set; }
        public enum tbl_act_genero { MASCULINO,
                                     FEMENINO
                                    }
        public int  tbl_act_telefono{ get; set; }

        public string tbl_act_observacines { get; set; }
    }
}