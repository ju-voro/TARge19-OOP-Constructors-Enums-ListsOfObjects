using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TaskList
{
    class Task
    {
        public static int Count = 0;

        public string description;

        public Task(string _description)
        {
            description = _description;
            Count++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\demo\tasklist.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<Task> taskList = new List<Task>();

            foreach(string line in lines)
            {
                //Create a TASK object at each line that we read from the file
                Task newTask = new Task(line);
                //add the object to the taskList
                taskList.Add(newTask);
            }

            int i = 1;

            foreach(Task task in taskList)
            {
                Console.WriteLine($"Task {i} on your TODO list is to {task.description}");
                i++;
            }
            //get a task from the user
            Console.WriteLine("Add a new task: ");
            //save the task to the userTaskInputVariable
            string userTaskInput = Console.ReadLine();
            //create a new Task class object with userTaskInput as a parameter
            Task userTask = new Task(userTaskInput);
            //save the userTask to the taskList
            taskList.Add(userTask);

            Console.WriteLine("\n Updated task list:");
            int j = 1;
            foreach (Task task in taskList)
            {
                Console.WriteLine($"Task {j} on your TODO list is to {task.description}");
                j++;
            }
            //create a new list of strings to write to the file
            List<string> outputToWriteToFile = new List<string>();

            foreach(Task task in taskList)
            {
                outputToWriteToFile.Add($"{ task.description}");
            }

            Console.WriteLine("Writing to a file...");
            //Write to outputToWriteToFile
            File.WriteAllLines(filePath, outputToWriteToFile);
            Console.WriteLine("Your task has been added");
            Console.ReadLine();

        }
    }
}
