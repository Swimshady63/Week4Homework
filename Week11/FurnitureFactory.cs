using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Week11;

namespace Week11
{
    public abstract class FurnitureFactory 
    {
        public abstract void CreateChair();
        public abstract void CreateTable();
        public abstract void CreateSofa();
       
    }

    class VictorianFurnitureFactory : FurnitureFactory
    {
       public override void CreateChair()
        {
            VictorianChair chair = new VictorianChair();
            
            chair.HasLegs();
            chair.SitOn();

        }
        public override void CreateSofa()
        {
            VictorianSofa sofa = new VictorianSofa();
            sofa.HasLegs();
            sofa.SitOn();
        }

        public override void CreateTable()
        {
            VictorianTable table = new VictorianTable();
            table.HasLegs();
            table.SitOn();
        }
        
    }
     class ModernFurnitureFactory : FurnitureFactory
    {
        public override void CreateChair()
        {
            ModernChair chair = new ModernChair();
            chair.HasLegs();
            chair.SitOn();
        }
        public override void CreateSofa()
        {
            ModernSofa sofa = new ModernSofa();
            sofa.HasLegs();
            sofa.SitOn();
        }

        public override void CreateTable()
        {
            ModernTable table = new ModernTable();
            table.HasLegs();
            table.SitOn();
        }
    }
     class ArtDecoFurnitureFactory : FurnitureFactory
{
    public override void CreateChair()
    {
        ArtDecoChair chair = new ArtDecoChair();
        chair.HasLegs();
        chair.SitOn();
    }
    public override void CreateSofa()
    {
        ArtDecoSofa sofa = new ArtDecoSofa();
        sofa.HasLegs();
        sofa.SitOn();
    }

    public override void CreateTable()
    {
        ArtDecoTable table = new ArtDecoTable();
        table.HasLegs();
        table.SitOn();
    }
}

    
}


