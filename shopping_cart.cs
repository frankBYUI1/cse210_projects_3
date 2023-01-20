using System.Collections.Generic;
using System;

/*
1) Add Item
2) Display
3) Total
4) Remove
5) Quit
*/

class Program
{
    static void Main(string[] args)
    {
        // Data
        List<string> data = new List<string>();
        List<float> prices = new List<float>();

        bool done = false;
        while (!done)
        {
            DisplayMenu();
            int choice = GetChoice();
            if (choice == 1)
            {
                AddItem(items, prices);
            }

            if (choice == 2)
            {
                DisplayItem(items, prices);
            }

            if (choice == 5)
            {
                done = true;
            }

        }

    }

    static void DisplayMenu()
    {
        System.Console.WriteLine("1) Add Item");
        System.Console.WriteLine("2) Display");
        System.Console.WriteLine("3) Total");
        System.Console.WriteLine("4) Remove");
        System.Console.WriteLine("5) Quit");
    }

    static int GetChoice()
    {
        System.Console.WriteLine("Enter Choice: ");
        string choice = System.Console.ReadLine();
        int answer = int.Parse(choice);
        return answer;
    }
    static void AddItem(List<string> items, List<float> prices) // void = nothing is returned here
    {
        System.Console.Write("Enter Item: ");
        string item = System.Console.ReadLine();

        System.Console.Write("Enter Price: ");
        string price = System.Console.ReadLine();
        float priceAmount = float.Parse(price);
        
        items.Add(item);
        prices.Add(priceAmount);
    }
    static void Display(List<string> items, List<float> prices) 
    {
        System.Console.WriteLine("Display Item");
        for (int i = 0; i < items.Count; i++)
        {
            System.Console.WriteLine($"{items[i]}: {prices[i]} ");
        }
        System.Console.WriteLine("");
    }
}