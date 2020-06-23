using MongoDB.Bson;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject DTO = null;
           string a = DTO.ToJson();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
