using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    public class Files : FileWorker
    {
        public override string Format { get; set; }
        public int MaxStorage { get; set; }


        public override void Read()
        {
            Console.WriteLine($"I can read from {Format} file with max storage {MaxStorage}\n");
        }
        public override void Write()
        {
            Console.WriteLine($"I can write in {Format} file with max storage {MaxStorage}\n");
        }
        public override void Edit()
        {
            Console.WriteLine($"I can edit in {Format} file with max storage {MaxStorage}\n");
        }
        public override void Delete()
        {
            Console.WriteLine($"I can delete from {Format} file with max storage {MaxStorage}\n");
        }
    }



}
