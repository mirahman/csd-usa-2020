using System;

namespace DesignPatterns {

    class SingleTone {

        private SingleTone(){}
        private static SingleTone _instance;

        public static SingleTone getInstance()
        {
            if(_instance == null ) {
                _instance = new SingleTone();
            }
            return _instance;
        }
    }

    class Program {
        static void Main(string[] args) {
            SingleTone obj1 = SingleTone.getInstance();
            SingleTone obj2 = SingleTone.getInstance();
        }
    }

}