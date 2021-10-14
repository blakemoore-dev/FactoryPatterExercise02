using System;

namespace FactoryPatternExercise02
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from List");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from List");
        }
    }
}
