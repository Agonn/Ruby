using System.Configuration;
using System.Windows.Forms;

namespace Ruby
{
    class Parametrat
    {

        public static string _KonektimiDB = ConfigurationManager.ConnectionStrings["KonektimiDB"].ToString();

       static  string folder = Application.StartupPath;

        string[] DataSakt = folder.Split(new char[] { '/' });

    }
}
