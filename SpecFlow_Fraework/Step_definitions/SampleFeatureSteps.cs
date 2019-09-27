using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowFraework;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace SpecFlowFraework
{
    [Binding]
    public class CalculatorSteps
    {
    

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
           Console.WriteLine(numbers);
        }

        //[Given(@"I have also entered (.*) into the calculator")]
        //public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        //{
        //    calculator.SecondNumber = number;
        //}

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Presse4d Add Butoon");
            //result = calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int Result)
        {
            if (Result == 140)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
                throw new Exception("The valuie is different");
            }
            //Assert.AreEqual(expectedResult, result);
        }
        [When(@"I fill all mandatory details in form")]
        public void WhenIFillAllMandatoryDetailsInForm(Table table)
        {
            var details = table.CreateSet<EmployeeDetails>();
            foreach (EmployeeDetails emp in details)
            {
                Console.WriteLine("The detail of employee :" + emp.Name);
                Console.WriteLine("**********************************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Phone);
                Console.WriteLine(emp.Name);
            }
            //dynamic
            // IEnumerable<dynamic> details = table.CreateDynamicSet();
            //// var details = table.CreateDynamicSet();
            // foreach (var emp in details)
            // {
            //     Console.WriteLine("The detail of employee :" + emp.Name);
            //     Console.WriteLine("**********************************");
            //     Console.WriteLine(emp.Age);
            //     Console.WriteLine(emp.Email);
            //     Console.WriteLine(emp.Phone);
            //     Console.WriteLine(emp.Name);
            // }
        }
        [When(@"I fill all mandatory details in form (.*), (.*) and (.*)")]
        public void WhenIFillAllMandatoryDetailsInFormAnd(string Name, int Age, Int64 Phone)
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("age:" + Age);
            Console.WriteLine("Phone:" + Phone);

            ScenarioContext.Current["InforforNextStep"] = "step 1 Passed";

            Console.WriteLine(ScenarioContext.Current["InforforNextStep"].ToString());
            List<EmployeeDetails> empDetails = new List<EmployeeDetails>();
            {
                new EmployeeDetails()
                {
                    Name = "Karthik",
                    Age = 28,
                    Email = "baldev.uit@gmail.com",
                    Phone = 8921989514
                };
                new EmployeeDetails()
                {
                    Name = "Preeth",
                    Age = 28,
                    Email = "baldev.uit@gmail.com",
                    Phone = 8921989514
                };
                new EmployeeDetails()
                {
                    Name = "Thakur",
                    Age = 28,
                    Email = "baldev.uit@gmail.com",
                    Phone = 8921989514
                };
            };
            //Save the value in scenario context
            ScenarioContext.Current.Add("EmpDetails", empDetails);

            //get teh value out from scenariocontext
           var emplist = ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");
            foreach (EmployeeDetails emp in emplist)
            {
                Console.WriteLine("The Emp Name is:" + emp.Name);
                Console.WriteLine("The Emp Age is:" + emp.Age);
                Console.WriteLine("The Emp Email is:" + emp.Email);
                Console.WriteLine("The Emp Phone is:" + emp.Phone);
            }
        }


    }
}