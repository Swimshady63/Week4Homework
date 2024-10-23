// See https://aka.ms/new-console-template for more information
using Week11;


//Abstract Factory:

VictorianFurnitureFactory victorianFurniture = new VictorianFurnitureFactory();
victorianFurniture.CreateTable();
victorianFurniture.CreateSofa();
victorianFurniture.CreateChair();


//-------------------- Task 2:

MainActor mainActor = new MainActor();
mainActor.MainJob();
mainActor.AdditionalJob();
SecondaryActor secondaryActor = new SecondaryActor();
secondaryActor.MainJob();
secondaryActor.AdditionalJob();

//-------------------- Task 3;

ReportGenerator report = new ReportGenerator();
report.GenerateHTMLreport();
report.GeneratePDFreport();