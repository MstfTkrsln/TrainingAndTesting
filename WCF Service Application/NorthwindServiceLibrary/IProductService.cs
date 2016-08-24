using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SurrogeteLibrary;

namespace NorthwindServiceLibrary
{
    [ServiceContract(Name ="NorthwindProductService",Namespace = "http://www.northwind.com/services/productservices")]
    interface IProductService
    {
        [OperationContract]
        SurrogateProduct[] GetProducts(int categoryId);

        [OperationContract]
        SurrogateProduct[] GetProductByName(string firstLetter);
    }
}
