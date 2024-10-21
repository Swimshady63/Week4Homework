using System;
using System.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Week10;
using Newtonsoft.Json;
internal class Program
{
    private static void Main(string[] args)
    {
        #region Task1
        //Task 1 
        /*დაწერეთ პროგრამა რომელიც შექმნის ფაილის თუ ის არ არსებობს .
          მომხარებელისგან მიიღებს რამდენი ხაზი უნდა იყოს ფაილში. და წაიკითხავს
          ბოლო ხაზს ფაილიდან*/

        var Task1FilePath = @"C:\Users\oliko\source\repos\tt\WEEK4\Week10\Task1File.txt";
        var FileName = Path.GetFileName(Task1FilePath);
        if (File.Exists(Task1FilePath))
        {
            Console.WriteLine($"Your {FileName} already exists, Let's create anyway");
            File.Delete(Task1FilePath);
            
        }
        Console.WriteLine("Enter How many lines should be in your File:");
        int N = int.Parse(Console.ReadLine());
        string[] UserINput = new string[N];
       
        if (!File.Exists(Task1FilePath))
        {
            Console.WriteLine($"You just created new {FileName}\n");
            Console.WriteLine("Please fill your txt.File");
            for (int i = 0; i < N; i++)
            {
                UserINput[i]=(Console.ReadLine());
                File.AppendAllText(Task1FilePath, UserINput[i]);
            }
            Console.Write($"The content of the last line of the {FileName} is  : {UserINput[N - 1]}\n");
        }
        #endregion

        #region Task2
        //Task2
        /* დაწერეთ პროგრამა რომელიც მიიღებს პარამეტრად N რიცხვს და ფაილში
           ჩაწერს გამრავლების ტაბულას 1..Nმდე*/
        var Task2FilePath = @"C:\Users\oliko\source\repos\tt\WEEK4\Week10\Task2File.txt";
        var FileName2 = Path.GetFileName(Task2FilePath);
        Console.WriteLine("Enter N number for multiply table");
        int number=int.Parse( Console.ReadLine());
        int range = 10;
        string[] GamravlebisTabula = new string[range];
        if (File.Exists(Task2FilePath))
        {
            File.Delete (Task2FilePath);
        }
        if (!File.Exists(Task2FilePath))
        {
            Console.WriteLine($"You just created new {FileName2}\n");

            for (int i = 0; i <range; i++)
            {
                GamravlebisTabula[i] = Convert.ToString($"{number} X {i} = {number*i}\n");
                File.AppendAllText(Task2FilePath, GamravlebisTabula[i]);
            }
            StreamReader Table = File.OpenText(Task2FilePath);
            Console.WriteLine(Table.ReadToEnd());

        }
        #endregion

        #region Task3
        /*დაწერეთ პროგრამა რომელიც სტრინგ დაყოფს N რაოდენობის ტოლ
          სტრინგებად . შემდეგ კი ამ დაყოფილი სტრინგებისგან შექმენილი XML NODE
         */

        //Console.WriteLine("Please type a word:");
        //string m = Console.ReadLine();
        //Console.WriteLine("N:");
        //int N2 = int.Parse( Console.ReadLine());
        //string subs;
        //for(int i=0; i<m.Length; i += subs.Length)
        //{
        //    subs = m.Substring(i, m.Length / N2);
           
        //        Console.WriteLine(subs);
        //}
     
        
        

        #endregion

        #region Task4
        //Task4
        /*
         * პატარა ნიკუშას აინტერესებს რამდენი დღე რჩება მის დაბადების დღემდე
           დაწერეთ პროგრამა რომელიც JSON ფაილიდან წაიკითხავს დღევანდელ დღეს და
           დაბადების დღის თარიღს და გამოიტანს დარჩენილი დღეების რაონდებოას .
             JSON
                   {
                    “currentDate” : “June 14, 2022”,
                    “birthday” : “June 20, 2022”
                                               }
         */

        //    string data_ = " [ {\"birthday\": \"June 20, 2024\", \"CurrentDate\": \"“June 14,2024\"} ] ";
        //    using JsonDocument doc = JsonDocument.Parse(data_);
        //    JsonElement root = doc.RootElement;
        //    Console.WriteLine(root);

        //    StreamReader r = new StreamReader(@"C:\Users\oliko\source\repos\tt\WEEK4\Week10\BirthdayBoy.json");
        //    var jsonString = r.ReadToEnd();
        //    Console.WriteLine(jsonString);

        //    var birthday = JsonConvert.DeserializeObject<Brthday>(jsonString);



        //    var data = new List<Brthday>();
        //    data.Add(

        //        new Brthday
        //        {
        //            birthday = 22,
        //            birthMonth = 03,
        //            birthYear = 2022
        //        }
        //    );
        //    Console.WriteLine(birthday.birthday);
        //    Console.WriteLine(birthday.birthMonth);
        //    Console.WriteLine(birthday.birthYear);

        #endregion
    }
}