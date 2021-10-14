using System;

namespace FactoryPatternExercise02
{
    public class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from Mongo");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from Mongo");
        }
    }
}
