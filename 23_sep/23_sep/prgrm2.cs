using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_sep
{
    internal class prgrm2
    {
        /* use Northwind

         create view products101 as
        Select ProductID,ProductName,UnitPrice from products;*/
        static void Main(string[] args)
        {
            string connstring = @"Data Source=DESKTOP-974787H\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand sq = new SqlCommand("Select * from Products101", conn);
            conn.Open();
            SqlDataReader sl = sq.ExecuteReader();
            while (sl.Read())
            {

                Console.Write($"{sl["ProductID"]},{sl["ProductName"]},{sl["UnitPrice"]}\n");
            }
            conn.Close();
            Console.Read();
        }
    }
}
