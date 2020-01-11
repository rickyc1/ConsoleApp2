using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class User
    {
        IDAL dal;

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Address { get; set; }

        public bool isValid
        {
            get { return true; }
        }

        public User(IDAL idal)
        {
            dal = idal;
        }

        public void Add()
        {
            if (isValid)
            {
                dal.Add(this);
            }
        }
    }
}
