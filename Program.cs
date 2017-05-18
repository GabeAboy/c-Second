using System;


namespace loops
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            /*
			Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
			Display the count on the console.
			*/
            // int count = 0;
            // int counter = 0;
            // const int limit = 100;
            // for (var i = 1; i<=limit; i++) {
            //   if(i%3==0){
            //     count++;
            //   }else counter++;
            // }
            // Console.WriteLine("Numbers divisible by 3 under 100 "+count);
            // Console.WriteLine(counter);

            /*
			Write a program and continuously ask the user to enter a number or "ok" to exit.
			Calculate the sum of all the previously entered numbers and display it on the console.
			*/
            //        string x="";
            //        int e = 232;
            //        System.Type type = e.GetType();
            //        if(type == Int32)
            //            Console.WriteLine(type);
            //        while(x!="ok"){
            //Console.WriteLine("Enter a character: ");
            //x = (string)Console.ReadLine();


            //            //if(typeof(Int32.Parse(x)) ){
            //            //    Console.ReadLine(false);
            //            //}
            //Console.WriteLine();    
            //}
            //Console.WriteLine("exit");

            /*

                
                Write a program that picks a random number between 1 and 10.
                Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; 
                otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            */
            //var random = new Random();
            //bool win = true;
            //int count = 1;
            //while(win){
            //    Console.WriteLine("Guess a number 1-10, you have 3 tries...");
            //    var n = random.Next(1, 10);
            //    Console.WriteLine(n);
            //    var user = Int32.Parse(Console.ReadLine());
            //    if (user == n)
            //    {
            //        Console.WriteLine("Winner:" + n);
            //        break;
            //    }
            //    else if(count == 3){
            //        Console.WriteLine("You lose");
            //        win = false;
            //    }
            //    else{
            //        count++;
            //    }
            //}
            //Console.WriteLine("Game terminated");
            /*
                 Write a program and ask the user to enter a series of numbers separated by comma. 
                 Find the maximum of the numbers and display it on the console. 
                 For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            */
            Console.WriteLine("Enter a series of numbers separated by comma");
            string series = Console.ReadLine();
            string list = string.Join(",", series);
            Console.WriteLine(list);

		}
	}
}
