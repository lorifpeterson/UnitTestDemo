using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cision.UnitTestDemo.Customer
{
    public class MockSecurityService : ISecurityService
    {
        public bool HasAccess(long userId)
        {
            return true;
        }
    }
}
