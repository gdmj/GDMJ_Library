using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GDMJ_Library
{
    public class OneFirstRun
    {
        /// <summary>
        /// Воврощает True если программа запущина в первый раз
        /// </summary>
        /// <returns>Воврощает True если программа запущина в первый раз</returns>
        public bool Run()
        {
            if (!File.Exists("Not_delete"))
            {
                File.Create("Not_delete");
                return true;
            }
            return false;
        }
    }
}
