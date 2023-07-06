/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestAssignment3
{
    internal class Department1
    {
        public int Id;
        public string Name;
        List<Department1> SubDepartment = new List<Department1>();

        public static void AddingData()
        {

            //Creating The Main IT dept
            Department1 it = new Department1();
            it.Id = 1;
            it.Name = "IT";


            //Creating Sub Departments Under IT -- Development
            Department1 development = new Department1();
            development.Id = 11;
            development.Name = "Devlopment";

            it.SubDepartment.Add(development);

            //Creating Sub Departments Under IT -- Testing
            Department1 testing = new Department1();
            testing.Id = 21;
            testing.Name = "Testing";

            it.SubDepartment.Add(testing);

            //Creating Sub Departments Under IT -- IT Admin
            Department1 it_admin = new Department1();
            it_admin.Id = 31;
            it_admin.Name = "IT Admin";

            it.SubDepartment.Add(it_admin);

            //Creating Sub Departments Under IT/Development
            Department1 frontend = new Department1();
            frontend.Name = "Front End";
            frontend.Id = 111;

            development.SubDepartment.Add(frontend);

            //Creating Sub Departments Under IT/Development
            Department1 backend = new Department1();
            backend.Id = 112;
            backend.Name = "Back End";

            development.SubDepartment.Add(backend);

            //Creating Sub Departments Under IT/Testing
            Department1 manual = new Department1();
            manual.Id = 211;
            manual.Name = "Manual";

            testing.SubDepartment.Add(manual);

            //Creating Sub Departments Under IT/Testing
            Department1 automation = new Department1();
            automation.Name = "Automation";
            automation.Id = 212;

            testing.SubDepartment.Add(automation);


            Displaydepartments(it);

        }
        public static void Displaydepartments(Department1 dept)
        {
            if (dept == null)
                return;
            else
            {
                Console.WriteLine(dept.Name +" "+ dept.Id);
                foreach(Department1 d in dept.SubDepartment) 
                { 
                    Displaydepartments(d);
                }
            }
        }


    }

    class Program
    {
        public static void Main(string[] args)
        {
            Department1.AddingData();

        }
    }

}
*/