using System;

namespace FactoryPatternExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database would you like to use (List, SQL, Mongo)?");
            var input = Console.ReadLine().ToLower();
            IDataAccess databaseType = DataAccessFactory.GetDataAccessType(input);
            databaseType.LoadData();
            databaseType.SaveData();
        }
    }
}
