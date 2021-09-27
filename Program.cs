using System;

namespace ATV2709
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunosArray = new string[3];

            alunosArray[0] = "Maju";
            alunosArray[1] = "Lucas";
            alunosArray[2] = "Dani";

            Console.WriteLine("Foreach");
        foreach (string aluno in alunosArray)
        {
            
            Console.WriteLine(aluno);

        }
            Console.WriteLine(" ");
            Console.WriteLine("For");

        for (int i = 0; i< alunosArray.Length; i++)
        {
            
            Console.WriteLine(alunosArray[i]);
        }

        }
    }
}
