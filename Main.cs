using System.IO;

namespace BrainfuckMain {
    class Brainfuck {
        static void Main(string[] args) {
            string filePath;

            System.Console.WriteLine("What is the location and name of your file? ");
            filePath = System.Console.ReadLine();

            if(filePath.Substring(filePath.Length - 3) != ".bf") {
                throw new System.Exception("Error: \ncode exited with error code 6: File must be a Brainfuck(.bf) file.");
            }
        }
    }
}