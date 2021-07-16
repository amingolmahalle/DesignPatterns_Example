using System;

namespace Singleton
{
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection _instance;

        private static readonly object Lock = new object();

        private DatabaseConnection()
        {
            //TODO: Enter the code to connect to the database here.
        }

        public static DatabaseConnection GetInstance()
        {
            if (_instance != null)
                return _instance;

            lock (Lock)
            {
                Console.WriteLine("* create new Instance! *");

                _instance ??= new DatabaseConnection();
            }

            return _instance;
        }

        public string GetQuery(string query)
        {
            return $"execute {query}";
        }
    }
}