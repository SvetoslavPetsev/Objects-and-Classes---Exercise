using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Order_by_Age
{
    public class People
    { 
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public People(string name, string iD, int age)
        {
            this.Name = name;
            this.ID = iD;
            this.Age = age;        
        }
    
    }
    class Program
    {
        static void Main()
        {
            List<People> peopleList = new List<People>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] peopleInfo = input.Split();

                string name = peopleInfo[0];
                string iD = peopleInfo[1];
                int age = int.Parse(peopleInfo[2]);

                People newPeople = new People(name, iD, age);

                peopleList.Add(newPeople);

            }

            peopleList = peopleList.OrderBy(x => x.Age).ToList();

            for (int i = 0; i < peopleList.Count; i++)
            {
                Console.WriteLine($"{peopleList[i].Name} with ID: {peopleList[i].ID} is {peopleList[i].Age} years old.");
            }

        }
    }
}
