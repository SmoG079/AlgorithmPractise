using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    public class S2O05_ReplaceSpace : Singleton<S2O05_ReplaceSpace>
    {
        public string ReplaceSpace(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var stringChar in s)
            {
                if (stringChar.Equals(" "))
                {
                    stringBuilder.Append("%20");
                }
                else {
                    stringBuilder.Append(stringChar);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
