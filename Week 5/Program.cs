// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Xml.Linq;



internal class Program1
{

    private static void Main(string[] args)
    {
        #region First Exercise
        /*დაწერეთ პროგრამა რომელიც კონსოლიდან მიიღებს მასივის ზომას , n
რაოდენობის ელემენტს შეინახავს მასივში. შემდეგ ამ მასივიდან გაფილტრავს
ელემენტს ლუწ რიცხვებს შეინახავს 1 მასივში ხოლო კენტებს მეორეში .
a. input:
10
1 2 3 4 5 6 7 8 9 10
output
მასივი#1 : 2 4 6 8 10
მასივი#2: 1 3 5 7 9*/
        Console.WriteLine("type the lenght of an array");
        int.TryParse(Console.ReadLine(), out int n);

        int[] numbers = new int[n];
        int evennumbers = 0;
        int oddnumbers = 0;


        for (int i = 0; i < numbers.Length; i++)
        {

            numbers[i] = int.Parse(Console.ReadLine());

        }
        foreach (int elements in numbers)
        {

            if (elements % 2 == 0)
            {
                evennumbers++;
            }

            else
            {
                oddnumbers++;
            }
        }
        Console.WriteLine("---------");

        int[] evennum = new int[evennumbers];
        int[] oddnum = new int[oddnumbers];
        int k = 0;
        int m = 0;

        for (int j = 0; j < numbers.Length; j++)
        {

            if (numbers[j] % 2 == 0)
            {
                evennum[k] = numbers[j];
                k++;
            }

            else
            {
                oddnum[m] = numbers[j];
                m++;
            }
        }

        foreach (int element in evennum)
        {
            Console.WriteLine("even numbers: " + element);
        }

        foreach (int odds in oddnum)
        {
            Console.WriteLine("odd numbers: " + odds);
        }
        #endregion


        #region Second Exercise
        /* შექმენით კონტაქტების აპლიკაცია რომელსაც ექნება კონტაქტის დამატების,
           წაშლის და განახლების ფუნქციონალი ( გამოიყენეთ Dictionary)*/

        Dictionary<string, string> ContactsApp = new Dictionary<string, string>();

        string[] names = new string[3];
        string numbers2;
        //add contacts
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine("Type contact name");
            names[i] = Console.ReadLine();
            Console.WriteLine("Set Number:");
            numbers2 = Console.ReadLine();
            ContactsApp.Add(names[i], numbers2);

        }
        foreach (string name in ContactsApp.Keys)
        {
            Console.WriteLine(name + " " + ContactsApp[name]);
        }
        //change contact
        Console.WriteLine("Type a name for a number update");
        string ChangeName = Console.ReadLine();
        Console.WriteLine("Type a correct number");
        ContactsApp[ChangeName] = Console.ReadLine();

        foreach (string name in ContactsApp.Keys)
        {
            Console.WriteLine(name + " " + ContactsApp[name]);
        }
        //remove contact
        Console.WriteLine("Delete any contact");
        string RemoveName = Console.ReadLine();
        ContactsApp.Remove(RemoveName);

        Console.WriteLine("Your Contacts List has been updated");

        foreach (string name in ContactsApp.Keys)
        {
            Console.WriteLine(name + " " + ContactsApp[name]);
        }
        #endregion

        //couldn't finish in time
        #region 3rd Exercise
        /* დაწერეთ პროგრამა რომელიც მასივში დათვლის თითოეული ელემენტის რაოდენობას და გამოიტანს მათ ჯამს
          a. Input
             5
             1 1 2 3 3
          b. Output
             1 appears 2 times sum 2
             2 appears 1 times sum 2
             3 appears 2 times sum 6 */

        //        Console.WriteLine("Type the lenght of an array");

        //        int.TryParse(Console.ReadLine(), out int Size);

        //        int[] num1 = new int[Size];

        //        Dictionary<string, string> Allnumbers = new Dictionary<string, string>();
        //        int count = 0;
        //        for (int i = 0; i < num1.Length; i++)
        //        {
        //            num1[i] = int.Parse(Console.ReadLine());
        //            count++;
        //            Allnumbers.Add()
        //        }
        //        var sorted = num1.OrderBy(n => n);

        //        foreach (int i in sorted)

        //        {
        //            Console.WriteLine(i);

        //        }

        //    }
        //}

        #endregion


        #region 4th Exercise
        /*დაწერეთ პროგრამა რომელიც გვიჩვენებს ტოპ n მონაწილის შედეგს . მაგ (1 2 3 4 5 6 7 8 9 10)
           a. Input:
              2
              Output
              9 10  */

        Console.WriteLine("How many top grades do you want to know: ");
        int N = int.Parse(Console.ReadLine());
        int[] topstudents = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int Starter = topstudents.Length - N;
        for (int i = Starter; i < topstudents.Length; i++)
        {
            Console.WriteLine(topstudents[i]);
        }

    }
    #endregion
}







