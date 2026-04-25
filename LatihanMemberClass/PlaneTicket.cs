using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    public class PlaneTicket
    {
            // fields (private)
            private string _origin;
            private string _destination;
            private double _cost;
            private string _currency;

            // properties (auto-implemented)
            public string Origin { get; set; }
            public string Destination { get; set; }
            public double Cost { get; set; }
            public string Currency { get; set; }

            // method
            public void PrintSummary()
            {
                const double USD_TO_IDR = 15000;
                Console.WriteLine("Origin: {0}", Origin);
                Console.WriteLine("Destination: {0}", Destination);
                Console.WriteLine("Cost: {0} ({1})", Cost, Currency);

                if (Currency == "USD")
                {
                    double rupiah = Cost * USD_TO_IDR;
                    Console.WriteLine("Convert to Rupiah: {0}", rupiah);
                }
                else if (Currency == "IDR")
                {
                    double dolar = Cost / USD_TO_IDR;
                    Console.WriteLine("Convert to Dolar: {0}", dolar);
                }
            }
        

    }
}
    

