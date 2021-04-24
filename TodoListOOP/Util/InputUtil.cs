using System;

namespace TodoListOOP.Util {
    public class InputUtil {
        
        public static string Input(string info) {
            Console.Write(info + " : ");
            var data = Console.ReadLine();
            return data;
        }
    }
}