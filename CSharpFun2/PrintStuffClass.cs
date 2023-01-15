using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFun2
{
    class PrintStuffClass
    {
        private string language = "";
        public PrintStuffClass(string temp)
        {
            language = temp;
        }
        public void PrintMyName(string inputName)
        {
            if (language == "EN") {
                Console.WriteLine("Hello " + inputName);
            }

            if (language == "PI")
            {
                Console.WriteLine("Oi " + inputName);
            }
        }
    }
}
