using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TestWcfApp.Model;

namespace TestWcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITestProxy" in both code and config file together.
    [ServiceContract]
    public interface ITestProxy
    {
        [OperationContract]
        void DoWork();

        [OperationContract(Name ="getName")]
        string GetCustomerFullName(Customer cust);

        [OperationContract(Name ="getAge")]
        string GetAge(int age);
    }
}
