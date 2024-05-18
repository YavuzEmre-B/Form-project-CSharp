namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.FirstName = "Yavuz";
            student1.Age = 35;
            student1.Mail = "yavuz@gmail.com";

            Student student2 = new Student();
            student2.FirstName = "Emre";
            student2.Age = 36;
            student2.Mail = "emre@gmail.com";

            Student student3 = new Student();
            student3.FirstName = "Derin";
            student3.Age = 37;
            student3.Mail = "derin@gmail.com";

            List<Student> students = new List<Student>() { student1, student2, student3 };

            foreach (var student in students)
            {
                //MessageBox.Show(student.FirstName + " " + student.Age + " " + student.Mail);
                lbxStudents.Items.Add(student.FirstName);
            }

            dgrwStudents.DataSource = students;
        }
    }
}