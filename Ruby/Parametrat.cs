﻿using System.Configuration;
using System.Windows.Forms;

namespace Ruby
{
    class Parametrat
    {

        static string OldStrPerConn = ConfigurationManager.ConnectionStrings["KonektimiDB"].ToString();


        static string folder = Application.ExecutablePath;


        static string[] Potestoj = folder.Split('.');

        static string test2 = Potestoj[0] + "DB.mdf";


        //E bon stringun per konektim te gatshem per secilen Pc qe instalohet
        static string strPerKonektimNew= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + test2+ ";Integrated Security=True;";

       

        public static string _KonektimiDB = OldStrPerConn; 
    }
}
