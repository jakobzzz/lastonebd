using lastonebd.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastonebd
{
    public partial class ListWorkers : Form
    {
        public ListWorkers(int Id)
        {
            InitializeComponent();
            using DataContext db = new DataContext();
            var workers = db.IWorkersTab.Where(i => i.ISectionId == Id); // or IWorkers!
            foreach (var worker in workers)
            {
                listView1.Items.Add(worker.ToString());
            }
        }
    }
}
