using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;

namespace HelloWorldWorkflow
{
    public class Person
    {
        public string Name { get; set; }
        public string Sex { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            Console.WriteLine("Are you male or female?");
            string sex = Console.ReadLine();

            if (String.Equals(sex[0].ToString().ToUpper(), "M"))
            {
                p.Sex = "Male";
                p.Name = "Glenn";
            }
            else
            {
                p.Sex = "Female";
                p.Name = "Gemma";
            }

            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1, new Dictionary<string, object> { { "Input", p } });

            Console.ReadLine();
        }
    }

    
}

//namespace HelloWorldWorkflow.Entity
//{

//}
