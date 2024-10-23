using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    public abstract class Chair
    {
        public abstract void HasLegs();
        public abstract void SitOn();
        

    }
    public  class VictorianChair: Chair
    {
        public override void HasLegs()
        {
            Console.WriteLine("Victorian chair has 4 legs");
        }
        public override void SitOn()
        {
            Console.WriteLine("Victorian chair is sittable");
        }
    }

    public  class ModernChair : Chair
    {
        public override void HasLegs()
        {
            Console.WriteLine("Modern chair has 4 legs");
        }
        public override void SitOn()
        {
            Console.WriteLine("Modern chair is sittable");
        }
    }

    public  class ArtDecoChair : Chair
    {
        public override void HasLegs()
        {
            Console.WriteLine("ArtDeco chair has 4 legs");
        }
        public override void SitOn()
        {
            Console.WriteLine("ArtDeco chair is sittable");
        }
    }
}
