class TodoService
{
    // Business Logic (No UI)
    private List<TodoItem> todolist = new List<TodoItem>();

    public void AddTodo(string todoText)
    {
        TodoItem newTodo = new TodoItem();
    }
    public List<TodoItem> GetAllTodos()
    {
        return todolist;
    }
}