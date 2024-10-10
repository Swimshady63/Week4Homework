
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
internal class Program
{



    private static void Main(string[] args)
    {
        //Exercise 1 output
        Console.Write("Exercise 1\n");
        Console.Write($"Amount of {2}'s power numbers : {Exercise1(49, 71, 2)} \n");
        //Exercise 2 output
        Console.Write("Exercise 2\n");
        Console.Write($"Amount of duplicate socks : {Exercise2("AABBCCRTII")}\n");
        //Exercise 4 outputs

        List<int> numbers = new List<int> { 1, 2, 3, 4 };
        Console.Write($"{Exercise4<int>(numbers)}\n");


        List<string> words = new List<string> { "man", "woman", "child", "tree" };
        Console.Write($"{Exercise4<string>(words)}\n");

        List<bool> bools = new List<bool> { true, false, true, false, true, false, false };
        Console.WriteLine($"{Exercise4<bool>(bools)}\n");

        //Exercise 3 output
        Console.WriteLine(Exercise3("multiplication", "subscription"));
        Console.Write("\n");

        //Exercise 6 output
        int[] task6 = new int[] { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine(Exercise6(task6));
        Console.Write("\n");
        //Exercise 5 output
        Recursion5(1283);
    }










    //Exercise 1 method
    /*დაწერეთ ფუნქცია რომელიც პარამეტრად მიიღებს   a, b, n 
a. a - მინიმალური რიცხვი
b. b - მაქსიმალური რიცხვი
c. n - ხარისხი რომელშიც უნდა ავიყვანოთ რიცხვები
იპოვეთ ყველა რიცხვი a - &gt; b შუალედში რომლის n ხარისხი
მოთავსებულია ამ ინტერვალში*/
    static private int Exercise1(int a, int b, int n)
    {
        List<double> NthpowerNumbers = new List<double>();
        double x = 0;
        for (int i = a; i < b; i++)
        {
            double m = (int)n;
            x = Math.Pow(i, 1 / m);

            if (x - Math.Round(x) == 0)
            {
                NthpowerNumbers.Add(x);
            }

        }

        return NthpowerNumbers.Count;
    }

    //Exercise 2 method
    /*დაეხმარეთ პატარა ნიკუშას წინდების წყვილების პოვნაში. წყვილები
    აღნიშნულია ორი ერთნაირი სიმბოლოთი.*/
    static private string Exercise2(string word)
    {

        char[] chars = word.ToCharArray();
        int items = 0;
        var grouped = chars.GroupBy(x => x);
        foreach (var group in grouped)
        {
            if (group.Count() >= 2)
            {
                items++;
            }
        }
        return items.ToString();

    }

    //Exercise 3 method
    /* დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველა გრძელ საერთო
       ბოლოსართს ორ სტრინგს შორის
     */
    static private string Exercise3(string word1, string word2)
    {
        int i = word1.Length - 1;
        string sameword = "";

        for (int j = word2.Length - 1; j >= 0; j--)
        {
            if (word1[i] == word2[j]) { sameword += word1[i]; }
            else break;
            i--;
            if (i < 0) { break; }
        }

        char[] suffixarray = sameword.ToCharArray();
        Array.Reverse(suffixarray);
        return new string(suffixarray);

    }


    //Exercise 4 method generic
    /*დაწერეთ ფუნქცია რომელიც მიიღებს Generic ტიპის ლისტს , შეამოწმებს
      გადაცემული ლისტის ტიპს და შემოწმების შემდეგ ჩაატარებს შემდეგ
      ოპერაციებს .
      თუ გადაეცემა სტრინგების ლისტი - დაბეჭდავს ყველა სტრინგს UpperCase-ში
      თუ გადაეცემა ნებისმიერი რიცხვითი ტიპის მასივი ( int) - დაითვლის მათ ჯამს
      თუ გადაეცემა Bool - გამოიტანს ლისტის პირველ, ბოლო და შუაში მყოფ
      ელემენტს .*/
    static private string Exercise4<T>(List<T> Input)
    {
        Type type = typeof(T);
        int intsum = 0;
        string resultT = "";

        if (type == typeof(int))
        {
            for (int i = 0; i < Input.Count; i++)
            {
                intsum += Convert.ToInt32(Input[i]);
            }
            return intsum.ToString();
        }

        if (type == typeof(string))
        {
            List<string> uppercase = new List<string>();

            for (int i = 0; i < Input.Count; i++)
            {
                string words = Input[i].ToString();
                uppercase.Add(words.ToUpper());
            }
            foreach (string word in uppercase)
            {
                Console.WriteLine($"{word} \n");
            }

        }


        if (type == typeof(bool))
        {
            resultT = Convert.ToString((Input[0], Input[Input.Count - 1], Input[(Input.Count - 1) / 2]));
            return resultT;
        }
        return resultT;
    }

    //Exercise 6 method
    //დაწერეთ პროგრამა რომელიც შეამოწმებს შეიცავს თუ არა მასივი დუბლიკატებს
    static private string Exercise6(int[] duplicates)
    {
        bool answer = false;
        var dubs = from n in duplicates group n by n into amount select amount;
        foreach (var element in dubs)
        {
            if (element.Count() > 1) answer = true;
            else answer = false;
        }
        return answer.ToString();
    }

    //Exercise 5 method recurssion
    /*დაწერეთ ფუნქცია რომელიც დაბეჭდავს რიცხვში შემავალ ყოველ სიმბოლოს .
     Input : 12345
     Output : 1 - 2 - 3 - 4 - 5 */
    static void Recursion5(int n)
    {
        int m = 0;

        m = n % 10;
        n = n / 10;

        if (n > 0)
        {
            Recursion5(n);

        }

        Console.Write(m + " - ");

    }

}




