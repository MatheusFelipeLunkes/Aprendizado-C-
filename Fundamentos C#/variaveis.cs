// Ao falarmos de variaveis precisamos primeiro nos perguntar oque é uma variavel? 
// R: Uma variavel nada mais é que um endereço em um local da memoria. 
using System;

namespace variaveis {
    class tiposVariaveis {
        static void Main (string[] args) {
            //Toda variavel pode receber valores, dependendo do seu tipo que foi declarado ao ser inicializada.
            int dia = 20; // Variaveis do tipo int so podem receber numeros inteiros, como no exemplo.
            float peso = 89.3f; // Variaveis do tipo float podem receber numeros com ponto flutuante.
            string fruta = "Maça"; // Variaveis do tipo string ou char podem receber textos ou um caractere em especifico.
            bool state = true; // Variaveis do tipo Booleano só recebem valores como (True e false)

            Console.WriteLine($"Dia: {dia}, Peso: {peso}, Fruta: {fruta}, Status: {state}");
        }
    }

}
/*      CURIOSIDADE: 
    Em C#  por padrão ele considera todo numero decimal como um duble pois oferece mais precisão (64bits) em comparação ao float (32bits),
    mas no caso de precisarmos que isso seja um float de fato, adicionamos o sufixo 'f' ao final da atribuição.
    
    Variaveis do tipo string devem ser atribuidas com "aspas duplas", e do tipo char 'aspas simples'.

*/