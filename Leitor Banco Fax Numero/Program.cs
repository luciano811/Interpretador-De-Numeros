using System;

namespace Leitor_Banco_Fax_Numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao leitor bizarro\nDê ctrl+v no código que você quer\n\n");




            string codigo = "  __   __  __   __   __         __   __       \n" +
                            " |__  |__    | |__| |__|     |  __|  __| |__| \n" +
                            "  __| |__|   | |__|  __|     | |__   __|    | \n" +
                            "  __       __   __         __   __   __  __   \n" +
                            "  __| |__|   | |__|     |  __| |__  |__ |__|  \n" +
                            "  __|    |   | |__|     | |__   __| |__| __|  \n" +
                            "  __   __   __   __  __        __   __        \n" +
                            "  __|  __| |__  |__ |__|  |__|   | |__|     | \n" +
                            " |__   __|  __| |__| __|     |   | |__|     | \n" +
                            "  __   __   __   __  __   __        __        \n" +
                            " |  |  __| |__  |__    | |__|     ||__|  |__| \n" +
                            " |__| |__   __| |__|   | |__|     | __|     | \n";

            System.IO.StringReader readercodigo = new System.IO.StringReader(codigo);
            string linha1 = readercodigo.ReadLine();
            string linha2 = readercodigo.ReadLine();
            string linha3 = readercodigo.ReadLine();
            string linha4 = readercodigo.ReadLine();
            string linha5 = readercodigo.ReadLine();
            string linha6 = readercodigo.ReadLine();
            string linha7 = readercodigo.ReadLine();
            string linha8 = readercodigo.ReadLine();
            string linha9 = readercodigo.ReadLine();
            string linha10 = readercodigo.ReadLine();
            string linha11= readercodigo.ReadLine();
            string linha12= readercodigo.ReadLine();

            Console.WriteLine(codigo);

            //Linha 1 a 3
            #region

            for (int i = 0; i < 45;) 
            {

                if (linha1.Substring(i, 5).Equals("     ") && linha2.Substring(i, 5).Equals("    |") && linha3.Substring(i, 5).Equals("    |"))
                {
                    Console.Write("1");
                }

                if (linha1.Substring(i, 5).Equals("  __ ") && linha2.Substring(i, 5).Equals("  __|") && linha3.Substring(i, 5).Equals(" |__ "))
                {
                    Console.Write("2");
                }

                if (linha1.Substring(i, 5).Equals("  __ ") && linha2.Substring(i, 5).Equals("  __|") && linha3.Substring(i, 5).Equals("  __|"))
                {
                    Console.Write("3");
                }

                if (linha1.Substring(i, 5).Equals("     ") && linha2.Substring(i, 5).Equals(" |__|") && linha3.Substring(i, 5).Equals("    |"))
                {
                    Console.Write("4");
                }
                if (linha1.Substring(i, 5).Equals("  __ ") && linha2.Substring(i, 5).Equals(" |__ ") && linha3.Substring(i, 5).Equals("  __|"))
                {
                    Console.Write("5");
                }

                if (linha1.Substring(i, 5).Equals("  __ ") && linha2.Substring(i, 5).Equals(" |__ ") && linha3.Substring(i, 5).Equals(" |__|"))
                {
                    Console.Write("6");
                }

                if (linha1.Substring(i, 5).Equals(" __  ") && linha2.Substring(i, 5).Equals("   | ") && linha3.Substring(i, 5).Equals("   | "))
                {
                    Console.Write("7");
                }

                if (linha1.Substring(i, 5).Equals(" __  ") && linha2.Substring(i, 5).Equals("|__| ") && linha3.Substring(i, 5).Equals("|__| "))
                {
                    Console.Write("8");
                }

                if (linha1.Substring(i, 5).Equals(" __  ") && linha2.Substring(i, 5).Equals("|__| ") && linha3.Substring(i, 5).Equals(" __| "))
                {
                    Console.Write("9");
                }

                if (linha1.Substring(i, 4).Equals("  __ ") && linha2.Substring(i, 4).Equals(" |  |") && linha3.Substring(i, 4).Equals(" |__|"))
                {
                    Console.Write("0");
                }                             
                i += 5;
            }
            #endregion

            // Linhas 4 a 6:
            Console.WriteLine();
            #region
            for (int i = 0; i < 45;)
            {
                if (linha4.Substring(i, 5).Equals("     ") && linha5.Substring(i, 5).Equals("    |") && linha6.Substring(i, 5).Equals("    |"))
                {
                    Console.Write("1");
                }

                if (linha4.Substring(i, 5).Equals("  __ ") && linha5.Substring(i, 5).Equals("  __|") && linha6.Substring(i, 5).Equals(" |__ "))
                {
                    Console.Write("2");
                }

                if (linha4.Substring(i, 5).Equals("  __ ") && linha5.Substring(i, 5).Equals("  __|") && linha6.Substring(i, 5).Equals("  __|"))
                {
                    Console.Write("3");
                }

                if (linha4.Substring(i, 5).Equals("     ") && linha5.Substring(i, 5).Equals(" |__|") && linha6.Substring(i, 5).Equals("    |"))
                {
                    Console.Write("4");
                }
                if (linha4.Substring(i, 5).Equals("  __ ") && linha5.Substring(i, 5).Equals(" |__ ") && linha6.Substring(i, 5).Equals("  __|"))
                {
                    Console.Write("5");
                }

                if (linha4.Substring(i, 5).Equals("  __ ") && linha5.Substring(i, 5).Equals(" |__ ") && linha6.Substring(i, 5).Equals(" |__|"))
                {
                    Console.Write("6");
                }

                if (linha4.Substring(i, 5).Equals(" __  ") && linha5.Substring(i, 5).Equals("   | ") && linha6.Substring(i, 5).Equals("   | "))
                {
                    Console.Write("7");
                }

                if (linha4.Substring(i, 5).Equals(" __  ") && linha5.Substring(i, 5).Equals("|__| ") && linha6.Substring(i, 5).Equals("|__| "))
                {
                    Console.Write("8");
                }

                if (linha4.Substring(i, 5).Equals(" __  ") && linha5.Substring(i, 5).Equals("|__| ") && linha6.Substring(i, 5).Equals(" __| "))
                {
                    Console.Write("9");
                }

                if (linha4.Substring(i, 4).Equals(" __ ") && linha5.Substring(i, 4).Equals("|  |") && linha6.Substring(i, 4).Equals("|__|"))
                {
                    Console.Write("0");
                }
                i += 5;
            }
            #endregion

            // Linhas 7 a 9:
            Console.WriteLine();
            #region
            for (int i = 0; i < 45;)
            {

                if (linha7.Substring(i, 5).Equals("     ") && linha8.Substring(i, 5).Equals("    |") && linha9.Substring(i, 5).Equals("    |"))
                {
                    Console.Write("1");
                }

                if (linha7.Substring(i, 5).Equals("  __ ") && linha8.Substring(i, 5).Equals("  __|") && linha9.Substring(i, 5).Equals(" |__ "))
                {
                    Console.Write("2");
                }

                if (linha7.Substring(i, 5).Equals("  __ ") && linha8.Substring(i, 5).Equals("  __|") && linha9.Substring(i, 5).Equals("  __|"))
                {
                    Console.Write("3");
                }

                if (linha7.Substring(i, 5).Equals("     ") && linha8.Substring(i, 5).Equals(" |__|") && linha9.Substring(i, 5).Equals("    |"))
                {
                    Console.Write("4");
                }
                if (linha7.Substring(i, 5).Equals("  __ ") && linha8.Substring(i, 5).Equals(" |__ ") && linha9.Substring(i, 5).Equals("  __|"))
                {
                    Console.Write("5");
                }

                if (linha7.Substring(i, 5).Equals("  __ ") && linha8.Substring(i, 5).Equals(" |__ ") && linha9.Substring(i, 5).Equals(" |__|"))
                {
                    Console.Write("6");
                }

                if (linha7.Substring(i, 5).Equals(" __  ") && linha8.Substring(i, 5).Equals("   | ") && linha9.Substring(i, 5).Equals("   | "))
                {
                    Console.Write("7");
                }

                if (linha7.Substring(i, 5).Equals(" __  ") && linha8.Substring(i, 5).Equals("|__| ") && linha9.Substring(i, 5).Equals("|__| "))
                {
                    Console.Write("8");
                }

                if (linha7.Substring(i, 5).Equals(" __  ") && linha8.Substring(i, 5).Equals("|__| ") && linha9.Substring(i, 5).Equals(" __| "))
                {
                    Console.Write("9");
                }

                if (linha7.Substring(i, 4).Equals(" __ ") && linha8.Substring(i, 4).Equals("|  |") && linha9.Substring(i, 4).Equals("|__|"))
                {
                    Console.Write("0");
                }
                i += 5;
            }



            #endregion

            // Linhas 10 a 12:
            Console.WriteLine();
            #region
            for (int i = 0; i < 45;)
            {
                if (linha10.Substring(i, 5).Equals("     ") && linha11.Substring(i, 5).Equals("    |") && linha12.Substring(i, 5).Equals("    |"))
                {
                    Console.Write("1");
                }

                if (linha10.Substring(i, 5).Equals("  __ ") && linha11.Substring(i, 5).Equals("  __|") && linha12.Substring(i, 5).Equals(" |__ "))
                {
                    Console.Write("2");
                }

                if (linha10.Substring(i, 5).Equals("  __ ") && linha11.Substring(i, 5).Equals("  __|") && linha12.Substring(i, 5).Equals("  __|"))
                {
                    Console.Write("3");
                }

                if (linha10.Substring(i, 5).Equals("     ") && linha11.Substring(i, 5).Equals(" |__|") && linha12.Substring(i, 5).Equals("    |"))
                {
                    Console.Write("4");
                }
                if (linha10.Substring(i, 5).Equals("  __ ") && linha11.Substring(i, 5).Equals(" |__ ") && linha12.Substring(i, 5).Equals("  __|"))
                {
                    Console.Write("5");
                }

                if (linha10.Substring(i, 5).Equals("  __ ") && linha11.Substring(i, 5).Equals(" |__ ") && linha12.Substring(i, 5).Equals(" |__|"))
                {
                    Console.Write("6");
                }

                if (linha10.Substring(i, 5).Equals(" __  ") && linha11.Substring(i, 5).Equals("   | ") && linha12.Substring(i, 5).Equals("   | "))
                {
                    Console.Write("7");
                }

                if (linha10.Substring(i, 5).Equals(" __  ") && linha11.Substring(i, 5).Equals("|__| ") && linha12.Substring(i, 5).Equals("|__| "))
                {
                    Console.Write("8");
                }

                if (linha10.Substring(i, 5).Equals(" __  ") && linha11.Substring(i, 5).Equals("|__| ") && linha12.Substring(i, 5).Equals(" __| "))
                {
                    Console.Write("9");
                }

                if (linha10.Substring(i, 5).Equals("  __ ") && linha11.Substring(i, 5).Equals(" |  |") && linha12.Substring(i, 5).Equals(" |__|"))
                {
                    Console.Write("0");
                }
                i += 5;
            }
            #endregion

            //ALELUIA

            Console.WriteLine("\n\n\n\n");
            Console.ReadKey();


        }
    }
}
