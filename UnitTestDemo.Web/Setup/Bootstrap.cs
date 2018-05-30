using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTestDemo.Dao;
using UnitTestDemo.Outlet;
using StructureMap;

namespace UnitTestDemo.Web.IoC
{
    public static class Bootstrap
    {
        public const string TestProfile = "Test";
        public const string RealProfile = "Real";

        public static void SetupIoC()
        {
            SetupIoC(RealProfile);
        }

        public static void SetupIoC(string profile)
        {
            if(string.IsNullOrWhiteSpace(profile))
            {
                throw new ArgumentException("Profile was not specified and is required!");
            }

            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());

            ObjectFactory.Initialize(
                x =>
                {
                    x.Scan(scanner =>
                               {
                                   scanner.TheCallingAssembly();
                                   scanner.WithDefaultConventions();
                                   //scanner.AddAllTypesOf<Controller>();  //TODO: remove when done
                                   
                               }
                        );
                    //x.SetAllProperties(s => s.OfType<>());
                    x.Profile("Test").For<IOutletDao>().Use<MockOutletDao>();
                    x.Profile("Real").For<IOutletDao>().Use<OutletDao>();

                }
            );
            ObjectFactory.Profile = profile;
        }

    }
}
