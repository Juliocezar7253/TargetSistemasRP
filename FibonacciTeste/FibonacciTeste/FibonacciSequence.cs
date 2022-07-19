using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciTeste {
    public class FibonacciSequence {

        public int[] sequence;

        public int[] generateSequence() {

            int n = 0, n1 = 1;
            var aux = 0;
            List<int> listOfNumbers = new List<int>();

            for (int i = 0; i < 60; i++) {
                aux = n;
                n = n1;
                n1 = n + aux;
                listOfNumbers.Add(n1); 
            }

            int[] sequence = listOfNumbers.ToArray();
            return sequence;
        }
    }
}
