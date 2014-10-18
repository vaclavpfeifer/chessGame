using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    namespace Utility
    {
        public class Logger
        {
            private static Logger _instance;
            private string _fileName = "default.log";

            public string FileName
            {
                get { return _fileName; }
                set { _fileName = value; }
            }

            public static Logger INSTANCE()
            {
                if(null == _instance)
                {
                    _instance = new Logger();
                }
                return _instance;
            }

            private Logger() { }

            public void log(string msg)
            {
                Console.WriteLine(msg);

                // Add write to log
            }

        }
    }
}
