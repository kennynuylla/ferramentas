using System;

namespace SenhaConsole
{
    public class MascararSenhaConsole
    {
        public static string LerSenha()
        {
            string senha = "";
            ConsoleKeyInfo console;

            do
            {
                console = Console.ReadKey(true);
                if (console.Key == ConsoleKey.Backspace)
                {
                    if (senha.Length > 0)
                    {
                        //Pegar a localização do cursor a partir da esquerda
                        var posiçãoX = Console.CursorLeft;
                        //Pegar a localização do cursor a partir de cima
                        var posiçãoY = Console.CursorTop;
                        //Setar a posição do cursor voltando uma casa para a esquerda
                        Console.SetCursorPosition(posiçãoX - 1, posiçãoY);
                        //Limpar a casa com espaço
                        Console.Write(" ");
                        //Como colocamos um espaço, precisamos voltar de novo
                        Console.SetCursorPosition(posiçãoX - 1, posiçãoY);
                        //Pegar a senha sem o último caracter
                        senha = senha.Substring(0, senha.Length - 1); 
                    }
                }
                else if (console.Key != ConsoleKey.Enter)
                {
                    senha += console.KeyChar;
                }

            } while (console.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return senha;
        }
    }
}
