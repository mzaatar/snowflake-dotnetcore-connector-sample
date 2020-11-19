using System;
using System.Data;
using Snowflake.Data.Client;

namespace snowflake_dotnet_connector_sample
{
   class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Snowflake dotnet connector ----------------");
            using (var con = new SnowflakeDbConnection())
            {
                con.ConnectionString = "account={ACCOUNT_NAME};host={HOSTNAME}.snowflakecomputing.com;user={USERNAME};password={PASSWORD};db={DBNAME};role={ROLE};";

                con.Open();

                IDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "select CURRENT_REGION();";
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                }
            }
            Console.WriteLine("Bye Snowflake dotnet connector ----------------");
        }
    }
}
