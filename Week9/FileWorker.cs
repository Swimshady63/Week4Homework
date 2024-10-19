using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    public abstract class FileWorker
    {
        public int MaxStorage { get; set; }
        public abstract string Format { get; set; }
        public abstract void Read();
        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();
    }
}
    

