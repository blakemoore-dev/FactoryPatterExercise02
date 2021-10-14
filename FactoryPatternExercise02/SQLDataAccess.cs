using System;

namespace FactoryPatternExercise02
{
    public class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from SQL");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from SQL");
        }
    }
}
