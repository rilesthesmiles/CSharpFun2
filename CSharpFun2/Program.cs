using System;


namespace CSharpFun2
{
    public static class Program
    {
        public static void Main (string[] args)
        {
            PrintStuffClass ps;
            string ?userName = "";
            string ?languageSpoken = "";
            Console.WriteLine("What language do you speak?");
            languageSpoken = Console.ReadLine();
            Console.WriteLine("Please enter your name");
            userName = Console.ReadLine();

            ps = new PrintStuffClass(languageSpoken);

            ps.PrintMyName(userName);
            

        }

        
    }
}
