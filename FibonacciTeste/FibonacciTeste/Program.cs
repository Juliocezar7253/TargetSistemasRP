using System;

namespace FibonacciTeste {
    internal class Fibonacci {
        static void Main(string[] args) {

            FibonacciSequence fib = new FibonacciSequence();

            var seq = fib.generateSequence();

            Console.WriteLine("Digite o número que deseja encontrar: ");
            var number = int.Parse(Console.ReadLine());

            var verifyNumber = Array.Exists(seq, num => num == number);

            if (verifyNumber) {
                Console.WriteLine("O número {0} está contido na sequência de fibonacci", number);
            } else {
                Console.WriteLine("O número {0} não está contido na sequência de fibonacci", number);
            }

        }
    }
}
