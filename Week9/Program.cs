using Week9;

internal class Program
{
    private static void Main(string[] args)
    {
       
        //Task1
        Files fileWorker = new Files();
        fileWorker.Format = "txt";
        fileWorker.MaxStorage = 128;
        fileWorker.Write();
        fileWorker.Delete();
        fileWorker.Edit();
        fileWorker.Read();

        //Task2
        Bank bank = new Bank();
        bank.CheckUserHistory();
        MicroFinance microFinance = new MicroFinance();
        microFinance.CheckUserHistory();
    }
}