using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{

    public class BetterBusinessLogic : IBusinessLogic
    {

        ILogger _log;
        IDataAccess _da;

        public BetterBusinessLogic(ILogger log, IDataAccess da)
        {
            _log = log;
            _da = da;
        }

        public void ProcessData()
        {

            _log.Log("BetterBsuinessLogic Starting the process of data.");
            Console.WriteLine("BetterBsuinessLogic Processing the data");

            _da.LoadData();
            _da.SaveData();
            _log.Log("BetterBsuinessLogic Finished processing of the data.");
        }
    }

}
