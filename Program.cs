




// Collections (objects, lists, arrays and such structures) in C#
// In JS we could
// let todolist = ["task", "another task", "osv"]

// Loops in (forof array)
// forof (let element of array) etc...


// Console based to-do list app (CLI-app) Command Line Interface

// Data related things
List<string> todolist = new List<string>();

todolist.Add("Eat");
todolist.Add("Sleep");
todolist.Add("Code");

// I. Show user initial UI menu

// To-Do list menu:
// 1. Add Task
// 2. List all Tasks
// 3. Remove a Task
// 4. Exit interface



bool running = true;

// II. Await user input (in an infinite loop)
while(running)
{
Console.WriteLine("To-Do list menu");

Console.WriteLine("1. Add task");
Console.WriteLine("2. List all tasks");
Console.WriteLine("3. Remove a task");
Console.WriteLine("4. Exit interface");
    
string choice = Console.ReadLine();

Console.WriteLine("User chose: " + choice);

    if (choice == "1") // 1. Add task
    {
        Console.WriteLine("Enter your task: ");
        string newTodo = Console.ReadLine();
    }

    else if (choice == "2") // 2. List all tasks
    {
        foreach (var Task in todolist)
        {
            Console.WriteLine(Task);
        }
    }

    else if (choice == "3")
    {
        
    }

    else if (choice == "4")
    {
        running = false;
    }
}
