using System;

namespace ExceptionHandling {
    class Program {
        static void Main (string[] args) {
            try {
                var calculator = new Calculator ();
                var result = calculator.Divide (5, 0);
            } catch (DivideByZeroException ex) {
                System.Console.WriteLine ("Sorry, can not divide by zero.");
            } catch (System.Exception ex) {

                System.Console.WriteLine ("Sorry, an unexpected error accured.");
            }
        }
    }
}