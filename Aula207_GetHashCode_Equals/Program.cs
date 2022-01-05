/* GetHashCode e Equals - Operacoes da classe Object, utilizadas para ver se objetos sao iguais
 * 
 * - Equals - mais lento, porem, com resposta 100% correta:
 *  >>> Compara e retorna True ou False.
 * 
 * - GetHashCode - mais rapido, porem, ha uma pequena margem de erro:
 *  >>> Retorna um numero inteiro representando um codigo gerado a partir das informacoes do objeto;
 *  >>> Se os codigos de dois objetos forem diferentes, os objetos sao diferentes;
 *  >>> Se os codigos de dois objetos diferentes forem iguais, e muito provavel que os dois objetos sejam iguais,
 *      porem, ainda ha uma pequena possibilidade de ter havido coincidencia e que os objetos sejam diferentes, 
 *      mesmo com codigos iguais (Colisao).
 *   
 * - Os tipos pre-definidos ja possuem implementacao para essas operacoes. Classes e Structs personalizdos
 * precisam sobrepo-las.
 * 
 * Obs.: Para listas extensas, costuma-se utilizar o GetHashCode primeiramente e, depois de filtrar os elementos 
 *       indicados como iguais nessa operacao, comparam-se esses elementos filtrados com o Equals, para garantir
 *       um resultado 100% consistente.
 */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using Aula207_GetHashCode_Equals.Entities;

namespace Aula207_GetHashCode_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Juliane", Email = "jhyyouleyyy@hotmail.com" };
            Client b = new Client { Name = "Vinicius", Email = "coelhovinicius@yahoo.com.br" };
            Client c = new Client { Name = "Midori", Email = "jhyyouleyyy@hotmail.com" };

            Console.WriteLine("Equals:");
            Console.WriteLine(a.Equals(b)); // Retorna False
            Console.WriteLine(a == b); // Compara a Referencia do Ponteiro de Memoria do objeto - Retorna False
            Console.WriteLine(b.Equals(c)); // Retorna False
            Console.WriteLine(a.Equals(c)); // Retorna True
            Console.WriteLine(a == c); // Retorna False, pois tem referencias de memoria diferentes

            Console.WriteLine("\nGetHashCode:");
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(c.GetHashCode());

            /*string a = "Juliane";
            string b = "Vinicius";
            string c = "Juliane";

            // Equals
            Console.WriteLine("Equals:");
            Console.WriteLine(a.Equals(b)); // Compara "a" com "b" e retorna False
            Console.WriteLine(a.Equals(c)); // Compara "a" com "c" e retorna True
            Console.WriteLine(b.Equals(c)); // Compara "b" com "c" e retorna False

            Console.WriteLine();

            // GetHashCode - Retorna codigos diferentes a cada execucao
            Console.WriteLine("GetHashCode:");
            Console.WriteLine(a.GetHashCode()); // Retorna o codigo de "a" (igual ao do "c")
            Console.WriteLine(b.GetHashCode()); // Retorna o codigo de "b"
            Console.WriteLine(c.GetHashCode()); // Retorna o codigo de "c" (igual ao do "a")*/
        }
    }
}
