using UnitTestDemo.Dao;
using UnitTestDemo.Outlet;
using UnitTestDemo.Web.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using StructureMap;

namespace UnitTestDemo.Web.Tests
{
    [TestClass()]
    public class BootstrapTest
    {
        [TestMethod]
        public void SetupIoC_TestProfile_MockOutletDao()
        {
            Bootstrap.SetupIoC();
            ObjectFactory.Profile = "Test";

            var item = ObjectFactory.GetInstance<IOutletDao>();
            Assert.IsInstanceOfType(item, typeof(MockOutletDao));
        }
    
        [TestMethod]
        public void SetupIoC_RealProfile_OutletDao()
        {
            Bootstrap.SetupIoC();
            ObjectFactory.Profile = "Real";

            var item = ObjectFactory.GetInstance<IOutletDao>();
            Assert.IsInstanceOfType(item, typeof(OutletDao));
        }

    }
}
