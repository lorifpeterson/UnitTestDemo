using System.Collections.Generic;

namespace Cision.UnitTestDemo.Outlet
{
    public class OutletDao : IOutletDao
    {
        public IList<string> GetData()
        {
            // TODO:  replace with a real data source
            return new List<string>()
                       {
                           "BBC Radio Suffolk News",
                           "Shropshire United",
                           "Surfin' the 70s",
                           "Sunday Breakfast Show",
                           "Action Desk",
                           "Football Heaven (Sheffield)",
                           "Dean Pepall",
                           "Wesley Smith",
                           "BBC Radio Oxford News",
                           "Colin Young's Lunchbox",
                           "Jo Thoenes",
                           "Eastern Air",
                           "Stuart George",
                           "Trunk of Funk Soul Show",
                           "Irish Eye"
                       };
        }

        public string DataSource
        {
            get { return "Real Outlets"; }
        }
    }
}
