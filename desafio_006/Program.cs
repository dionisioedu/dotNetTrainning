using System;
using System.IO;
using System.Collections.Generic;

namespace desafio_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio 006\n");

            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno { Nome = "Adriana", Idade = 10, Nota = 8 });
            alunos.Add(new Aluno { Nome = "Beatriz", Idade = 10, Nota = 7 });
            alunos.Add(new Aluno { Nome = "Carlos", Idade = 10, Nota = 9 });

            var export = new Jitbit.Utils.CsvExport();

            foreach (var aluno in alunos)
            {
                export.AddRow();
                export["Nome"] = aluno.Nome;
                export["Idade"] = aluno.Idade;
                export["Nota"] = aluno.Nota;
            }

            export.ExportToFile("alunos.csv");
        }
    }
}
