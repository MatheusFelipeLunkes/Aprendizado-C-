// Estruturas de controle são essenciais para comparmos sequencias logicas. Elas sempre retornam um boolean verdadeiro ou falso para as condições;
using System;

namespace estruturasDeControle {

    class EstruturasControle{
        static void Estruturas (string [] args) {
           // Supondo que o usuario digitou seu login, e senha em um prompt, usar estruturas de controle para permissionar acessos(entre outras coisas) são essenciais nestes casos.

            string nomeBanco = "Matheus"; // No exemplo este é um nome vindo de uma base de dados
            string nomeUsuario = "Mateus"; // No exemplo este é o nome que o usuario digitou no prompt
            string senhaBanco = "12345"; // No exemplo esta é uma senha vindo de uma base de dados (geralmente criptografada);
            string senhaUsuario = "12345"; // No exemplo esta é a senha digitada no prompt
           

            if(nomeUsuario == nomeBanco && senhaUsuario == senhaBanco)  { // Repare que nesta comparação usamos o && (E) que indica que as duas condições devem ser verdadeiras, para liberar meu usuário
                Console.WriteLine("Acesso Permitido");
            }else{
                Console.WriteLine("Acesso Negado! \nUsuario ou senha Invalidos.");
            }
        }
    }
}