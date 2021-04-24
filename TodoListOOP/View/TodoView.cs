using System;
using TodoListOOP.Service;
using TodoListOOP.Util;

namespace TodoListOOP.View {
    public class TodoView {
        private readonly ITodoService _todoService;

        public TodoView(ITodoService todoService) {
            _todoService = todoService;
        }
        
        public void ViewShowTodoList() {
            while (true) {
                Console.Clear();
                _todoService.ShowTodoList();

                Console.WriteLine("MENU : ");
                Console.WriteLine("1. Tambah");
                Console.WriteLine("2. Hapus");
                Console.WriteLine("x. Keluar");

                var input = InputUtil.Input("Pilih");

                if (input.Equals("1")) {
                    ViewAddTodoList();
                    Console.ReadKey();
                }
                else if (input.Equals("2")) {
                    ViewRemoveTodoList();
                    Console.ReadKey();
                }
                else if (input.Equals("x")) {
                    break;
                }
                else {
                    Console.WriteLine("Pilihan tidak dimengerti");
                    Console.ReadKey();
                }
            }
        }
        public void ViewRemoveTodoList() {
            Console.WriteLine("MENGHAPUS TODOLIST");

            var no = InputUtil.Input("Nomor yang Dihapus (x Jika Batal)");
            if (no.Equals("x")) { }
            else {
                _todoService.RemoveTodoList(int.Parse(no));
            }
        }
        

        public void ViewAddTodoList() {
            Console.WriteLine("MENAMBAH TODOLIST");

            var todo = InputUtil.Input("Todo (x Jika Batal)");

            if (todo.Equals("x")) { }
            else {
                _todoService.AddTodoList(todo);
            }
        }
    }
}