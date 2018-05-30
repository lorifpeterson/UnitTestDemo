using System.Collections.Generic;

namespace UnitTestDemo.Outlet
{
    public interface IOutletDao
    {
        string DataSource { get; }
        IList<string> GetData();
    }
}
