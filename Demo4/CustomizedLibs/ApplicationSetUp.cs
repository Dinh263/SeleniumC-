using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.CustomizedLibs
{
    class ApplicationSetUp
    {
        public static string getCurrentApplicatonPath()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            return path.Substring(0, path.IndexOf("bin"));
        }


    }
}
