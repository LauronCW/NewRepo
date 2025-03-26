using SMS.Domain;

namespace SMS.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createStudent(1, "Helena Eagan", "helena@eagan.com");
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            createStudent(2, "Mark Scout", "mark@scout.com");
        }
        private void createStudent(int id, string name, string email)
        {
            var student = new Student
            {
                StudentId = id,
                StudentName = name,
                Email = email
            };

            textBoxId.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;
            textBoxEmail.Text = student.Email;
        }
    }
}
