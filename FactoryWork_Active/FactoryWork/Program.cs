
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysDemo();
            SimpleListsDemo();
            SimpleStackDemo();
            //SimpleQueueDemo();
            //SimpleDictionaryDemo();
        }

        static void ArraysDemo()
        {
            int[] myIntegers = new int[10];
            myIntegers[0] = 42;

            char[] myChars = { 'H', 'e', 'l', 'l', 'o' };

            for (int i = 0; i < myIntegers.Length; i++)
            {
                myIntegers[i] = i;
            }

            Console.Write("Array contents: ");
            foreach (int myInt in myIntegers)
            {
                Console.Write("{0} ", myInt);
            }

            Console.Write("\n");

            Location loc = new Location();

            Employee[] employees = new Employee[10];
            HourlyPaidEmployee emp1 = new HourlyPaidEmployee(1, "Michael",
                "michael", loc, "1234");
            SalariedEmployee emp2 = new SalariedEmployee(2, "Susan", "susan",
                loc, "5678", 6);
            employees[0] = emp1;
            employees[1] = emp2;

            SalariedEmployee semp = (SalariedEmployee)employees[1];
            int grade = semp.PayGrade;

            int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] siblings = new string[2, 2] {
                { "Mike", "Amy" },
                { "Mary", "Albert" }
                };

            Console.ReadLine();
        }

        static void SimpleListsDemo()
        {
            Location loc = new Location();

            //ISimpleList employees = new SimpleArrayList();
            ISimpleList employees = new SimpleLinkedList();
            //SimpleGenericArrayList<Employee> employees = new SimpleGenericArrayList<Employee>();

            HourlyPaidEmployee emp1 = new HourlyPaidEmployee(1, "Michael",
                "michael", loc, "1234");
            SalariedEmployee emp2 = new SalariedEmployee(2, "Susan", "susan",
                loc, "5678", 6);

            employees.Add(emp1);
            employees.Add(emp2);


            SalariedEmployee semp = (SalariedEmployee)employees.Get(1);
            int grade = semp.PayGrade;

            Employee emp = (Employee)employees.Get(0);   // need to cast 
            emp.Move(new Location());

            Employee target = new SalariedEmployee(1, null, null, null, null, 0);
            employees.Remove(target);

            Console.ReadLine();
        }

        static void SimpleStackDemo()
        {
            SimpleLinkedListStack employees = new SimpleLinkedListStack();

            HourlyPaidEmployee emp1 = new HourlyPaidEmployee(1, "Michael",
                "michael", null, "1234");
            SalariedEmployee emp2 = new SalariedEmployee(2, "Susan", "susan",
                null, "5678", 6);
            HourlyPaidEmployee emp3 = new HourlyPaidEmployee(3, "Ahmad",
                "ahmad", null, "5678");

            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);

            Employee emp = (Employee)employees.Pop();
            Console.WriteLine("Employee {0} popped", emp.Name);
            emp = (Employee)employees.Pop();
            Console.WriteLine("Employee {0} popped", emp.Name);

            Console.ReadLine();
        }

        /*static void SimpleQueueDemo()
        {
            SimpleQueue employees = new SimpleQueue();

            HourlyPaidEmployee emp1 = new HourlyPaidEmployee(1, "Michael",
                "michael", null, "1234");
            SalariedEmployee emp2 = new SalariedEmployee(2, "Susan", "susan",
                null, "5678", 6);
            HourlyPaidEmployee emp3 = new HourlyPaidEmployee(3, "Ahmad",
                "ahmad", null, "5678");

            employees.Enqueue(emp1);
            employees.Enqueue(emp2);
            employees.Enqueue(emp3);

            Employee emp = (Employee)employees.Dequeue();
            Console.WriteLine("Employee {0} dequeued", emp.Name);
            emp = (Employee)employees.Dequeue();
            Console.WriteLine("Employee {0} dequeued", emp.Name);

            Console.ReadLine();
        }

        static void SimpleDictionaryDemo()
        {
            SimpleDictionary employees = new SimpleDictionary();
            //SimpleBST employees = new SimpleBST();

            HourlyPaidEmployee emp1 = new HourlyPaidEmployee(1, "Michael",
                "michael", null, "1234");
            SalariedEmployee emp2 = new SalariedEmployee(2, "Susan", "susan",
                null, "5678", 6);
            HourlyPaidEmployee emp3 = new HourlyPaidEmployee(3, "Ahmad",
                "ahmad", null, "5678");

            employees.Put("michael", emp1);
            employees.Put("susan", emp2);
            employees.Put("ahmad", emp3);

            Employee emp = (Employee)employees.Get("susan");
            Console.WriteLine("Employee {0} retrieved", emp.Name);

            Console.ReadLine();
        }

        static void BoxingDemo()
        {
            SimpleArrayList sal = new SimpleArrayList();

            sal.Add(3);

            int i = (int)sal.Get(0);

            SimpleGenericArrayList<int> sgal =
                new SimpleGenericArrayList<int>();

            sgal.Add(3);

            int j = sgal.Get(0);

            SimpleGenericArrayList<Employee> sga =
                new SimpleGenericArrayList<Employee>();

        }
        */
    }
}
