namespace Env {
    unsafe class Environment {
        private char[] memory = new char[0x752F];
        private char memPtr;
        char* beginning;


        Environment() {
            memPtr = memory[0];
            char temp = memory[0];
            beginning = &temp;
        }

        
    }
}