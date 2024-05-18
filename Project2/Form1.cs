namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> students;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() { "Emre Baycan", "Baris Cirika", "Sinan Dindar" };

            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
            lblCountStudent.Text = students.Count.ToString();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (tbxStudentName.Text.Length > 2)
            {
                students.Add(tbxStudentName.Text);
                lbxStudentList.Items.Clear();
                tbxStudentName.Text = string.Empty;

                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
                lblCountStudent.Text = students.Count.ToString();
            }
            else
            {
                MessageBox.Show("Ogrenci ismini eksiksiz giriniz.");
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbxStudentList.SelectedItem != null)
            {
                students.Remove(lbxStudentList.SelectedItem.ToString());
                lbxStudentList.Items.Clear();

                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
                lblCountStudent.Text = students.Count.ToString();
            }
            else
            {
                MessageBox.Show("Silinecek ogrenciyi seciniz.");
            }
        }

        private void lblStudentList_Click(object sender, EventArgs e)
        {

        }
    }
}