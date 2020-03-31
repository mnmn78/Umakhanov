using System;

namespace Лаб2
{
    class Program
    {
        public static int kub(int a)
        {
            return a * a * a;
        }

        static void Main()
        {
            /*Zad 6*/
            /*Ver 1
             for (int i=7; i>2; i--, Console.WriteLine())
            {
                for(int j=8; j > i; j--)
                Console.Write("{0}   ", i);
            }*/

            /*Ver 2
            for(int i=10; i>=1; i--, Console.WriteLine())
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= i / 2; j++)
                        Console.Write("{0}   ", 2);
                }
                else
                {
                    for (int j = -1; j < i / 2; j++)
                        Console.Write("{0}   ", i/2+j);
                }
            }*/

            /*Zad 5
            Console.Write("Введите курс = ");
            double n = double.Parse(Console.ReadLine());
            double kurs = 0;
            Console.Write("while: ");
            int i = 5;
            while (i <= 120)
            {
                kurs = n * i; 
                Console.Write("{0}USD = {1}RUB \n", i,kurs);
                i += 5;
            }

            Console.Write("do while: ");
            i = 5;
            do
            {
                kurs = n * i;
                Console.Write("{0}USD = {1}RUB \n", i, kurs);
                i += 5;
            }
            while (i <= 120);
            Console.Write("For: ");
            for (i = 5; i <= 120; i += 5)
            {
                kurs = n * i;
                Console.Write("{0}USD = {1}RUB \n", i, kurs);
            }*/

            /*Zad 4
            int g = 0, d = 20, m = 2, y = 2020;
            Console.Write("Введите месяцы ");
            int n = int.Parse(Console.ReadLine());
            g = (n + m) / 12;
            m = (n + m) % 12;
            switch (m)
            {
                case 0: Console.WriteLine("{0}.12.{1}", d, y - g); break;
                case 1: Console.WriteLine("{0}.01.{1}", d, y - g); break;
                case 2: Console.WriteLine("{0}.02.{1}", d, y - g); break;
                case 3: Console.WriteLine("{0}.03.{1}", d, y - g); break;
                case 4: Console.WriteLine("{0}.04.{1}", d, y - g); break;
                case 5: Console.WriteLine("{0}.05.{1}", d, y - g); break;
                case 6: Console.WriteLine("{0}.06.{1}", d, y - g); break;
                case 7: Console.WriteLine("{0}.07.{1}", d, y - g); break;
                case 8: Console.WriteLine("{0}.08.{1}", d, y - g); break;
                case 9: Console.WriteLine("{0}.09.{1}", d, y - g); break;
                case 10: Console.WriteLine("{0}.10.{1}", d, y - g); break;
                case 11: Console.WriteLine("{0}.11.{1}", d, y - g); break;
                default: Console.WriteLine("error"); break;
            }*/

            /*Zad 3.3
            Console.Write("x =");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y =");
            double y = double.Parse(Console.ReadLine());
            if(x <= 5 && y <= 10 && x > 0 && y > 0) Console.WriteLine("Внутри");
            else Console.WriteLine("Не внутри");*/
            /*Zad 3.2
            int i = 33;
            if (((i % 10) + ((i / 10) % 10)) % 2 == 1) Console.WriteLine("nechet");
            else Console.WriteLine("chet");*/

            /*Zad 3.1
            int v = 12;
            double a;
            a = Math.Pow(v, 1.0/3);
            Console.WriteLine("Ребро куба равно = {0:#.###}", a);*/

            /*Zad 2
            int x = 10; int y = 20;
            int min = (x > y) ? y : x;
            Console.WriteLine(min);
            if(min/10>=1) Console.WriteLine("Da");
            else Console.WriteLine("Net");*/

            /*Zad2.1
            int i, j, d = 0;
            Console.Write("Введите n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите k = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите k1 = ");
            int k1 = int.Parse(Console.ReadLine());
            Console.Write("Введите m1 = ");
            int m1 = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
                for(j = 1; j <= n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        d++;
                        if ((k == i) && (m == j)) Console.WriteLine("Ячейка ({0} {1}) это черный цвет", k,m);
                    }

                    else 
                    {
                        if ((k == i) && (m == j)) Console.WriteLine("Ячейка ({0} {1}) это белый цвет", k, m); 
                    }
                }
            if ((k + m) % 2 == (k1 + m1) % 2)
            {
                if ((k + m) % 2 == 0) Console.WriteLine("Ячейка ({0} {1}) и ячейка ({2} {3}) одного цвета - черного", k, m, k1, m1);
                else Console.WriteLine("Ячейка ({0} {1}) и ячейка ({2} {3}) одного цвета - белого", k, m, k1, m1);
            }
            else Console.WriteLine("Ячейка ({0} {1}) и ячейка ({2} {3}) разных цветов", k, m, k1, m1);
            if (k + 1 == k1 && (m + 1 == m1 || m - 1 == m1)) Console.WriteLine("Фигура в ячейке ({0} {1}) находится под ударом Пешки в ячейке ({2} {3})", k, m, k1, m1);
            if ((k + m) % 2 == (k1 + m1) % 2 && Math.Abs(k + m) == Math.Abs(k1 + m1)) Console.WriteLine("Фигура в ячейке ({0} {1}) находится под ударом Слона в ячейке ({2} {3})", k, m, k1, m1);
            if (k == k1 || m == m1)  Console.WriteLine("Фигура в ячейке ({0} {1}) находится под ударом Ладьи в ячейке ({2} {3})", k, m, k1, m1);
            if ((k == k1 || m == m1) || ((k + m) % 2 == (k1 + m1) % 2 && Math.Abs(k + m) == Math.Abs(k1 + m1))) Console.WriteLine("Фигура в ячейке ({0} {1}) находится под ударом Ферзя в ячейке ({2} {3})", k, m, k1, m1);
            if(((k1 + 1 == k || k1 - 1 == k) && (m1 + 2 == m || m1 - 2 == m)) ||((k1 + 2 == k || k1 - 2 == k) && (m1 + 1 == m || m1 - 1 == m))) Console.WriteLine("Фигура в ячейке ({0} {1}) находится под ударом Коня в ячейке ({2} {3})", k, m, k1, m1);
            Console.WriteLine("Всего черных ячеек = {0}", d);*/

            /*Zad 2.2
            int day, month, year , pros = 0, osta = 0, predd = 0, predm = 0, predy = 0, nexeld = 0, nexelm = 0, nexely = 0;
            int[] d = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            Console.WriteLine("Введите день ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год ");
            year = int.Parse(Console.ReadLine());
            int m = month;
            while (m > 0)
            {
                pros += d[m];
                m--;
            }
            m = month;
            while (m < 13)
            {
                osta += d[m];
                m++;
            }
            if(day == 1)
            {
                if (month == 1)
                {
                    predm = 12;
                    predy = year - 1;
                    predd = d[predm];
                }
                else
                {
                    predd = d[month - 1];
                    predm = month - 1;
                    predy = year;
                }
            }
            else
            {
                predd = day -1;
                predm = month;
                predy = year;
            }
            if (day == d[month])
            {
                if (month == 12)
                {
                    nexelm = 1;
                    nexely = year + 1;
                    nexeld = 1;
                }
                else
                {
                    nexeld = 1;
                    nexelm = month + 1;
                    nexely = year;
                }
            }
            else
            {
                nexeld = day + 1;
                nexelm = month;
                nexely = year;
            }
            pros -= d[month] - day;
            osta -= day; 
            Console.WriteLine("С начала года прошло {0} дней", pros);
            Console.WriteLine("До конца года осталось {0} дней", osta);
            Console.WriteLine("Вчерашняя дата - {0}:{1}:{2}", predd, predm, predy);
            Console.WriteLine("Завтрашняя дата - {0}:{1}:{2}", nexeld, nexelm, nexely);*/

            /*Zad 2.3
            int first = 0, second = 0, third = 0 , arms;
            for (int i = 100; i < 1000; i++)
            {
                first = i % 10;
                second = (i / 10) % 10;
                third = (i / 100) % 10;
                arms = kub(first) + kub(second) + kub(third);
                if (arms == i) Console.WriteLine("{0} - число Армстронага", i);
            }*/

            /*Zad 2.4
            int n, m, kmax = 0, kmin = 0, ksred = 0;
            Console.WriteLine("Введите длину");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата");
            int d = int.Parse(Console.ReadLine());
            kmax = m / n;
            kmin = m * n;
            ksred = (m / d) * (n / d);
            Console.WriteLine("В ваш прямоугольник помещается {0} квадратов максимальной площади", kmax);
            Console.WriteLine("В ваш прямоугольник помещается {0} квадратов минимальной площади", kmin);
            Console.WriteLine("В ваш прямоугольник помещается {0} квадратов с площадью {1}", ksred, d*d);*/
        }
    }
}
