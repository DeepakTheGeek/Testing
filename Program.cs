using MongoDB.Bson;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var Amount = "20890785.923545";
            //${0:#,0.00}
            //Amount = String.Format("({0:C})", Convert.ToDouble(Amount.Replace("-", "")));
            Amount = Convert.ToDouble(Amount.Replace("-", "")).ToString("C", CultureInfo.GetCultureInfo("en-us"));
            Console.WriteLine(Amount);
            Console.ReadLine();
        }
    }
}
