using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GDMJ_Library
{
    public static class OneFirstRun
    {
        /// <summary>
        /// Воврощает True если программа запущина в первый раз
        /// </summary>
        /// <returns>Воврощает True если программа запущина в первый раз</returns>
        public static bool Run()
        {
            if (!File.Exists("Data\\Not_delete\\Not_delete"))
            {
                Directory.CreateDirectory("Data\\Not_delete");
                File.Create("Data\\Not_delete\\Not_delete");
                return true;
            }
            return false;
        }

        internal static bool Run(string name)
        {
            if (!File.Exists("Data\\Not_delete\\" + name))
            {
                Directory.CreateDirectory("Data\\Not_delete");
                File.Create("Data\\Not_delete\\" + name);
                return true;
            }
            return false;
        }
    }
}
