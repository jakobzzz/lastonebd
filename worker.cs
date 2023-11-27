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
    public partial class Worker : Form
    {
        public Worker()
        {
            InitializeComponent();

            using DataContext dataContext = new DataContext();
            var sections = dataContext.ISections.ToList();
            foreach (var section in sections)
            {
                comboBox1.Items.Add(section);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWorkers worker = new IWorkers();
            worker.Name = textBox1.Text;
            worker.Surname = textBox2.Text;
            worker.Age = int.Parse(textBox3.Text);
            worker.Number = int.Parse(textBox4.Text);
            worker.ISection = comboBox1.SelectedItem as ISection;

            using DataContext dataContext = new DataContext();
            dataContext.Attach(worker.ISection);

            dataContext.Add(worker);
            dataContext.SaveChanges();
        }
    }
}
