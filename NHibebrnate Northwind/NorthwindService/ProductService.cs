using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dao;
using Entities;
using Messages;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ProductService : IProductService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Messages.SaveResponse Save(Messages.SaveRequest request)
        {
            //nhiberane request.Imte
            IDao<Person> personDao = new Dao<Person>();
            personDao.Save(request.Item);
            SaveResponse respnose=new SaveResponse();
            respnose.Result = true;
            respnose.Item = request.Item;
            return respnose;
        }
    }
}
