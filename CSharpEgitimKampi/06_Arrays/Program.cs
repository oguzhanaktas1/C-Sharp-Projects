﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //DeğişkenTürü[] diziadı =new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[2]);


            //int[] numbers =new int[10];
            //numbers[0] = 50;
            //numbers[1] = 54;
            //numbers[2] = 33;
            //numbers[3] = 354;
            //numbers[4] = 24;
            //numbers[5] = 54;
            //numbers[6] = 24;
            //numbers[7] = 234;

            //Console.WriteLine(numbers[7]);


            //string[] cities = { "Prag", "Roma", "Atina", "Ankara" };
            //Console.WriteLine(cities[2]);



            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 12, 322, 433, 784, 4335, 866, 24557, 7548 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95,41,25,635,789,86,100 };
            //int maxNumber=myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = {"Ali","Ahmet","Ayşe","Buse","Cem","Deniz" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali","buse","ayşegül","merve","çınar","kaya"};
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);


            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Dizinin en büyük elemanı: "+numbers.Max()+" Dizinin en küçük elemanı: "+numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("----------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }

            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion


            Console.Read();
        }
    }
}
