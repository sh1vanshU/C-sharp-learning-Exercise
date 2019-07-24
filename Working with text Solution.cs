/*
            //Working with text solution
            //1. Solution
            var numbers = new List<int>();
            Console.WriteLine("Enter the number in consecutive order (eg:  1-2-3-4-5)");
            var str = Console.ReadLine().Split('-');
            foreach (var i in str)
            {
                numbers.Add(Convert.ToInt32(i));
            }
            bool flag = false;
            numbers.Sort();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] != numbers[i + 1] - 1)
                {
                    flag = true;
                    break;
                }


            }
            var msg = flag == true ? "Non Consecutive" : "Consecutive";
            Console.WriteLine(msg);
            //2.Solution
            Console.WriteLine("Enter the number Few Numbers (eg:  1-2-3-4-5)");
            var numbers1= Console.ReadLine();
            if (String.IsNullOrEmpty(numbers1))
                return;
            var unique = new List<int>();
            foreach(var num in numbers1.Split('-'))
            {
                if(!unique.Contains(Convert.ToInt32(num)))
                    unique.Add(Convert.ToInt32(num));
                else
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
            }
            //3. Solution
            Console.WriteLine("Enter the time value in format 24-hour time (eg: 19:00)");
            var time = Console.ReadLine();
            if(String.IsNullOrEmpty(time)|| String.IsNullOrWhiteSpace(time))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            var Time = time.Split(':');
            var hours = Convert.ToInt32(Time[0]);
            var min = Convert.ToInt32(Time[1]);
            if(hours>=0 && hours<=23 && min>=0&& min<=59)
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid Time");
            
            //4. Solution
            Console.WriteLine("Enter Few Words  seperated by space");
            var words = Console.ReadLine();
            var format = "";
            if(string.IsNullOrEmpty(words)|| string.IsNullOrWhiteSpace(words))
            {
                Console.WriteLine("Invalid String");
                return;
            }
            foreach (var word in words.Split(' '))
            {
                format += char.ToUpper(word[0]) + word.ToLower().Substring(1);
            }
            Console.WriteLine(format);
            */
