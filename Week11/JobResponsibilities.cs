using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    public class JobResponsibilities
    {
        public void MainJob()
        {

        }
        public void AdditionalJob()
        {

        }
    }
    public class MainActor : JobResponsibilities
    {   public void MainJob()
        {
         Console.WriteLine("Acting solely on simple scenes");
        }
        public void AdditionalJob()
        {
            Console.WriteLine("Nothing much");
        }

    }
    public class SecondaryActor : JobResponsibilities
    {
        public void MainJob() {
            Console.WriteLine("Acting in Movie scenes");
        }

        public void AdditionalJob()
        {
            Console.WriteLine("Doing dangerous stuff");
        }
    }
}
