// Loops ou laços de repetições são muito importantes para controlarmos estados de aplicações ou até mesmo repetirmos uma determinada instrução mais de uma vez.

using System;

namespace Loops {

    class AllLoops {
        static void AllLacos(string[] args) {
            int[] arrayNumeros = [1,2,3,4,5,6];
            int i = 0;
            // Os laços mais utilizados são while, e o for classico. Do while tem situações mais especificas para seu uso. 
            while(i < arrayNumeros.Length) {

                Console.WriteLine(arrayNumeros[i]);
                i++;
            }

            string[] pessoas = ["Matheus", "Marcia", "Marcos", "Jaqueline", "Anderson", "Maria", "Jonatan", "Mariele"];

            for(int j = 0; j < pessoas.Length; j += 2) {
                Console.WriteLine($"{pessoas[j]} é casado com: {pessoas[j + 1]}");
            }
    }   
    }
}