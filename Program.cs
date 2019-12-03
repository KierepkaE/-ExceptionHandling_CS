using System;

namespace ExceptionHandling {
    class Program {
        static void Main (string[] args) {
            try {
                var calculator = new Calculator ();
                var result = calculator.Divide (5, 0);
            } catch (System.Exception) {

                System.Console.WriteLine ("Sorry, an unexpected error accured.");
            }

        }
    }
}