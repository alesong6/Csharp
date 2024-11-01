using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class AtivArrays {
        public static void Executar() {

            string[] frutas = new string[5];
            frutas[0] = "Abacate";
            frutas[1] = "Banana";
            frutas[2] = "Laranja";
            frutas[3] = "Uva";
            frutas[4] = "Manga";

            Console.WriteLine("Nomes das frutas:");
            foreach (var fruta in frutas) {
                Console.WriteLine(fruta);
            }
            Console.WriteLine($"Quantidade de elementos: {frutas.Length}\n");

            Console.WriteLine($"Segunda fruta: {frutas[1]}");
            Console.WriteLine($"Penúltima fruta: {frutas[3]}\n");

            frutas[2] = "Kiwi";
            frutas[4] = "Caqui";

            Console.WriteLine("Nomes das frutas após alterações:");
            foreach (var fruta in frutas) {
                Console.WriteLine(fruta);
            }
            Console.WriteLine();

            Console.WriteLine("Nomes das frutas na ordem inversa:");
            for (int i = 4; i >= 0; i--) {
                Console.WriteLine(frutas[i]);
            }
        }
    }
}
