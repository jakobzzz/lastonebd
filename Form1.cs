using lastonebd.Data;
using Newtonsoft.Json;
namespace lastonebd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateISection();
        }

        public void UpdateISection()
        {
            listView1.Items.Clear();
            using DataContext dc = new DataContext();

            var list = dc.ISections.ToList();

            foreach (var section in list)
            {
                listView1.Items.Add(section.Name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using DataContext dc = new DataContext();

            string nameISection = textBox1.Text;

            ISection d = new ISection();
            d.Name = nameISection;


            dc.ISections.Add(d);
            dc.SaveChanges();
            UpdateISection();
            MessageBox.Show("����� ����� ��������");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using DataContext cd = new DataContext();
            var listISection = cd.ISections.Select(s => new { s.Id, s.Name }).ToList();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            string path = sfd.FileName;
            string json = JsonConvert.SerializeObject(listISection, Formatting.Indented);

            using StreamWriter sw = new StreamWriter(path);
            sw.Write(json);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listView1.SelectedItems)
            {
                var temp = item as ListViewItem;
                var text = temp.Text;
                using DataContext db = new DataContext();
                var section = db.ISections.First(i => i.Name == text);
                ListWorkers ls = new ListWorkers(section.Id);
                ls.Show();
            }
        }
    }
}