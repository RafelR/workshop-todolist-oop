using TodoListOOP.Repository;
using TodoListOOP.Service;
using TodoListOOP.View;

namespace TodoListOOP {
    class Program {
        static void Main(string[] args) {
            ITodoRepository todoRepository = new TodoRepository();
            ITodoService todoService = new TodoService(todoRepository);
            var todoView = new TodoView(todoService);
            
            todoView.ViewShowTodoList();
        }
    }

}