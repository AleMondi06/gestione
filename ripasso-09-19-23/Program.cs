using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso_gestione_array_09._19._23
{
    internal class Program
    {
        static int[] ArrayValoriRandom(int[] array, int a, int b)
        {
            
            //creazione generazione casuale
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(a, b);
                Console.Write($"{array[i]} ");

            }
            return array;
        }
        static int[] Troncamento(int[] array, int c)
        {

        }

        static void Main(string[] args)
        {
            //numero inserito dall'utente e variabili dei valori    
            int numero;
            int a, b, c;

            //creazione generazione casuale
            Random rand = new Random();

            //menù
            Console.WriteLine("Inserire il numero  in base a che cosa si voglia svolgere: \na) caricamento di un array di N elementi con numeri random \nb)troncamento di un array \nc)aggiunta ordinata di numeri in un array ");
            switch (Console.ReadLine())
            {
                case "a":
                    //inserire numeri
                    Console.WriteLine("inserisci il numero di elementi dell'array:");
                    numero = int.Parse(Console.ReadLine());

                    int[] array = new int[numero];

                    Console.WriteLine("inserire da che numero iniziano i valori:");
                    a = int.Parse(Console.ReadLine());

                    Console.WriteLine("inserisci da che numero finsicono i valori:");
                    b = int.Parse(Console.ReadLine());

                    //risultato
                    Console.WriteLine("l'array è:");
                    ArrayValoriRandom(array, a, b);

                    Console.ReadLine();
                    break;

                case "b":
                    //nuovo array
                    int[] ArrayNew = { 1, 2, 3, 4, 5, 6 };

                    //nuovo indice
                    Console.WriteLine("inserire la nuova lunghezza dell'array:");
                    c = int.Parse(Console.ReadLine());

                    Troncamento();
                    break;
            }



        }



    }
}

