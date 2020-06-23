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
            //IEnumerable<object> v3 = new List<object>();
            var v3 = new List<object>();
            v3.Add(new { Store = "0609F9", vendor = "AMP BUCKS UAT", accrual = 341.00, date = "02/23/2020" });
            v3.Add(new { Store = "0609F9", vendor = "AMP BUCKS UAT", accrual = 341.00, date = "02/23/2020" });
            v3.Add(new { Store = "0609F9", vendor = "AMP BUCKS UAT", accrual = 341.00, date = "02/23/2020" });
            v3.Add(new { Store = "0609F9", vendor = "AMP BUCKS UAT", accrual = 341.00, date = "02/23/2020" });
            v3.Add(new { Store = "0609F9", vendor = "AMP BUCKS UAT", accrual = 350.00, date = "02/24/2020" });
            v3.Add(new { Store = "0609F9", vendor = "AMP BUCKS UAT", accrual = 360.00, date = "02/25/2020" });

            IEnumerable<object> v4 = v3;

            var duplicates = v4.GroupBy(x => x).Where(x => x.Count() >= 4).Select(x => new { Element = x.Key, ElementCount = x.Count() }).ToList();

            v4.Where(x => x.Equals(duplicates[0]));

            var validPrograms = (from acc in v3
                                 join mfa in duplicates
                                 on acc equals mfa
                                 select acc
                                  ).ToList().Distinct();

            foreach (var dup in duplicates)
            {
                var dup_rec = v4.Where(x => x.Equals(dup.Element)).ToList();
                v4.ToList().RemoveAll(x => x.Equals(dup.Element));
                dup_rec = dup_rec.Skip(dup.ElementCount / 2).ToList();
                v4.ToList().AddRange(dup_rec);
            }
        }
    }
}
