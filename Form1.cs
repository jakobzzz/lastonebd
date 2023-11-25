using lastonebd.Data;

namespace lastonebd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using DataContext dc = new DataContext();

            string nameISection = textBox1.Text;

            ISection d = new ISection() { Name = nameISection };
            
            // ISection d = new() { Name = nameiSection }; after 1st edit

            dc.ISections.Add(d);
            dc.SaveChanges();

            MessageBox.Show("Новый отдел добавлен");
            //System.Windows.Forms.MessageBox.Show(this, index.Message, "Новый отдел добавлен", MessageBoxButtons.OK);
            //MessageBox.Show(index.Message, "Новый отдел добавлен", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

        }
    }
}