using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cision.UnitTestDemo.Outlet;

namespace Cision.UnitTestDemo.Dao
{
    public class MockOutletDao : IOutletDao
    {
        public IList<string> GetData()
        {
            return new List<string>()
                       {
                           "test outlet 1",
                           "test outlet 2",
                           "test outlet 3"
                       };
        }

        public string DataSource { get { return "Fake Outlets"; }
        }
    }
}
