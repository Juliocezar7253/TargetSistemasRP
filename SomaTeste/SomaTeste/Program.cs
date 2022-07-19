using System;

namespace SomaTeste {
    internal class Soma {
        static void Main(string[] args) {

            int indice = 13;
            var soma = 0;
            var k = 0;

            while (k < indice) {
                k += 1;
                soma += k;
            }

            Console.WriteLine(soma);
        }
    }
}
