using System.Data.OleDb;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace Student_Info
{
    public partial class Form1 : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConTest_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\L23Y08W19\\Downloads\\StudentInfo2.mdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\L23Y08W19\\Downloads\\StudentInfo2.mdb");

            da = new OleDbDataAdapter("SELECT *FROM Student", myConn);
            //or da = new OleDbDataAdapter("SELECT Student.LastName, Student.FirstName,
            //Student.Course, SubjectsEnrolled.*, FinalGrade.StudentID\r\nFROM (Student
            //INNER JOIN SubjectsEnrolled ON Student.StudentID =
            //SubjectsEnrolled.StudentID) INNER JOIN FinalGrade ON Student.StudentID =
            //FinalGrade.StudentID", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Student");
            dgvStudentInfo.DataSource = ds.Tables["Student"];
            myConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "Insert into Student (LastName, FirstName, Course, Year Level) values (@LName, @FName, @Course, @Ylevel)";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@LName", tbxLname.Text);
            cmd.Parameters.AddWithValue("@FName", tbxFname.Text);
            cmd.Parameters.AddWithValue("@Course", tbxCourse.Text);
            cmd.Parameters.AddWithValue("@Ylevel", tbxYlevel.Text);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
            btnLoadData_Click(sender, e);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From Student Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id", dgvStudentInfo.CurrentRow.Cells[0].Value);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
            btnLoadData_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set LastName = @Lname, FirstName = @Fname, Course = @Course, Year Level = @Ylevel Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@ln", tbxLname.Text);
            cmd.Parameters.AddWithValue("@fn", tbxFname.Text);
            cmd.Parameters.AddWithValue("@COURSE", tbxCourse.Text);
            cmd.Parameters.AddWithValue("@Ylevel", tbxYlevel.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbxID.Text));
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
            btnLoadData_Click(sender, e);
        }
    }
}