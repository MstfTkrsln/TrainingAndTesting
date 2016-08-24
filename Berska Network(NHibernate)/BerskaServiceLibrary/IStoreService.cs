using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Messages;

namespace BerskaServiceLibrary
{
    
    [ServiceContract]
    public interface IStoreService
    {
        [OperationContract]
        SaveResponse SaveStore(SaveRequest request);

        //[OperationContract]
        //SaveResponse SaveProduct(SaveRequest request);


    }
    
}
