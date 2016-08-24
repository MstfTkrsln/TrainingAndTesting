using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    interface IConnection
    {
        void Connect();
        void Disconnect();
        bool State { get; }
    }
}
