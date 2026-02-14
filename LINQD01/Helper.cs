using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD01
{
    public class Helper
    {
        /*------------------------------------------------------------------*/
        public static int GetWordsCount(string str)
        {
            if(!string.IsNullOrEmpty(str))
            {
                int count = str.Split(' ').Length;
                return count;
            }
            return 0;
        }
        /*------------------------------------------------------------------*/
    }
}
