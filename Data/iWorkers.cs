using lastonebd.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace lastonebd.Data
{
    internal class IWorkers

    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Surname { get; set; }

        public int Age { get; set; }

        public int Number { get; set; }

        public int ISectionId { get; set; }

        public ISection ISection { get; set; }


    }
}