using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace otacletest2
{
    class Program
    {
        
        


        static void Main(string[] args)
        {
            string conString = "User Id=hr;Password=hr;Data Source=localhost:1521/XE;";

            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;

            con.Open();

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select first_name from employees where department_id = 90";

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Nome do funcionário: " + reader.GetString(0));

            }

            con.Close();

            Console.WriteLine();
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();

        }
    }
}
