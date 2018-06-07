using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNLog
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var config = new NLog.Config.LoggingConfiguration();
                var logger = NLog.LogManager.GetLogger("AppLogDate");


                //for (int i = 0; i < 10000; i++)
                //{
                    if(logger.IsErrorEnabled)
                        logger.Error(DateTime.Now+"\n");
                //}

                Console.WriteLine("pause");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }



        }
    }
}
