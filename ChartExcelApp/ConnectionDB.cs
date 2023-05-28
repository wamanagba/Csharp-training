using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChartExcelApp
{
    class ConnectionDB
    {
        public string GetConnection()
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oyaco\source\RepositoryLast\ChartExcelApp\DataB.mdf;Integrated Security=True";
            return con;
        }
    }
}
