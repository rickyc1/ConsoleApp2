using System;

namespace DemoLibrary
{
    public class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("DataAccess.LoadData call.");
        }

        public void SaveData()
        {
            Console.WriteLine("DataAccess.SaveData call.");
        }


    }
}