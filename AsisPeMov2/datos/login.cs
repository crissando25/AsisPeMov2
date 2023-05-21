using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsisPeMov2.datos
{
     public class login
    {

        //public List<login1> login1List{ get; set; }

        //public login()
        //{
        //    login1List = Getlogin1().OrderBy(t => t.value).ToList();
        //}

        //public List<login1> Getlogin1()
        //{
        //    var btl_lg_rol = new List<login1>

        //    { 
        //    new login1(){key=1,value="administrador"},
        //    new login1(){key=2,value="usuario"},
        //    new login1(){key=3,value="super_admin"},
        //    };
        //    return btl_lg_rol;
        //}

        public int btl_login_id {get;set;}
        public string btl_lg_usuario { get; set; }
        public string  btl_lg_contraseña { get; set; }
        public string btl_lg_correo { get; set; }
        public string  btl_lg_rol { get; set; }
        public string tbl_lg_observaciones { get; set; }

    }

    //public class login1
    //{
    //    public int key { get; set; }
    //    public string value { get; set; }
    //}
}
