using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Ruby
{
    class Parametrat
    {

        public static string _KonektimiDB = ConfigurationManager.ConnectionStrings["KonektimiDB"].ToString();
    }
}
