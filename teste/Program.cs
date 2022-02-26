using System;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codigo = "       __   __        __   __  __   __   __   __ \n" +
                            "    |  __|  __| |__| |__  |__    | |__| |__| |  |\n" +
                            "    | |__   __|    |  __| |__|   | |__|  __| |__|";

            System.IO.StringReader readercodigo = new System.IO.StringReader(codigo);
            string linha1 = readercodigo.ReadLine();
            string linha2 = readercodigo.ReadLine();
            string linha3 = readercodigo.ReadLine();

            Console.WriteLine(codigo);

            Console.WriteLine(linha1.Substring(10,5));
            Console.WriteLine(linha2.Substring(10,5));
            Console.WriteLine(linha3.Substring(10,5));


            //for (int i = 0; i < linha1.Length; i++)
            //{


            if (linha1.Substring(0,5).Equals("     ") && linha2.Substring(0, 5).Equals("    |") && linha3.Substring(0, 5).Equals("    |"))
            {
                Console.WriteLine("AAAAAAAAAA");
            }
            if (linha1.Substring(5, 11).Equals("  __ ") && linha2.Substring(5, 11).Equals("  __|") && linha3.Substring(5, 11).Equals(" |__ "))
            {
                Console.WriteLine("2");
            }
        }
    }
}
