
using System.Runtime.Intrinsics.X86;
using Week11;




internal class Program
{
    private static void Main(string[] args)
    {   //Abstract Factory:
         Task1();
        //Proxy
         Task2();
        //Facade
         Task3();
        //Strategy
         Task4();
    }


    static void Task1()
    {
        Client client = new Client(new VictorianFurnitureFactory());
        client.Run();

    }

    static void Task2()
    {
        JobResponsibilities jobResponsibilities = new Proxy();
        jobResponsibilities.Job();

        Actor actor = new Actor();
        actor.Job();
       

    }

    static void Task3()
    {
        ReportGenerator report = new ReportGenerator();
        report.GenerateHTMLreport();
        report.GeneratePDFreport();

    }

    static void Task4()
    {
        Format format;
        format = new Format(new JsonFile());
        format.FormatStrategy();
    
        format = new Format(new TxtFile());
        format.FormatStrategy();

        format = new Format(new ZIPFile());
        format.FormatStrategy();

    }
}

