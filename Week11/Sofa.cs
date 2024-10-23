using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    public abstract class Sofa
    {
        public abstract void HasLegs();
        public abstract void SitOn();

    }
    public  class VictorianSofa : Sofa
    {
        public override void HasLegs()
        {
            Console.WriteLine("Victorian Sofa has 4 legs");
        }
        public override void SitOn()
        {
            Console.WriteLine("Victorian Sofa is sittable");
        }
    }

    public  class ModernSofa : Sofa
    {
        public override void HasLegs()
        {
            Console.WriteLine("Modern Sofa has 4 legs");
        }
        public override void SitOn()
        {
            Console.WriteLine("Modern Sofa is sittable");
        }
    }

    public  class ArtDecoSofa : Sofa
    {
        public override void HasLegs()
        {
            Console.WriteLine("ArtDeco Sofa has 4 legs");
        }
        public override void SitOn()
        {
            Console.WriteLine("ArtDeco Sofa is sittable");
        }
    }
}
