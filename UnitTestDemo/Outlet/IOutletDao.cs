using System.Collections.Generic;

namespace Cision.UnitTestDemo.Outlet
{
    public interface IOutletDao
    {
        string DataSource { get; }
        IList<string> GetData();
    }
}