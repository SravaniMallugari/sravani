using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_handson
{
    internal class qstn5
    {
        static void Main(string[] args)
        {
            employees b1 = new employees();

            int EmpNo;
            string Ename;
            float Salary;
            int Dno;
            Console.WriteLine("Enter EmpNo");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Empname");
            Ename = Console.ReadLine();
            Console.WriteLine("Enter salary");
            Salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter DeptNo");
            Dno = Convert.ToInt32(Console.ReadLine());
            b1.AcceptData(EmpNo, Ename, Salary, Dno);

            Console.WriteLine("Print the details");
            b1.display();

            Console.ReadLine();



        }
    }
    struct employees
    {
        public int EmpNo;
        public string Ename;
        public float Salary;
        public int deptno;
        public void AcceptData(int empno, string ename, float salary, int dno)
        {
            EmpNo = empno;
            Ename = ename;
            Salary = salary;
            deptno = dno;
        }



        public void display()
        {
            Console.WriteLine("{0} {1} {2} {3}\n", EmpNo, Ename, Salary, deptno);
        }
    }
}

