// Console based to-do list app (CLI-app) Command Line Interface

// Data related things

List<string> todolist = new List<string>();

todolist.Add("Eat");
todolist.Add("Sleep");
todolist.Add("Code");
//
bool running = true;

// II. Await user input (in an infinite loop)
while(running)
{

ShowMenu(); // Show the menu
    
string choice = Console.ReadLine();

Console.WriteLine("User chose: " + choice);

    if (choice == "1") // 1. Add task
    {
        AddTask();
    }
    else if (choice == "2") // 2. List all tasks
    {
        ListAllTasks();
    }
    else if (choice == "3") // 3. Delete a task
    {
        DeleteTask();
    }
    else if (choice == "4") // 4. Exit interface
    {
        ExitTodoApp();
    }
}


void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("To-Do list menu");

    Console.WriteLine("1. Add task");
    Console.WriteLine("2. List all tasks");
    Console.WriteLine("3. Remove a task");
    Console.WriteLine("4. Exit interface");
    Console.WriteLine("Enter an option: "); 
}

void AddTask()
{
    Console.WriteLine("Enter your task: ");
    string newTodo = Console.ReadLine();
    todolist.Add(newTodo); 
}

void ListAllTasks()
{
        foreach (var Task in todolist)
    {
        Console.WriteLine(Task);
    }
}

void DeleteTask()
{
    
}

void ExitTodoApp()
{
    running = false;
}