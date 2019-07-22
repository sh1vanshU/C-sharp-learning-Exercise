using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // 1.Solution
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
            // 2. solution
            Console.WriteLine("Enter Your Name");

            var name = Console.ReadLine();
            var names = new char[name.Length];
            
            for(var i=name.Length;i>0;i--)
            {
                names[name.Length - i] = name[i-1];

            }
            var reverseName = new String(names);
            Console.WriteLine("Reverse name is: "+reverseName);
            //3. solution
            var numbers = new List<int>();
            Console.WriteLine("Enter Five numbers ");
            for(int i=0;i<5;i++)
            {
                var number =Convert.ToInt32(Console.ReadLine());
                if(numbers.Contains(number))
                {
                    Console.WriteLine("Ahha! You nigga Already entered this number, Dude try again once");
                    i--;
                }
                else
                {
                    numbers.Add(number);
                }

            }
            numbers.Sort();
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
            // 4. solution
            var numbers = new List<int>();
            while(true)
            {
                Console.WriteLine("Enter the numbers or type Quit for execution of program");
                var number = Console.ReadLine();
                if (number.ToLower()=="quit")
                    break;
                numbers.Add(Convert.ToInt32(number));
            }
            var uniqueList = new List<int>();
            foreach(var num in numbers)
            {
                if (!uniqueList.Contains(num))
                    uniqueList.Add(num);
            }
            foreach(var num in uniqueList)
            {
                Console.WriteLine(num);
            }
            // 5. Solution
            var list = new List<int>();
            Console.WriteLine("Provide a list of comma separated numbers");
            while(true)
            {
                var numbers = Console.ReadLine();
                var arr = numbers.Split(',');
                if (arr.Length >=5)
                {
                    foreach (var i in arr)
                    {
                        list.Add(Convert.ToInt32(i));

                    }
                    list.Sort();
                    Console.WriteLine("{0},{1} and {2}",list[0],list[1],list[2]);
                    break;
                }
                Console.WriteLine("Invalid List ! Re-try");

                
            }
              
        }
    }
}
