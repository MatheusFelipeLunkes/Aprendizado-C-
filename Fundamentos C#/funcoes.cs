//Assim como qualquer outra linguagem podemos criar funçoes distintas umas das outras, para manter o escopo e desacoplamento nescessario para evitar possiveis bugs, erros ou até problemas de segurança.

using System;

namespace Functions {
    class FuncoesDoSistema {
        //Funções também podem serem chamadas por outras funções.
        static void ExibeResultado(int[] array) {
            for(int j = 0; j < array.Length; j++) {
                Console.WriteLine(array[j]);
            }
        }
        static void PreencheArray (int[] array, int x, int y) {
    
            for(int i = 0; i < 10; i++) {
                array[i] += x * y + i;
            }
        
        }
        static int Multiplica(int x, int y) {
            return x * y;
        }
        static void Main(string[] args) {
            int x = 3, y = 5;

            int resultado = Multiplica(x, y);
            
            int[] arrayNumeros = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

            Console.WriteLine(resultado);
            PreencheArray(arrayNumeros, x, y);
            ExibeResultado(arrayNumeros);
        }   
    }
}