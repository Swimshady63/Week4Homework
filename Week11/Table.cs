using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    public abstract class Table
    {
        public abstract void HasLegs();
        public abstract void SitOn();

    }
    public  class VictorianTable : Table
    {
        public override void HasLegs()
        {
            Console.WriteLine("Victorian Table has 4 legs");
        }
        public override void SitOn()
        {
            Console.WriteLine("Victorian Table is not sittable");
        }
    }

    public  class ModernTable : Table
    {
        public override void HasLegs()
        {
            Console.WriteLine("Modern Table has 4 legs");
        }
        public override void SitOn()
        {
            Console.WriteLine("Modern Table is not sittable");
        }
    }

    public class ArtDecoTable : Table
    {
        public override void HasLegs()
        {
            Console.WriteLine("ArtDeco Table has 4 legs");
        }
        public override void SitOn()
        {
            Console.WriteLine("ArtDeco Table is  not sittable");
        }
    }
}
