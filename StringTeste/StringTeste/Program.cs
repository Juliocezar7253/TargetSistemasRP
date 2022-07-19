using System;

namespace StringTeste {
    internal class ReverseString {
        static void Main(string[] args) {

            var strOriginial = "Julio";
            var strInvertido = stringReverse(strOriginial);

            Console.WriteLine("String Original: " + strOriginial + "\n"
                              + "String Invertido: " + strInvertido);
        }

        static string stringReverse(string s) {
            char[] reverseStr = s.ToCharArray();
            var newS = "";
            
            for (int str = reverseStr.Length - 1; str >= 0; str--) {
                newS += reverseStr[str];
            }
            return newS;
        }

    }
}
