using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            
                

            IList<int> oneElementList = new List<int>() { 8 };
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            //first element in list
            Console.WriteLine("1st Element in intList: {0}", intList.First());
            Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));
            Console.WriteLine("1st Element in strList: {0}", strList.First());

            //firstordefolult elemnt inlist
            Console.WriteLine("1st Element in intList: {0}", intList.FirstOrDefault());
            Console.WriteLine("1st Even Element in intList: {0}", intList.FirstOrDefault(i => i % 2 == 0));
            Console.WriteLine("1st Element in strList: {0}", strList.FirstOrDefault());
            Console.WriteLine("1st Element in emptyList: {0}", emptyList.FirstOrDefault());

            //sinle elemnt  and singleordefoult in list
            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
            Console.WriteLine("The only element in oneElementList: {0}",
                         oneElementList.SingleOrDefault());
            //it will trouw an error becouse this emply
            Console.WriteLine("Element in emptyList: {0}", emptyList.Single());
            Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());
            Console.WriteLine("The only element which is less than 10 in intList: {0}",
                         intList.Single(i => i < 10));

            //element and elementoedefoult
            Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));
            //it will throw an error becouse element is not exit at index 9
            Console.WriteLine(intList.ElementAt(9));

            Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
            Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));
            //it will show message
            Console.WriteLine("10th Element in intList: {0} - default int value",
                intList.ElementAtOrDefault(9));
            Console.WriteLine("10th Element in strList: {0} - default string value (null)",
                             strList.ElementAtOrDefault(9));



            // Student collection
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
        };

            var studentNames = studentList.Where(s => s.Age > 18)
                                  .Select(s => s)
                                  .Where(st => st.StandardID > 0)
                                  .Select(s => s.StudentName);


            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }






        }

public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
