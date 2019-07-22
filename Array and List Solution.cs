using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(String[] args)
        {
          var names = new List<String>();
            while(true)
            {
                Console.WriteLine("Enter the name or whitespaces to get out from loop");
                var name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                    break;
                names.Add(name);
            }
            var len = names.Count;
            if(len<=0)
                Console.WriteLine();
            else if (len == 1)
                Console.WriteLine(names[0]+" likes your post");
            else if(len==2)
                Console.WriteLine(names[0]+" and " +names[1] + " like your post");
            else
                Console.WriteLine(names[0]+", "+names[1]+" and "+(len-2) + " others like your post");
        }
    }
}
