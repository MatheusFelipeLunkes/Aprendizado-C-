// Operadores em C#:
using System;

namespace Operadores {
    class todosOperadores {
        static void operadores(string[] args) {

            //Assim como na matematica podemos usar operadores aritmeticos como o da adição, subtração, multiplacação, divisão e muitos outros.

            float x = 1f, y = 2f; 
            float sum = x + y; // Operador + faz a adição de uma variavel por outra (NÃO faz a troca de seus valores apenas o calculo)

            float sub = x - y; // Operador - faz a subtração de uma variavel por outra (NÃO faz a troca de seus valores apenas o calculo)

            float mult = x * y; // Operador de * faz a multiplicação de uma variavel por outra 

            float div = x / y; // Operador / faz a divisão inteira de uma variavel por outra

            float restDiv = x % y; // Operador % captura o resto da divisão inteira das duas variaveis;

            x++; // Operador ++ faz pos incremento, podendo ser adicionado antes para fazer um pre incremento

            --y; // Operador -- faz pre decremento, podendo ser adicionado depois para fazer um pos decremento

            Console.WriteLine($"X :{x} Y:{y} \nSum: {sum} \nSub: {sub} \nMult: {mult} \nDiv: {div} ResDiv: {restDiv} \n");
            //ATENÇÃO: Ao usar o operador de atribuição em strings, causam uma concatenação como mostrado no exemplo abaixo:
            string num1 = "1";
            string num2 = "2";
            string cont = num1 + num2;
            Console.WriteLine(cont);

            // Operadores de comparação:
            if(x >= y) {
                Console.WriteLine("X é maior que Y");
            }else {
                Console.WriteLine("Y é maior que X");
            }
            // Podemos fazer qualquer tipo de comparação usando operadores de comparação com estruturas if e else ou ternarias
            // Operadores:
            /*
                == -> comparação de igual, SE X == Y, OU SEJA se X é IGUAL a Y
                != -> comparação diferente igual, SE X != Y, OU SEJA se X é diferente ou igual a Y
                > -> comparação Maior que
                < -> comparação Menor que
                >= -> comparação Maior ou igual que
                <= -> comparação Menor ou igual que
            */
            // Operadores Logicos: 
            if(y >= x || y % x == 0) {
                Console.WriteLine(y);
            }else {
                Console.WriteLine(x);
            }
            //Podemos criar sequencias de comparações no mesmo 'teste', como no exemplo acima.
            //Operadores: 
            /*
                && -> Operador && (E), estabelece que ambas as condiçoes devem ser verdadeiras,
                || -> Operador ZZ (OU), estabelece que apenas um das condições devem ser verdadeiras,
                ! -> Operador (NÃO), estabelece uma negação para a comparação como por exemplo: 
                        se algo != algo faça isso. 
            */
        }
    }
}