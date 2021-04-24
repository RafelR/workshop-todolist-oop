namespace TodoListOOP.Entity {
    public class TodoList {
        public string todo { get; set; }
        
        public TodoList() { }

        public TodoList(string paramTodo) {
            todo = paramTodo;
        }
    }
}