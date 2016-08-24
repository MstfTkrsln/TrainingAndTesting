using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace Dao
{
    public class DaoModel<T> : IDaoModel<T>
    {
        private Configuration config;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public DaoModel()
        {
            config = new Configuration();

            config.Configure(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\Berska Network(NHibernate)\Dao\App.config");

            mySessionFactory = config.BuildSessionFactory();

            mySession = mySessionFactory.OpenSession();
        }

        ~DaoModel()
        {
            mySessionFactory.Dispose();
            mySession.Dispose();
            
        }

        public void Save(T item)
        {
            using (ITransaction tran = mySession.BeginTransaction())
            {
                mySession.Save(item);

                tran.Commit();
            }
        }
    }
}
