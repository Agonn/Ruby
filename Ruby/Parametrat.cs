using System.Configuration;
using System.Windows.Forms;

namespace Ruby
{
    class Parametrat
    {



       static  string folder = Application.StartupPath;

       static string[] data = folder.Split('\\');

        string strPerKonektim = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + data[0] + "\\" + data[1] + "\\" + data[2] + "\\" + data[3] + "\\" + data[4] + "\\" + data[5] + "\\" + data[6] + "\\RubyDB.mdf" + ";Integrated Security=True;"+" providerName="+"System.Data.SqlClient";

        public static string _KonektimiDB = ConfigurationManager.ConnectionStrings["KonektimiDB"].ToString();
    }
}
