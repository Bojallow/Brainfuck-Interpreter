namespace Inter {

    class Interpreter {
        private string Code;

        Interpreter(string filename) {
            Code = System.IO.File.ReadAllText(filename);
        } 

        public void Main() {
            foreach(char ii in Code)
            {
                switch (ii) {
                    case '\n':
                        continue;
                    case '\t':
                        continue;
                    case ' ':
                        continue;
                    default:
                        return;

                }

            }
        }
    }
   
}