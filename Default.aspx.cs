using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    public class Student
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    public List<Student> listsv = new List<Student>();

   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        for (int i = 0; i < 10; i++)
        {
            Student student = new Student();
            student.FirstName = "Pham "+i;
            student.LastName = "Hoang "+i;
            student.Age = 1+i;
            listsv.Add(student);
        }
       
    }
}