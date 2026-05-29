# Todolist backend

Program.cs (Main Program):
 - Handles UI, and uses the TodoService

TodoService:
 - Handles business logic of todo
 - Temporary (also works in a memory database)
 
TodoItem:
 - Model for each item


 ## Future plan:

 Create a TodoRepository class
  - Contains methods (functions) to ready and store data.

## Future plan:

 - Remove everything from Program.cs except call to services:
  - TodoListService
  - Other services
  - UIs
  - And so on