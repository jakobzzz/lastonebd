using lastonebd.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastonebd.Data
{
    internal class ISection
    {
        public int Id { get; set; }

        public string Name { get; set; }
        // public required string Name { get; set; }

        public ICollection<IWorkers> IWorkersTab { get; set; }
        // public required ICollection<IWorkers> IWorkersTab { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}