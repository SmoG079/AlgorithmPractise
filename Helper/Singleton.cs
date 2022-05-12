using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Helper
{
    public class Singleton<T> where T : class
    {
        private volatile static T _instance;
        private static object initObj = new object();
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (initObj)
                    {
                        if (_instance == null)
                        {
                            _instance = (T)Activator.CreateInstance(typeof(T), true);
                        }
                    }
                }
                return _instance;
            }
        }
    }
    
}
