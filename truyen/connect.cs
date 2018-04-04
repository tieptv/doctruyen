using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace truyen
{
    class connect
    {
        public SqlConnection conDB() {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MI7H9MA\SQLEXPRESS;Initial Catalog=OOP;User ID=sa;Password=123");
        return con;
        
          }
    }
}
