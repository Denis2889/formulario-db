using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TABLA_PRODUCTOS
{
    class varpublic
    {
        public static SqlConnection cadconex = new SqlConnection("Server=(local); Database=Northwind; Integrated Security=true");
    }
}
