using System;
using System.Collections.Generic;
using System.Text;

namespace AsisPeMov2.datos
{
	class lugar_servicio
	{
		public int tbl_ls_id { get; set; }
		public DateTime tbl_ls_fecha_inicio { get; set; }
		public DateTime tbl_ls_hora_inicio { get; set; }
		public string tbl_ls_latitud { get; set; }
		public string tbl_ls_longitud { get; set; }

		public DateTime tbl_ls_fecha_fin { get; set; }
		public DateTime imetbl_ls_hora_fin { get; set; }
		public string tbl_ls_latitud_fin { get; set; } 
	    public string  tbl_ls_longitud_fin { get; set; } 
		public string tbl_ls_observaciones { get; set; } 
	    public int 	Tbl_jz_id { get; set; } 
	    public int tbl_act_id { get; set; } 	
	    public enum tbl_lg_estado {inicio,fin, } 
	     
    }
}

