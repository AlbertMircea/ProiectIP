using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ExempluDB
{
     
    public class ConectareDB
    {
        MySqlConnection sql;
        public void conectare()
        {
            sql = new MySqlConnection();
            sql.ConnectionString = @"Server=34.88.143.209;Database=proiect_robot;Uid=root;Pwd=Admin123";
        }
        public MySqlConnection getConnection() // preia conexiunea
        {
            return sql;
        }

    }
}