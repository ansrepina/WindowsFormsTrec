using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrec
{
    public class MySQLDataBase
    {
        MySqlConnection connectio = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=");
    }
}
