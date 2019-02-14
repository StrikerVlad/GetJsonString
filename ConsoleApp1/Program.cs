using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.model;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            ServiceUser serviceUser = new ServiceUser("https://randomuser.me/api?results=1");
         /* Console.WriteLine(serviceUser.GetJsonString())*/;
            string json = serviceUser.GetJsonString();
            var users = JsonConvert.DeserializeObject<Users>(json);

        }

        //static void task1()
        //{
        //    Console.WriteLine("Write your name");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Hello, {0}", name);
        //}

        //static void task2()
        //{
        //    //int a = Int32.Parse(Console.ReadLine());
        //    //int b = Int32.Parse(Console.ReadLine());
        //    //Console.WriteLine(a + b);
        //    int y = 0;
        //    int temp = 0;
        //    while(Int32.TryParse(Console.ReadLine(), out y))
        //    {
        //        temp += y;
        //    }

        //    Console.WriteLine(temp);
        //}

        //static void task3()
        //{
        //    Console.WriteLine("{0} {1} {2}", 1,2,3);
        //}


        //static void task4()

        //{
        //    int cm = Int32.Parse(Console.ReadLine());
        //    double m = cm / 100;
        //    Console.WriteLine("m = {}", m);
        //}

        //static void task5()

        //{
        //    bool a = true, b = false, c = false;
        //    if(a||)
        //    {

        //    }
        //}

        //static void task6()
        //{
        //    int[] a = new int[5];
        //    double[,] b  = new double[3, 4];
        //    Random rnd = new Random();
        //    int maxA = 0;
        //    double maxB = 0;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        a[i] = rnd.Next(0, 10);
        //        Console.Write("{0} ", a[i]);
        //        if (a[i] > maxA)
        //            maxA = a[i];
        //    }
        //    Console.WriteLine();

        //    for (int i = 0; i<3; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            b[i,j] = rnd.NextDouble();
        //            Console.Write("{0} ", b[i, j]);
        //            if (b[i, j] > maxB)
        //                maxB = b[i, j];
        //        }
        //        Console.WriteLine();
        //    }

        //  maxA>maxB?Console.Write("{0}", MaxA)): MaxB;
        //}
       

        
    }
}
