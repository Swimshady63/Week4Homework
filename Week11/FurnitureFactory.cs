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
        public abstract Chair CreateChair();
        public abstract Table CreateTable();
        public abstract Sofa  CreateSofa();

    }

    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new VictorianChair();

        }
        public override Sofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public override Table CreateTable()
        {
            return new VictorianTable();
        }

    }
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new ModernChair();
        }
        public override Sofa CreateSofa()
        {
            return new ModernSofa();
        }

        public override Table CreateTable()
        {
            return new ModernTable();
        }
    }
    public class ArtDecoFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new ArtDecoChair();
        }
        public override Sofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public override Table CreateTable()
        {
            return new ArtDecoTable();
        }
    }

    public class Client
    {
        private Sofa  sofa;
        private Chair chair;
        private Table table;
        public Client(FurnitureFactory factory)
        {
            sofa  = factory.CreateSofa();
            chair = factory.CreateChair();
            table = factory.CreateTable();
        }
        public void Run()
        {
            sofa.HasLegs();
            chair.HasLegs();
            table.HasLegs();
        }
    }
}


