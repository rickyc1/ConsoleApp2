using Autofac;
using DemoLibrary;
using System;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            //int amoutOfNumber = 5;

            //int[] numbers = new int[amoutOfNumber];
            //numbers[0] = 12;
            //numbers[2] = 3;
            //numbers[3] = 5;


            //string[] names = new string[3];
            //names[0] = "rick";
            //names[1] = "Tom";
            //names[2] = "mary";
            ////    {
            ////        "Tom","Rick","mary"
            ////    };
            //foreach (string nam in names)
            //{
            //    Console.WriteLine("My names is {0}", nam);
            //}

            List<int> numberList = new List<int>();
            numberList.Add(4);
            numberList.Add(1);
            numberList.Add(3);
            numberList.Add(2);
            myListFunction.MySortFunction(numberList);

            Console.Read();
        }


        //static void Main(string[] args)
        //{
        //    int num = 1;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(num);
        //        Thread.Sleep(1000);
        //        num++;
        //    }

        //    Console.WriteLine("The thread ends.");
        //    Console.Read();
        //}

        private static void Print1(object obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1.ToString());
            }
        }
    }

    public static class myListFunction
    {
        public static void MySortFunction(this List<int> li)
        {
            int temp;
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if (li[i] < li[j])
                    {
                        temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }

            }

        }
        
        public static bool IsAnnagram(string s1, string s2)
        {

            return bool;
        }

    }
}
//foreach (int i in numberList)
//{
//    Console.WriteLine(i);
//}
//numberList.Sort();


//numbers[0] = 12;
//for (int i=0; i<numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i].ToString());
//}

//foreach (int number in numbers)
//{
//    Console.WriteLine(number.ToString());
//}

//int length = 5;
//int width = 5;

//int[,] grid = new int[length, width];

//for (int w = 0; w < width; w++)
//{

//    for (int y = 0; y < length; y++)
//    {

//        Console.WriteLine(grid[w, y] + " The value at X and Y."); ;
//    }
//    Console.WriteLine();
//}


//Thread t = new Thread(Print1);

//t.Start();

//            for (int i = 0; i< 1000; i++)
//            {
//                Console.Write(0.ToString());
//            }
//            Console.WriteLine();


//var container = ContainerConfig.Configure();
//            using (var scope = container.BeginLifetimeScope())
//            {
//                var app = scope.Resolve<IApplication>();
//app.Run();

//            }
//User user = new User(new MySQLDAL());
//user.FirstName = "Rick";
//            user.LastName = "Castrejon";
//            user.Address = "21372 Bristol";

//            user.Add();