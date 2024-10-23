using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week11
{
    public abstract class Strategy
    {
        public abstract void WorkingOnFiles();
    }
    
    class ZIPFile : Strategy
    {
        public override void WorkingOnFiles()

        {
            string directory = @"C:\Users\oliko\source\repos\tt\WEEK4\Week11\Extract";
            string ZipPath   = @"C:\Users\oliko\source\repos\tt\WEEK4\Week11\FileZip.zip";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            using (var archive = new Archive(ZipPath))
            {
                Console.WriteLine("Unzipping FileZip.zip");
                archive.ExtractToDirectory(directory);
            }
        }
    }

    class JsonFile : Strategy
    {
        public override void WorkingOnFiles()
        {
            Console.WriteLine("Jsonfilestrategy");
            var JsonFilePath = @"C:\\Users\\oliko\\source\\repos\\tt\\WEEK4\\Week11\\JsonFile.json";
            string json = File.ReadAllText(JsonFilePath);
            Console.WriteLine(json);
        }
    }

    class TxtFile : Strategy
    {
        public override void WorkingOnFiles()
        {
            var FilePath = @"C:\Users\oliko\source\repos\tt\WEEK4\Week11\FileTxt.txt";
            if (!File.Exists(FilePath))
            {
                File.AppendAllText(FilePath, "Omaigaad");
            }

            if (File.Exists(FilePath))
            {
                Console.WriteLine($"Removing Old File");
                File.Delete(FilePath);
            }
            
        }
    }

    class Format
    {
        Strategy strategy;
        public Format(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void FormatStrategy()
        {
            strategy.WorkingOnFiles();
        }
    }
}
