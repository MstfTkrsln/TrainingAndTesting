using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Runtime.Serialization;
using Surrogates;

namespace NorthwindServiceLibrary
{
    [ServiceContract]
   public interface IEmployeeService
    {
        [OperationContract]
        SurrogateEmployee[] GetEmployees();

    }
}
