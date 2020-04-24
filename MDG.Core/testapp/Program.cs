using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDG.Core;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.AddInfo("Test log to info.");
            Log.AddInfo("Test log 2 to info.");
            JobNumber.TryParse("1901001");
            JobNumber.TryParse("1901002", out _, JobNumber.JobNumberFormats.LongHyphan);
            Log.AddError("Someone dun fucked up.");
            Console.ReadKey();
        }
    }
}
