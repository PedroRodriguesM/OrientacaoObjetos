using System;
using System.Collections.Generic;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var professor = new Professor(5000m, "João", "12345", new DateTime(1980, 1, 1));
            var estudante = new Estudante("A", "Maria", "58759", new DateTime(1999, 1, 1));

            var pessoas = new List<Pessoa> { estudante, professor };

            foreach (var pessoa in pessoas)
            {
                pessoa.SeApresentar();
                Console.WriteLine("-----------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
