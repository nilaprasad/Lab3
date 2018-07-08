using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG655_Lab3
{
    class Program
    {
        interface ITest
        {
            String dMeasurement { get; set; }
            int testno { get; set; }
            //Method to compute next available test
            DateTime NextTest();
        }

        class Device
        {
            string DeviceDescription
            {
                get { return DeviceDescription; }
                set { DeviceDescription = value; }
            }
            int DeviceSerialNo
            {
                get { return DeviceSerialNo; }
                set { DeviceSerialNo = value; }
            }
            DateTime DeviceTest
            {
                get;
                set;
            }  
        }

        class TestDevice : Device, ITest
        {
            public string dMeasurement
            {
                get
                {
                    return dMeasurement;
                }
                set
                {
                    dMeasurement = value;
                }
            }
            
            public int testno
            {
                get
                {
                    return testno;
                }
                set
                {
                    testno = value;
                }
            }

            DateTime CurrentTime;
            //For form class
            static TestDevice()
            {
                DateTime CurrentDateTime;
                CurrentDateTime = DateTime.Now;
                Console.WriteLine("Today is: {0}", CurrentDateTime.ToLongTimeString());
            }
            public DateTime NextTest()
            {
                testno = 12 / testno;
                return this.CurrentTime;
            }            
        }
        static void Main(string[] args)
        {
            TestDevice obj = new TestDevice();
            Console.WriteLine("Enter the measurements of the device you are testing =>");
            obj.dMeasurement = Console.ReadLine();
            Console.WriteLine("Enter the number of tests required for this year =>");
            obj.testno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The next test for this device is =>");
            obj.NextTest();
        }

    }
}
