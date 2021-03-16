using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class DalAcces
    {
        //connection to mysql
        public MySqlConnection conn;
        public DalAcces()
        {
            conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi419727;Database=dbi419727;Pwd=test;");
        }
    }
}
