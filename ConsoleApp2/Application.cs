using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Application : IApplication
    {
        IBusinessLogic _buinsessLogic;
        public Application(IBusinessLogic businessLogic)
        {
            _buinsessLogic = businessLogic;

        }

        public void Run()
        {
            _buinsessLogic.ProcessData();
        }

    }


}
