using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDMJ_Library.Tools
{
    public static class Exception
    {
        public static void New(string ExText)
        {
            throw new System.Exception(ExText);
        }

        public static void New(string ExText, bool _True)
        {
            if (_True)
            {
                throw new System.Exception(ExText);
            }
        }
    }

}
