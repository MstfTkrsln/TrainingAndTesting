using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dao;
using Entities;
using Messages;

namespace BerskaServiceLibrary
{

    public class StoreService : IStoreService
    {
        public SaveResponse SaveStore(SaveRequest request)
        {
            IDaoModel<BaseEntity> StoreDao =new DaoModel<BaseEntity>();

            StoreDao.Save(request.store);

            SaveResponse saveResponse=new SaveResponse(){Result = true};

            return saveResponse;
        }


        //public SaveResponse SaveProduct(SaveRequest request)
        //{
        //    IDaoModel<Product> ProductDao=new DaoModel<Product>();

        //    ProductDao.Save(request.product);

        //    SaveResponse saveResponse=new SaveResponse(){Result = true};

        //    return saveResponse;
        //}
    }
}
