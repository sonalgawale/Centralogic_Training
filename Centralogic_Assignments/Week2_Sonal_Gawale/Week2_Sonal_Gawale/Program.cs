using System.Collections.Generic;
using System;

public class TaskList1
{
    static List<(string title , string description)> taskList = new List<(string title, string description)>();                               //List Declaration

    static void taskListApplication()                                               //Task List Application
    {

        Console.WriteLine("\nTask List Application");
        Console.WriteLine("1. Create Task ");
        Console.WriteLine("2. Read Task ");
        Console.WriteLine("3. Update Task ");
        Console.WriteLine("4. Delete Task ");
        Console.WriteLine("5. Exit");
        Console.Write("\nEnter Your Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {
                    //create
                    createTask();
                    taskListApplication();
                    break;
                }
            case 2:
                {
                    //read
                    readTask();
                    taskListApplication();
                    break;
                }
            case 3:
                {
                    //update 
                    updateTask();
                    taskListApplication();
                    break;
                }
            case 4:
                {
                    //delete
                    deleteTask();
                    taskListApplication();
                    break;
                }
            case 5:
                {
                    //exit;
                    Console.WriteLine("Thank You:)");
                    Environment.Exit(0);
                   
                    break;
                }
            default:
                {
                    Console.WriteLine("Please Select valid choice !");
                    break;
                }
        }

    }

    static void createTask()                                                           //Create Task
    {
        Console.Write("Enter Task Title: ");
        string task_title = Console.ReadLine();
        Console.Write("Enter Task Description : ");
        string task_description = Console.ReadLine();

        taskList.Add((task_title, task_description));
        Console.WriteLine("Your Task Added Successfully!\n");
    }

    static void readTask()                                                              //Read Task
    {
        if(taskList.Count == 0)
        {
            Console.WriteLine("Sorry, your task list is empty. You cannot perform this operation.");
        }
        else
        {
            Console.WriteLine("\nTask List : ");
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Title:{taskList[i].title} \n   Description:{taskList[i].description}");
                Console.WriteLine();
            }
        }
    }


    static void updateTask()                                                         //Update Task
    {
        if(taskList.Count == 0)
        {
            Console.WriteLine("Sorry, your task list is empty. You cannot perform this operation.");
        }
        else
        {
            Console.Write("Enter The Task Number Which you want to update : ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index >= 1 && index <= taskList.Count)
            {
                Console.Write("Enter Task Title: ");
                string newTitle = Console.ReadLine();
                Console.Write("Enter Task Description : ");
                string newDescription = Console.ReadLine();

                taskList[index - 1] = (newTitle, newDescription);
                Console.WriteLine("Task List Updated Successfully!\n");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Number.\n");
            }
        }
    }

    static void deleteTask()                                                        //Delete Task
    {
        if (taskList.Count == 0)
        {
            Console.WriteLine("Sorry, your task list is empty. You cannot perform this operation.");
        }
        else
        {
            readTask();
            Console.Write("Enter The Task Number Which you want to delete : ");
            int delIndex = Convert.ToInt32(Console.ReadLine());
            if (delIndex >= 1 && delIndex <= taskList.Count)
            {
                taskList.RemoveAt(delIndex - 1);
                Console.WriteLine("Task Deleted Successfully!\n");
            }
            else
            {
                Console.WriteLine("Please Enter Valid  Task Number.\n");
            }
        }
    }
    public static void Main(string[] args)                  
    {
        taskListApplication();
    }
}
