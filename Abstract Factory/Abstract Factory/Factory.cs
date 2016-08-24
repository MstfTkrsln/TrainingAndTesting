using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    class Factory:IFactory
    {
        private IConnection _connection;
        private ICommand _command;

        public IConnection CreateConnection()
        {
            if (ConfigurationSettings.AppSettings["FactoryType"] == "Database")
            {
                return new DatabaseConnection();
            }
                
            if (ConfigurationSettings.AppSettings["FactoryType"] == "Ftp")
            {
                return new FtpConnection();
            }

            Console.WriteLine("***ERROR***");
            return null;
        }

        public ICommand CreateCommand()
        {
            if (ConfigurationSettings.AppSettings["FactoryType"] == "Database")
            {
                return new DatabaseCommand();
            }

            if (ConfigurationSettings.AppSettings["FactoryType"] == "Ftp")
            {
                return new FtpCommand();
            }

            Console.WriteLine("***ERROR***");
            return null;
        }

        public Factory()
        {
            _connection=CreateConnection();
            _command=CreateCommand();
        }

        public void Start()
        {
            _connection.Connect();

            if (_connection.State)
            {
                _command.Execute("select * from");
            }
            
            _connection.Disconnect();
        }
    }
}
