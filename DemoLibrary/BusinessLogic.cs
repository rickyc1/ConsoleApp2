using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _log;
        IDataAccess _da;
        public BusinessLogic(ILogger log, IDataAccess da)
        {
            _log = log;
            _da = da;
        }
        public void ProcessData()
        {
           
            _log.Log("Starting the process of data.");
            Console.WriteLine("Processing the data");

            _da.LoadData();
            _da.SaveData();
            _log.Log("Finished processing of the data.");
        }


    }
}
