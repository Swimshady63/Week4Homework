// See https://aka.ms/new-console-template for more information

#region 1st  EXERCISE
/*შეამოწმეთ იყოფა თუ არა რიცხვი 5ზე უნაშთოდ. რიცხვი უნდა მიიღოთ
კონსოლიდან.
Input : 10 Output : Yes
Input : 44 Output : NO */

Console.WriteLine("Enter your number");
var UserInput = int.TryParse(Console.ReadLine(), out int Number);
if (Number % 5 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO"); 
}
#endregion

#region 2nd EXERCISE
/*დაწერეთ ისეთი პროგრამა, რომელიც შეასრულებს ჯამის, სხვაობის,
ნამრავლის და გაყოფის მოქმედებები
შენიშვნა
i. გაყოფის და გამოკლების დროს აარჩიეთ უდიდესი და მას
გამოაკელით უმცირესი
ii. თუ უმცირესი რიცხვი იქნება 0 პროგრამამ უნდა გამოიტანოს
შეცდომა 0 გაყოფა არ შეიძლება . */

Console.WriteLine("Enter X Variable");
var FirstInput = int.TryParse(Console.ReadLine(), out int X);
Console.WriteLine("Enter Y Variable");
var SecondInput = int.TryParse(Console.ReadLine(),out int Y);

if (X >= Y && Y != 0)
{
    var Sum = X + Y;
    var Devide = X / Y;
    var Extract = X - Y;
    var Multiply = X * Y;
    Console.WriteLine($"X+Y= {Sum}");
    Console.WriteLine($"X-Y= {Extract}");
    Console.WriteLine($"X/Y= {Devide}");
    Console.WriteLine($"X*Y= {Multiply}");
}
   else if (X<Y && X!=0){
    var Sum = X + Y;
    var Devide = Y / X;
    var Extract = Y - X;
    var Multiply = X * Y;
    Console.WriteLine($"X+Y= {Sum}");
    Console.WriteLine($"X-Y= {Extract}");
    Console.WriteLine($"X/Y= {Devide}");
    Console.WriteLine($"X*Y= {Multiply}");
}
else
{
    var Sum = X + Y;
    var Multiply = X * Y;
    Console.WriteLine($"X+Y= {Sum}");
    Console.WriteLine($"X-Y= {Sum}");
    Console.WriteLine($"Not Allowed To Divide By Zero");
    Console.WriteLine($"X*Y= {Multiply}");

}
#endregion

#region 3rd EXERCISE
/*გაუცვალეთ ორ ცვლადს შორის მნიშვნელობები .
მაგ : Input x = 5 ; y = 12
Output : x =12 ; y = 5;*/

Console.WriteLine("type M number");
var Firstnum = int.TryParse(Console.ReadLine(), out int M);
Console.WriteLine("type O number");
var Secondnum = int.TryParse(Console.ReadLine(), out int O);
int A = M + O - M;
int Z = O + M - O;
Console.WriteLine($"M = {A}");
Console.WriteLine($"O = {Z}");

#endregion

#region 4th EXERCISE
/*დაწერეთ პროგრამა რომელიც მიიღებს კონსოლიდან 1 რიცხვს და დაბეჭდავს
გამრავლების ტაბულას ამ რიცხვისთვის
a. შენიშვნა : გამოიყენეთ ციკლი.*/

Console.WriteLine("Enter any number");
var Anynumber = int.TryParse(Console.ReadLine(), out int Num);
int max = 10;
for (int i=0; i<max; i++)
{   
    Console.WriteLine(Num * i);
}

#endregion

#region 5th EXERCISE
/*დაწერეთ პროგრამა რომელიც იპოვის ყველა ლუწ რიცხვს 1 დან n - მდე და
დაბეჭდავს მათ კვადრატებს .*/

Console.WriteLine("Type N number");
var GivenNum = int.TryParse(Console.ReadLine(), out int N);
for (int i = 0; i < N; i++)
{
    if (i % 2 == 0) {
        Console.WriteLine(i*i); }
}
#endregion
