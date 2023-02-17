using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linije_73_2019
{
    public class DbConnection
    {
        private static SqlConnection _connection = null;
        private static readonly object key = new object();

        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    lock (key)
                        if(_connection == null)
                            _connection = new SqlConnection(@"Data Source=(localdb)\linija; Initial Catalog = rezultati; Integrated Security = True");
                }
                return _connection;
            }
        }
    }
}
