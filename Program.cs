// Console based to-do list app (CLI-app) Command Line Interface

// SaaS - Software as a Service
// Separation of Concerns
// Create an instance of the TodoService
TodoService todoService = new TodoService();




bool running = true; // UI

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
    todoService.AddTodo(Console.ReadLine());
}

void ListAllTasks()
{
    Console.WriteLine();
    // Get the todolist items from the service and then structure them here:
    List<TodoItem> todos = todoService.GetAllTodos();

    foreach (TodoItem task in todoService.GetAllTodos)
    {
        Console.WriteLine(task.TaskName);
    }
}

void DeleteTask()
{
    
}

void ExitTodoApp()
{
    running = false;
}