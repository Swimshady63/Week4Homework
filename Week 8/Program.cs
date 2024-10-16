using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task1

        //CompanyOrigin
        var company = new Company();
        Console.WriteLine("If you are working in Local area press '1', else press '2'");
        int chosennumber = int.Parse(Console.ReadLine());
        company.CountryOrigin = chosennumber;
        var Tax = company.Checkorigin();

        //EmployeeInfo
        var employee1 = new Employee();
        Console.WriteLine("Please, Enter your name");
        employee1.FirstName = Console.ReadLine();
        Console.WriteLine("Please, Enter your Last name");
        employee1.LastName = Console.ReadLine();
        Console.WriteLine("Enter your Age");
        employee1.Age = int.Parse(Console.ReadLine());

        //----
        Console.WriteLine("Enter how many hours have you worked this week:\n");
        List<int> WorkingHours = new List<int> { };
        for (int i = 0; i < 7; i++)
        {
            WorkingHours.Add(int.Parse(Console.ReadLine()));
        }

        //Gets position
        Console.WriteLine("From the following choose your position:  Manager, Developer, Tester, etc.\n");
        //Calculates avarage salary of the week
        var Salary = employee1.WorkingHours(WorkingHours, employee1.ChoosePosition(Console.ReadLine()));
        Console.WriteLine($"Tax would be:{Tax}%, that means Your Company pays {company.CalculateTax(Salary, Tax)}$ from {employee1.FirstName}'s Salary\n");


        //Task 2

        var student1 = new Student();
        student1.StudentName = "Malxazi";
        Console.WriteLine("when did you start university?");
        var StartingYear = student1.UniStartingYear = int.Parse(Console.ReadLine());
        student1.CalculateLeftYears(StartingYear);
        Console.WriteLine("Please enter a number from 1 to 4 to choose subject (Math, Chemistry, English, Others)\n");
        var chosenSubject = student1.RandomSubject();
        var teacher1 = new Teacher();
        teacher1.Name = "Gulnazi";
        teacher1.Status = "Verified";
        Console.WriteLine($"Teacher Name {teacher1.Name} {teacher1.CheckSubject(chosenSubject)}\n");



        //Task 3
        var student_1 = new GoodStudent();
        student_1.StudentName = "Gogita";
        var student2 = new LazyStudent();
        student2.StudentName = " Malxazi";
        Classroom Newclass = new Classroom(student_1);
        Classroom Newclass1 = new Classroom(student2);
        Console.WriteLine("-----Task3-----\n");
        Console.WriteLine($"{student_1.StudentName} stats: \n");
        Newclass.gamodzaxeba();
        Console.WriteLine("---------------\n");
        Console.WriteLine($"{student2.StudentName} stats: \n");
        Newclass1.gamodzaxeba();

    }
}

//Task1 classes
internal class Company
{
    public int CountryOrigin {  get; set; }
   
    public int Checkorigin () {
        int TaxAmount = 0;
        if (CountryOrigin is 1) {
            TaxAmount += 18;
            
        }
        else if (CountryOrigin is 2) 
        {
            TaxAmount += 5;
            
        }
        else { Console.WriteLine("Please Try Again");
        }
        return TaxAmount;
    }
    public int CalculateTax(int AvarageS, int AmountTax)
    {
        int TaxAmount = (AvarageS*AmountTax)/100;
        return TaxAmount;
    }

}

internal class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public int Workhours { get; set; }


    public int ChoosePosition(string Title)
    {
        int OneHourPay = 0;

        if (Title == "Manager")
        {
            OneHourPay += 40;
        }
        else if (Title == "Developer")
        {
            OneHourPay += 30;
        }
        else if (Title == "Tester")
        {
            OneHourPay += 20;
        }
        else
        {
            OneHourPay += 10;
        }
        return OneHourPay;
    }

    public int WorkingHours(List<int> WorkingHours, int OneHourPay)
    {
        
        int OverTimePay = 5;
        int WeekendsPay = 20;

        int sum = 0;
        int Bonus = sum + (sum % 20);
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
        if (WorkingHours[5] > 0 || WorkingHours[6] > 0)
        {
            sum += (WorkingHours[5] + WorkingHours[6]) * WeekendsPay;

        }
        if (WorkingHours.Sum() > 80)
        {
            sum += Bonus;
        }

        return sum;
    }

    
}

//Task2 classes
internal class Student
{
    public string StudentName { get; set; }
    public int UniStartingYear { get; set; }
    public int Age { get; set; }

    public int CalculateLeftYears(int UniStartingYear)
    {
        int currentYear = 2024;
        int RemainingYears = currentYear - UniStartingYear;
        if (RemainingYears >= 4)
        {
            return 0;
        }
        else { return RemainingYears; }
    }

    public string RandomSubject()
    {   string subject = string.Empty;
        int subject1 = int.Parse(Console.ReadLine());
        switch (subject1)
        {
            case 1:
                subject = "Math";
                break;
            case 2:
                subject = "Chemistry";
                break;
            case 3:
                subject = "English";
                break;
            case 4:
                subject = "Other";
                break;

          

        }
        return subject;
    }
}

internal class Teacher
{
    public string Name { get; set; }
    public string Status { get; set; }

    public string CheckSubject(string subject)
    {   string answer = string.Empty;
        if (subject == "Math")
        {   int a = 5;
            int b = 6;
            Console.WriteLine(a + b);
        }
        else if (subject == "Chemistry")
        {
            Console.WriteLine("H2O");
        }
        else if (subject == "English")
        {
            Console.WriteLine("this is English");
        }
        else if (subject == "Other")
        {
            Console.WriteLine("no kompetencia");
        }
        return answer;
    }
    
}

//Task 3 classes
internal class Student_1
{
    public string StudentName { get; set; }
    public virtual void Study()
    {

    }
    public virtual void Read()
    { }
    public virtual void Write()
    { }
    public virtual void Relax()
    { }

}

internal class GoodStudent : Student_1
{

    public override void Study()
    {
        Console.WriteLine("Studying veryy hard");
    }
    public override void Read()
    {
        Console.WriteLine("Reading 10 Books");
    }
    public override void Write()
    {
        Console.WriteLine("Writing a lot statements");
    }
    public override void Relax()
    {
        Console.WriteLine("Relaxing for 5 minutes");
    }
}
internal class LazyStudent : Student_1
{

    public override void Study()
    {
        Console.WriteLine("Procrastinating");
    }
    public override void Read()
    {
        Console.WriteLine("Doesn't Read Books");
    }
    public override void Write()
    {
        Console.WriteLine("Doesn't write statements");
    }
    public override void Relax()
    {
        Console.WriteLine("Relaxing for whole day ");
    }
}

internal class Classroom
{
    Student_1 classStudent;
    public Classroom(Student_1 newStudent)
    {
        classStudent = newStudent;
    }
    public void gamodzaxeba()
    {
        classStudent.Study();
        classStudent.Read();
        classStudent.Relax();
        classStudent.Write();
    }
}









