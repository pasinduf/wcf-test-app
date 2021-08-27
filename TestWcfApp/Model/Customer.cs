using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TestWcfApp.Model
{
    [DataContract(Name = "Custm")]
    public class Customer
    {
        [DataMember(Name = "FirstName")]
        public string FName { get; set; }

        [DataMember(Name = "LastName")]
        public string LName { get; set; }
    }
}