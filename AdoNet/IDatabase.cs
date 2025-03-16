using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    internal interface IDatabase
    {
        string ConnectionString { get; set; }
    }
}
