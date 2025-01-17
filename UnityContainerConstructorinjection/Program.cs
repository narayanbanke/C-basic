﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UnityContainerConstructorinjection
{
    class Program
    {
        public interface ICar
        {
            int Run();
        }
        public class BMW : ICar
        {
            private int _miles = 2;

            public int Run()
            {
                return ++_miles;
            }
        }
        public class Ford : ICar
        {
            private int _miles = 0;
            public int Run()
            {

                return ++_miles;
            }
        }      
        public class Driver
        {
            private ICar _car = null;

            public Driver(ICar car)
            {
                _car = car;
            }

            public void RunCar()
            {
                Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
            }
        }
        static void Main(string[] args)
        {
            var BMWcontainer = new UnityContainer();
           //  var Fordcontainer = new UnityContainer();
            BMWcontainer.RegisterType<ICar, BMW>();
           //  Fordcontainer.RegisterType<ICar, Ford >();
            var BMWdriver = BMWcontainer.Resolve<Driver>();
            //   var Forddriver = Fordcontainer.Resolve<Driver>();
           
            BMWdriver.RunCar();
           // Forddriver.RunCar();
            



        }
    }
}
