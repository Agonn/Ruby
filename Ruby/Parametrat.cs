using System.Configuration;

namespace Ruby
{
    class Parametrat
    {

        public static string _KonektimiDB = ConfigurationManager.ConnectionStrings["KonektimiDB"].ToString();
    }
}
