using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Hello1
//{
//    class Program
//    {
        
//        static void Main()
//        {
//            int i = 10;	//объявление и инициализация целочисленной переменной i
//            Console.WriteLine(i);		//просмотр значения переменной
//            i = 100;		//изменение значение переменной
//            Console.WriteLine(i);

//        }
//    }
//}

//namespace hello1
//{
//    class program
//    {

//        static void main()
//        {
//            int i;
//            console.writeline(i);
//        }
//    }
//}

namespace hello1
{

    class program
    {
        //enum gradus : int
        //{
        //    min = 0,
        //    krit = 72,
        //    max = 100,
        //}

      static void Main()
        {
            //const int i=10;	//объявление целочисленной константы i
            //Console.WriteLine(i);		//просмотр значения константы
            //i=100;		//ошибка
            //Console.WriteLine(i);
            ////Не запускается, нужно один раз проинициализировать
           
            
            //const int a  = 25;
            //Console.WriteLine(a);
            // При изменении объявлении не инициализированной константы компилятор выдает ошибку.
      


            //Console.WriteLine("минимальная температура=" + (int) gradus.min);
            //Console.WriteLine("критическая температура=" + (int)gradus.krit);
            //Console.WriteLine("максимальная температура=" + (int)gradus.max);

            //int i = 3, j = 4;
            //Console.WriteLine("{0} {1} {2}", i, j,i);

            //Console.WriteLine("Ура!\nСегодня \"понедельник\"!!!");

            //double x = Math.E;
            //Console.WriteLine("E={0,20}", x);
            //Console.WriteLine("E={0,10}", x);


            //double x = Math.E;
            //Console.WriteLine("E={0:##.######}", x);
            //Console.WriteLine("E={0:.######}", x);

            //Console.WriteLine("C Format:{0,14:C} \t{0:C2}", 12345.678);
            //Console.WriteLine("D Format:{0,14:D} \t{0:D6}", 123);
            //Console.WriteLine("E Format:{0,14:E} \t{0:E8}", 12345.6789);
            //Console.WriteLine("G Format:{0,14:G} \t{0:G10}", 12345.6789);
            //Console.WriteLine("N Format:{0,14:N} \t{0:N4}", 12345.6789);
            //Console.WriteLine("X Format:{0,14:X} ", 1234);
            //Console.WriteLine("P Format:{0,14:P} ", 0.9);    


            //int x = int.Parse(Console.ReadLine()); //преобразование введенной строки в число
            //Console.WriteLine(x);


            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c=");
            //int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            //Console.WriteLine("{0}+{1}+{2}={2}+{1}+{0}", a,b,c);
            //Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, a + b + c);


            Console.Write("a=");
            float z = float.Parse(Console.ReadLine());
            Console.Write("b=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("c=");
            float v = float.Parse(Console.ReadLine());


            Console.WriteLine("{0:#.##}*{1:#.#}={2:.####}", z, x, z * x);
            Console.WriteLine("{0:#.###}/{1:#.###}={2:#.###}", z, x, z / x);
            Console.WriteLine("{0:#.##}+{1:#.##}+{2:.##}={0:#.##}+{1:#.##}+{2:.##}", z, x, v);
        }
    }
}


