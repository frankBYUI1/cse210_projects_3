using System;

class Program
{
    static void Week01()
    {
        // ----------------------------------------------------------------
        // data types
        // https://www.w3schools.com/cs/cs_data_types.php 

        int x = 9;
        int y = 0;

        // ----------------------------------------------------------------
        int age = 34;
        if (age >=18)
        {
            System.Console.WriteLine("Yes can vote");
        }
        else
        {
            System.Console.WriteLine("Can not vote");
        }

        //  ----------------------------------------------------------------
        // AND, OR and NOT operators 
        // &&, ||, !
        if ((3 < 5) && (4 >=8) && !happy);
        {

        }
        // ----------------------------------------------------------------
        // While loops
        // input = "yes" 
        // while input == yes:
        //      input = prompt("Do you want to continue? ");

        int x = 0;
        while (x < 10)
        {
            System.Console.WriteLine(x);
            x++;
        }

        // ----------------------------------------------------------------
        // do While loops
        System.Console.WriteLine("DO WHILE");
        int y = 0;
        do
        {
            System.Console.WriteLine(y);
            y++;
        } while (y < 10);

        // ----------------------------------------------------------------
        // For loops
        // For i in range (10, 40, 7):
        //     print(i)
        for (int i = 10; i < 40; i += 7)
        {
            System.Console.WriteLine(i);
        }

        int i;
        for (int i = 10; 1 < 40; i += 7)
        {
            System.Console.WriteLine(i);
        }

        // ----------------------------------------------------------------
        // Random numbers
        // import random
        // print(random.randint(1, 10))

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        
        // ----------------------------------------------------------------
        // List
        // Values = [1, 2, 3, 4]
        // items = [1, "bob", True, [1, 2, 3]]
        int value;
        List<int> items = new List<int>();
        for (int i = 0; i < 100000; i ++)
        {
            items.Add(i);
        }
        System.Console.WriteLine(items.Count);
    }   
}