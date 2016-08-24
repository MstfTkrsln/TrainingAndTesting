using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FacadeLayer
{
    class Connection
    {
        public readonly static SqlConnection Conn=new SqlConnection("SERVER=.;DATABASE=Kutuphane;INTEGRATED SECURITY=TRUE");
    }
}
