using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Employee
    {
        public int empID { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public int salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 5, 6, 7, 8 };

            var arrUnion = arr1.Union(arr2);
            var arrIntersect = arr1.Intersect(arr2);

            var arr1Take = arr1.Take(3);
            var arr1TakeWhile = arr1.TakeWhile(x => x < 5);

            var arr2Skip = arr2.Skip(2);

            foreach (int i in arr2Skip)
                Console.WriteLine("i: "+i);

            Console.WriteLine(arr1.Average());
            Console.WriteLine(arr1.Average(x=>x+1));
            Console.WriteLine(arr1.Sum());


            //Employee[] empList = new Employee[]{
            //    new Employee{empID=1, name="Zjohn", location="Bangalore", salary=123},
            //    new Employee{empID=2, name="Rob", location="China", salary=1234},
            //    new Employee{empID=3, name="Rob", location="Bangalore", salary=12345},
            //    new Employee{empID=3, name="Rob", location="Bangalore", salary=12345}
            //};

            //var bangaloreeEmpList = (from emp in empList
            //                        where emp.location == "Bangalore"
            //                        orderby emp.empID ascending
            //                        select new {emp.empID, emp.name, halfSalary=emp.salary/2 }).Distinct();
            //foreach (var emp in bangaloreeEmpList)
            //    Console.WriteLine("name: "+emp.name+" id: "+emp.empID+" half salary: "+emp.halfSalary);

            //var bangaloreeEmpList = from emp in empList
            //                        where emp.location == "Bangalore"
            //                        select emp.empID;
            //foreach (var emp in bangaloreeEmpList)
            //    Console.WriteLine(emp);

            //var bangaloreeEmpList = from emp in empList
            //                        where emp.location == "Bangalore"
            //                        select emp;
            //foreach (var emp in bangaloreeEmpList)
            //    Console.WriteLine(emp.name);

            //string[] empList = new string[] { "Dog", "Cat", "Rat" };

            //var result = from e in empList
            //             orderby e 
            //             select e;
            //foreach (var item in result)
            //{
            //    Console.WriteLine("item: " + item + "\n");
            //}

            //int[] numList = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //var evenNumList = numList.Where(x => x % 2 == 0);

            //deffered even num list
            //var evenNumList = from e in numList
            //                  where e % 2 == 0
            //                  select e;

            //immediate even num list
            //var evenNumList = (from e in numList
            //                  where e % 2 == 0
            //                  select e).ToList();


            //foreach (int i in evenNumList) 
            //    Console.WriteLine("num: " + i);
        }
    }
}
