using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class AtvArrays {

        public static void Executar() {

            string[] frutas = new string[10];

            frutas[0] = "Abacate";
            frutas[1] = "Banana";
            frutas[2] = "Laranja";
            frutas[3] = "Uva";
            frutas[4] = "Manga";
            frutas[5] = "Maçã";
            frutas[6] = "Pera";
            frutas[7] = "Abacaxi";
            frutas[8] = "Cereja";
            frutas[9] = "Kiwi";

            string[] frutasAlteradas = (string[])frutas.Clone();
            frutasAlteradas[9] = "Caqui";

            Console.WriteLine($"Segunda fruta: {frutas[1]}");
            Console.WriteLine($"Penúltima fruta: {frutas[8]}");

            Console.WriteLine("Todas as frutas (com alteração):");
            foreach (string fruta in frutasAlteradas) {
                Console.WriteLine(fruta);
            }

            Console.WriteLine("Frutas na ordem inversa:");
            for (int i = frutasAlteradas.Length - 1; i >= 0; i--) {
                Console.WriteLine(frutasAlteradas[i]);
            }

            Console.WriteLine($"Quantidade de elementos no array: {frutasAlteradas.Length}");
        }
    }
}