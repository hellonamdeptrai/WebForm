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
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public int Age { get; set; }
    }
    public List<Student> listsv = new List<Student>();

   
    protected void Page_Load(object sender, EventArgs e)
    {
        Student[] student = new Student[10];
        for (int i = 0; i < 10; i++)
        {
            student[i] = new Student();
            student[i].FirstName = "Pham "+i;
            student[i].LastName = "Hoang "+i;
            student[i].Age = 1+i;
            listsv.Add(student[i]);
        }
       
    }
}