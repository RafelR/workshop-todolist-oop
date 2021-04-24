using System;
using TodoListOOP.Entity;
using TodoListOOP.Repository;

namespace TodoListOOP.Service {
    public interface ITodoService {
        void ShowTodoList();
        void AddTodoList(string todo);
        void RemoveTodoList(int no);
    }

    public class TodoService : ITodoService {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository) {
            _todoRepository = todoRepository;
        }

        public void ShowTodoList() {
            var todoLists = _todoRepository.GetAll();

            Console.WriteLine("TODOLIST");
            for (var i = 0; i < todoLists.Length; i++) {
                var todo = todoLists[i];
                var no = i + 1;
                if (todo != null) {
                    Console.WriteLine(no + ". " + todo.todo);
                }
            }
        }

        public void AddTodoList(string todo) {
            var todoList = new TodoList(todo);
            _todoRepository.Add(todoList);
            Console.WriteLine("Sukses Menambah Todo : " + todoList.todo);
        }

        public void RemoveTodoList(int no) {
            var success = _todoRepository.Remove(no);
            if (success) {
                Console.WriteLine("Sukses Menghapus Todo : " + no);
            } else {
                Console.WriteLine("Gagal Menghapus Todo : " + no);
            }
        }
    }
}