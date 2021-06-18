using System;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("First Call:");
            DatabaseConnection dbConn1 = DatabaseConnection.GetInstance();
            string result1 = dbConn1.GetQuery("query1");
            Console.WriteLine(result1);
            Console.WriteLine();

            Console.WriteLine("Second Call:");
            DatabaseConnection dbConn2 = DatabaseConnection.GetInstance();
            string result2 = dbConn2.GetQuery("query2");
            Console.WriteLine(result2);
            Console.WriteLine();

            Console.WriteLine("Third Call:");
            DatabaseConnection dbConn3 = DatabaseConnection.GetInstance();
            string result3 = dbConn3.GetQuery("query3");
            Console.WriteLine(result3);
            Console.WriteLine();

            Console.WriteLine(dbConn1 == dbConn2);
            Console.WriteLine(dbConn1 == dbConn3);
            Console.WriteLine(dbConn2 == dbConn3);
        }
    }
}