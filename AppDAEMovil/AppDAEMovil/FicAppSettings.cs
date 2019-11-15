using System;
using System.Collections.Generic;
using System.Text;

namespace AppDAEMovil
{
    public class FicAppSettings
    {
        public static string FicDataBaseName = "DB_DAE_TEC.db3";
        //public static cat_usuarios FicUserConnect { get; set; }
        //public static rh_cat_personas FicUserPersona { get; set; }
        //public static List<seg_roles_usuarios> FicUserRoles { get; set; }
        //FIC: Conectar a Local. Cuando es local debe llevar "s" en httpS.
        public static string FicUrlBase { get => "https://localhost:44300/"; set { } }
        //FIC: conectar a un servidor. Cuando es a un servidor remoto http no debe llevar "s".
        //public static string FicUrlBase { get => "http://:9091/AppDAEREST/"; set { } }
    }
}
