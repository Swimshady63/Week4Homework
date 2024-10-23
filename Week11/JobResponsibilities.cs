using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
     abstract class JobResponsibilities
    {
        public abstract void Job();
        
    }
     class Actor : JobResponsibilities
    {   public override void Job()
        { Console.WriteLine("Acting solely on simple scenes"); }  
    }
    class Proxy : JobResponsibilities
    {
        Actor actor;
        public override void Job()
        {
            if (actor == null)
            {
                actor = new Actor();
                actor.Job();
                Console.WriteLine("Doing dangerous stuff");
         
            }
        }
    }
}
