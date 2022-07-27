using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day3
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");
            /*
            Student student = new Student();//object creation
            student.DisplayStudentDetails();
            student.SetStudentDetails(1000,"Sushant",27);
            student.DisplayStudentDetails();*/

            /*
            var student = new Student();
            student.SetStudentDetails(2000,"Sakpal",45);
            student.DisplayStudentDetails();

            // Ananomous Object Creation
            new Student().SetStudentDetails(3000, "Narya", 27);
            new Student().DisplayStudentDetails();*/

            MethodCalling methodCalling = new MethodCalling();
            int a = 20, b = 30;
            /*Console.WriteLine($"a:{a}\tb:{b}");

            methodCalling.CallByRef(ref a, ref b);

            Console.WriteLine($"a:{a}\tb:{b}");*/

            /*int sum, multiply;
            methodCalling.CallByOut(a, b, out sum, out multiply);
            Console.WriteLine($"sum:{sum}\tMultiplication:{multiply}");*/
            /*
            int[] arr = { 1, 2, 3, 4, };
            int result = methodCalling.CallByVarArgs("*",arr);
            Console.WriteLine($"Sum is : {result}");
            Console.WriteLine($"Sum is :{methodCalling.CallByVarArgs("Susu",20, 30)}");
            Console.WriteLine($"Sum is :{methodCalling.CallByVarArgs("Narya",20, 30, 50)}");
            Console.WriteLine($"Sum is :{methodCalling.CallByVarArgs("Amol",20, 30, 50, 70)}");
            */

            methodCalling.Message("Narendra", "Patil", 200000);
            methodCalling.Message("Narendra");
            methodCalling.Message("Narendra",salary:450000);
            methodCalling.Message(salary:45000,fname:"Ramchandra");
            methodCalling.Message(surname:"Mittal",fname: "Ramchandra");
            methodCalling.Message(surname: "Mittal", fname: "Ramchandra",salary:50000);


        }
    }
}
