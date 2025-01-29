using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    //Static => No Create Object (Instance) 
    //Because I take object to give error.

    public static class RectangleExtension
    {
        public static int CalculatePermetier(this Rectangle rec)
        {
            return 2* (rec.Width + rec.Height);
        }
    }
}
