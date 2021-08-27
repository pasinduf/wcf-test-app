using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TestWcfApp.Model;

namespace TestWcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TestProxy" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TestProxy.svc or TestProxy.svc.cs at the Solution Explorer and start debugging.
    public class TestProxy : ITestProxy
    {
        public void DoWork()
        {
        }

        public string GetAge(int age)
        {
            return $"age: {age}";
        }

        public string GetCustomerFullName(Customer cust)
        {
            return cust.FName + " " + cust.LName;
        }
    }
}
