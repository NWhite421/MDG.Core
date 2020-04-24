using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDG.Core;
using System.Windows.Forms;

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
            var form = new StringInput("This is a test of the Message only dialog option.");
            var ret = form.ShowDialog();
            if (ret.Equals(DialogResult.OK))
            {
                Console.WriteLine(form.Input);
            }
            form = new StringInput("This is a sample StringInput dialog. You can enter\n\nmultiple lines.", "Sample Dialog");
            ret = form.ShowDialog();
            if (ret.Equals(DialogResult.OK))
            {
                Console.WriteLine(form.Input);
            }
            form = new StringInput("This is a test of a dialog with a preset value", "Sample Dialog");
            form.SetDefaultInput("Default input");
            ret = form.ShowDialog();
            if (ret.Equals(DialogResult.OK))
            {
                Console.WriteLine(form.Input);
            }

            Console.ReadKey();
        }
    }
}
