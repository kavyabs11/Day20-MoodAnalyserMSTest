using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserMSTest
{
    internal class MoodAnalyser
    {
       
            public void analyseMood(string message)
            {
                if (message.ToUpper().Contains("SAD"))
                    Console.WriteLine("The user mood is SAD");
                else
                    Console.WriteLine("The user mood is HAPPY");
            }
        }
}
