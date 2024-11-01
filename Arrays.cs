using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Arrays 
    {
        public static void Executar() 
        {
            string[] alunos = new string[5];
            /* Um array de 5 posições terá 4 valores pois contamos o 0 para acessar a posição especifica*/

            alunos[0] = "Matheus Cantarino Tintim";
            alunos[1] = "Enzo Malboro";
            alunos[2] = "Santa Trindade";
            alunos[3] = "Irmão Matheus";
            alunos[4] = "Marcos Vinicius";

            /*para percorremos e exibirmos o array, usamos foreach */
            /*foreach(var aluno in alunos) 
            {
                Console.WriteLine(aluno);
            }*/
            Console.WriteLine(alunos[1]);

        }
    }
}
