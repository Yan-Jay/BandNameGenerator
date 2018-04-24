using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    public class kata
    {
        public string BandNameGenerator(string str)
        {
            str = str.Trim();
            string ans = "";
            if (str.Substring(0,1) == str.Substring(str.Length - 1, 1))
            {
                ans = str.Substring(0,1).ToUpper() + str.Substring(1) + str.Substring(1);
            }
            else
            {
                ans = "The " + str.Substring(0, 1).ToUpper()+str.Substring(1);
            }
            return ans;
        }
    }
}
