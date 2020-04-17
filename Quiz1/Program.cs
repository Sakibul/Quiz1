using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program(); // to call all the non-static methods
            // *************************************************************
            // Question-1: In separate text file = Question1.txt
            // *************************************************************
            // Question-2: Create a class Name is as Employee (id, name, salary)
            // a. Use a generic collection to put 5 employees in that. (Use optional data)
            // b. Iterate through the collection and Write the name of the employee in the console.
            // c. Use delegate to find the lowest and highest salary among the employee.


            // Employee emp = new Employee(1, "Sakibul Islam Khan", 10000);
            // *******************************
            // Question-2a: Use a generic collection to put 5 employees in that. (Use optional data)

            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(new Employee(101, "Amani Farani Mohammad Amin", 10000));
            listEmployees.Add(new Employee(102, "Ding Dezhi", 20000));
            listEmployees.Add(new Employee(103, "Gao Peng", 30000));
            listEmployees.Add(new Employee(104, "Hanzel Michael", 40000));
            listEmployees.Add(new Employee(105, "Hritcu Daniel", 50000));
            // *******************************
            // Question-2a: Iterate through the collection and Write the name of the employee in the console.

            Console.WriteLine("List ==>");

            foreach (var item in listEmployees)
            {
                Console.WriteLine(item.ToString()); // listEmployees
            }

            Console.WriteLine(); // BLANK line
            // *******************************
            // Question-2c: Use delegate to find the lowest and highest salary among the employee.

            Hashtable hashTable = new Hashtable();
            hashTable.Add("111", "Nakov Valeri");
            hashTable.Add("112", "Patel Payalben");
            hashTable.Add("113", "Pavlenko Daniil");
            hashTable.Add("114", "Schaffhauser-Bilney Alex");
            hashTable.Add("115", "Ta Zhanzhou");

            // *********************************
            // iterate through them and print them out in the console:

            Console.WriteLine("HashTable ==>");

            foreach (DictionaryEntry element in hashTable)
            {
                Console.WriteLine("Key = {0}, Value = {1}", element.Key, element.Value);
            }

            Console.WriteLine(); // BLANK line
            // *******************************
            // *************************************************************
            // Question-3: Use Tuple to create an object which has 3 fields (name, age, address) 
            //             and print the fields in the console.

            p.Question3_Tuple2CreateObject();
            // *************************************************************
            // Question-4: Use Dictionary to keep the values of Information of 5 employees in question 2

            Console.WriteLine("Question-4: Use Dictionary to keep the values of Information of 5 employees in question 2 ==>");

            

            Console.WriteLine("--------------------------------------------------------------");
            // *************************************************************
            // Question-5: Create a Generic Class the only accepts class reference.

            Console.WriteLine("Question-5: Create a Generic Class the only accepts class reference ==>");

            MyGenericClassThatOnlyAcceptsClassReference<string>.PrintTheParameter("Sakibul Islam Khan");

            Console.WriteLine("--------------------------------------------------------------");
            // *************************************************************
            // Question-6: Use Extension method for integer to check if the number is dividable by 3.

            Console.WriteLine("Question-6: Use Extension method for integer to check if the number is dividable by 3 ==>");

            int x = 12345;
            bool answer6 = x.IsDivisibleBy3();
            Console.WriteLine("IsDivisibleBy3 = " + answer6);

            Console.WriteLine("--------------------------------------------------------------");
            // *************************************************************
            // Question-7: Write a method that has one string parameter.
            //             By Using predicate check if that string has vowel
            //             sounds and print all the vowel sounds in the output.

            p.Question7_Predicate2CheckAndPrintVowels("Sakibul Islam Khan");
            // *************************************************************
            Console.ReadKey();
        }

        public Program() { } // to call all the non-static methods

        public void Question3_Tuple2CreateObject()
        {
            Console.WriteLine("Question-3: Use Tuple to create an object ==>");

            var myTuple = Tuple.Create<string, int, string>
                            ("Sakibul Islam Khan", 40, "1632 Rue Allard, Montreal, QC, H4E 2K5");


            Console.WriteLine($"name: {myTuple.Item1}"); // next line & this line are the same
            Console.WriteLine("name: {0}", myTuple.Item1); // above line & this line are the same

            Console.WriteLine($"age: {myTuple.Item2}"); // next line & this line are the same
            Console.WriteLine("age: {0}", myTuple.Item2); // above line & this line are the same

            Console.WriteLine($"address: {myTuple.Item3}"); // next line & this line are the same
            Console.WriteLine("address: {0}", myTuple.Item3); // above line & this line are the same


            Console.WriteLine("--------------------------------------------------------------");
        }

        public void Question7_Predicate2CheckAndPrintVowels(string str2test)
        {
            Console.WriteLine("Question-7: Predicate to check & print all vowels ==>");

            // with anonynous method:
            Predicate<string> question7 = delegate (string str) {
                bool answer = false; // default value

                char[] arr = str.ToCharArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    if(
                        (arr[i] == 'a') || (arr[i] == 'e') || (arr[i] == 'i') || (arr[i] == 'o') || (arr[i] == 'u') ||
                        (arr[i] == 'A') || (arr[i] == 'E') || (arr[i] == 'I') || (arr[i] == 'O') || (arr[i] == 'U')
                      )
                    {
                        answer = true;
                        Console.Write(arr[i] + "\t");
                    }
                }

                Console.WriteLine(); // BLANK line

                return answer;
            };

            question7(str2test);

            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
