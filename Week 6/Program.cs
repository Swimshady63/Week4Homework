// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml.Linq;
#region Exercise 1
Console.WriteLine("Enter the radius of a circle");
double r = int.Parse(Console.ReadLine());
//square 1 area
double a2 = 2 * r;
double S2 = a2 * a2;
//square 2 area
double a1 = 2 * r / Math.Sqrt(2);
double S1 = a1 * a1;
//area2 -area1
double answer = S2 - S1;
Console.WriteLine(Math.Round(answer));
#endregion

#region Exercise 2
/*დაწერეთ პროგრამა რომელიც შეამოწმებს ამოუვიდა თუ არა იუზერს
ჯეკპოტი
 */

Console.WriteLine("Type to win a Jackpot:");

char[] values = new char[5];
int count = 0;
for (int i = 0; i < values.Length; i++)
{
    char Input = char.Parse(Console.ReadLine());
    values[i] = Input;
    if (values[0] == values[i]) count++;
}

if (count == 5)
{
    Console.WriteLine("You hit a Jackpot");
}
else
{
    Console.WriteLine("You didn't win today");
}




#endregion

#region Exercise 3
/*დაწერეთ პროგრამა რომელიც დათვლის ჯამში რამდენი ქულა დააგროვა
საფეხბურთო გუნდმა
a. მოგება - 3
b. ფრე = 1
c. წაგება = 0*/
Console.WriteLine("How many games did your team win?");
int.TryParse(Console.ReadLine(), out int win);
Console.WriteLine("How many games did your team finish in tie?");
int.TryParse(Console.ReadLine(), out int tie);
Console.WriteLine("How many games did your team lose?");
int.TryParse(Console.ReadLine(), out int lose);
int Sum = win + tie + lose;
Console.WriteLine("Your score is: " + Sum);
#endregion

#region Exercise 4
/*დაწერეთ პროგრამა რომელიც დათვლის თანამშრომლის შემოსავალს 1
კვირის განმავლობაში .
გაითვალისწინეთ
a. დღეში თანამშრომელი მუშაობს 8 საათს და საათში იღებს 10 $
b. ოვერთაიმის შემთხვევაში საათში იღებს დამატებით 5$
c. შაბათ/კვირას მუშაობის შემთხვევაში იღებს გაორმაგებულ ხელფასს */

Console.WriteLine("Enter how many hours have you worked this week:");
int OneHourPay = 10;
int OverTimePay = 5;
int WeekendsPay = 20;
int[] WorkingHours = new int[7];
int sum = 0;
for (int i = 0; i < WorkingHours.Length; i++)
{
    WorkingHours[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
    if (WorkingHours[i] == 8)
    {
        sum += WorkingHours[i] * OneHourPay;

    }
    else if (WorkingHours[i] > 8)
    {
        sum += WorkingHours[i] * (OneHourPay + OverTimePay);

    }
    else
    {
        sum += WorkingHours[i] * OneHourPay;
    }
}
if (WorkingHours[5] > 0 && WorkingHours[6] > 0)
{
    sum += (WorkingHours[5] + WorkingHours[6]) * WeekendsPay;

}

Console.WriteLine("Your Total Payment is " + sum);

#endregion

#region Exercise 5
/*გიორგი მარათონისთვის ემზადება ის ყოველ დღიურად ვარჯიშობს
.შეამოწმეთ აქვს თუ არა გიორგის პროგრესი ყოველ დღიურად და გამოიტანეთ იმ
დღეების რაოდენობა როდესაც მან შედეგი გააუმჯობესა.*/
int[] Weekdays = new int[5];
Console.WriteLine("Enter your evarage training score from Monday to Friday:");
int mtvleli = 0;
for (int i = 0; i < Weekdays.Length; i++)
{
    int.TryParse(Console.ReadLine(), out int progress);
    Weekdays[i] = progress;
}
for (int i = 0;i < Weekdays.Length-1; i++)
{
    if (Weekdays[i] < Weekdays[i + 1])
    {
        mtvleli++;
    }
}
if (mtvleli == 0) { Console.WriteLine("Your progress is zero, keep up buddy"); }
else Console.WriteLine("You have been making progress for " + mtvleli + " Days");



#endregion

#region Exercise 6

/*დაწერეთ პროგრამა რომელიც ამობეჭდავს N სიგრძის მქონდე ელემენტს
მასივიდან*/
Console.WriteLine(" Enter the length of an element ");
int.TryParse(Console.ReadLine(), out int Element);
string[] names = new string[5] { "programming", "under", "Physics", "Alpha", "OMG" };
int countnum = 0;
for (int i = 0; i < names.Length; i++)
{
    if (names[i].Length == Element)
    {
        Console.WriteLine(names[i]);
        countnum++;
    }
}
if (countnum == 0) Console.WriteLine("there is no such word");

#endregion

