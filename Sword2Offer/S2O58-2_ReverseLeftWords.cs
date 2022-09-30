using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    public class S2O58_2_ReverseLeftWords : Singleton<S2O58_2_ReverseLeftWords>
    {
        public string ReverseLeftWords(string s, int n)
        {     
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(s[i]);
            }
            return s.Substring(n) + sb.ToString();
        }
    }
}
