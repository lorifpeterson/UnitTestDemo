using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDemo
{
    [TestClass]
    public class GuidTests
    {
        [TestMethod]
        public void StringToGUID_SameStringValues_CreatesSameGuids()
        {
            Guid guidId1 = StringToGUID("1234");
            Guid guidId2 = StringToGUID("1234");

            Assert.AreEqual(guidId1, guidId2);
        }

        [TestMethod]
        public void StringToGUID_DifferentStringValues_CreatesUniqueGuids()
        {
            Guid guidId1 = StringToGUID("1234");
            Guid guidId2 = StringToGUID("12345");

            Assert.AreNotEqual(guidId1, guidId2);
        }

        private static Guid StringToGUID(string value)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(value));
            return new Guid(data);
        }
    }
}
