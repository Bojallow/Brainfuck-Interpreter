namespace Interpreter {

    class Brainfuck {

        public static void Main(string[] args) {
            string filename = "";
            System.Console.WriteLine("Where is the location and name of your file? ");
            filename = System.Console.ReadLine();

            if(filename.Substring(filename.Length - 3) != ".bf") {
                System.Console.WriteLine("Error:");
                System.Console.WriteLine("code exited with error code 6: File must be a Brainfuck (.bf) file.");
            }
        }
    }

       

}