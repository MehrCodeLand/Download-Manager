using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApllication.Extra
{
    public class OpenLink
    {
        public static void OpenUrl(string url)
        {
            Process pro = new Process();
            pro.StartInfo.FileName = url;
            pro.StartInfo.UseShellExecute = true;
            pro.Start();
        }
    }
}
