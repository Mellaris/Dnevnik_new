using chernovik2;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace chernovik2
{
    internal class Program
    { 
    
        private int month;
        private int a;
        private int vibor;
        private int row;
        private int col;
        private int[,] nastr_avg = new int[31, 2];
        private int[,] nastr_sen = new int[30, 2];
        private int[,] nastr_okt = new int[31, 2];
        private int row_2;
        private int col_2;
        private int row_3;
        private int col_3;
        private int vibor_2;
        private int c = 0;
        private float ch;
        private float sr_diap;
        private int count;
        private int count_2;
        private int count_3;
        private int count_4;
        private string[] week = new string[7];

        public void Ned()
        {
            foreach (string i in week)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        public void Ccalendar()
        {
            Console.WriteLine("Дневник настроения");
            Console.WriteLine("Календарь");
            Console.WriteLine("Август");
            week = new string[7] { "ПН\t", "ВТ\t", "СР\t", "ЧТ\t", "ПТ\t", "СБ\t", "ВС\t" };
            Ned();
            int[,] data_av = new int[5, 7];
            int rows = data_av.GetUpperBound(0) + 1;
            int columns = data_av.Length / rows;
            a = 1;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    data_av[i, j] = 0;
                }
            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 1; j < columns && a <= 31; j++)
                {
                    data_av[i, j] = a;
                    a++;
                }
            }
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < columns && a <= 31; j++)
                {
                    data_av[i, j] = a;
                    a++;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{data_av[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сентябрь");
            Ned();
            int[,] data_sep = new int[5, 7];
            a = 1;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    data_sep[i, j] = 0;
                }
            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 4; j < columns && a <= 30; j++)
                {
                    data_sep[i, j] = a;
                    a++;
                }
            }
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < columns && a <= 30; j++)
                {
                    data_sep[i, j] = a;
                    a++;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{data_sep[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Октябрь");
            int[,] data_ok = new int[6, 7];
            int rowss = data_ok.GetUpperBound(0) + 1;
            int columnss = data_ok.Length / rowss;
            Ned();
            a = 1;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    data_ok[i, j] = 0;
                }
            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 6; j < columnss; j++)
                {
                    data_ok[i, j] = a;
                    a++;
                }
            }
            for (int i = 1; i < rowss; i++)
            {
                for (int j = 0; j < columnss && a <= 31; j++)
                {
                    data_ok[i, j] = a;
                    a++;
                }
            }
            for (int i = 0; i < rowss; i++)
            {
                for (int j = 0; j < columnss; j++)
                {
                    Console.Write($"{data_ok[i, j]} \t");
                }
                Console.WriteLine();
            }
            Nastr();
            Nastr_3();
            Console.WriteLine("Напишитие за какой месяц хотите посмотреть настроение");
            Console.WriteLine("Подсказка: 1 - Август, 2 - Сентябрь, 3 - Октябрь");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Vibor();
        }
        private void Nastr()
        {
            Random nastr = new Random(1);
            row = nastr_avg.GetUpperBound(0) + 1;
            col = nastr_avg.Length / row;
            a = 1;
            while (c < 1)
            {
                for (int i = 0; i < row && a <= 31; i++)
                {
                    for (int q = 0; q < 1; q++)
                    {
                        nastr_avg[i, q] = a;
                        a++;
                    }
                }
                for (int i = 0; i < row; i++)
                {
                    for (int q = 1; q < 2; q++)
                    {
                        nastr_avg[i, q] = nastr.Next(1, 6);
                    }
                }
                Random nastr_2 = new Random(2);
                row_2 = nastr_sen.GetUpperBound(0) + 1;
                col_2 = nastr_sen.Length / row_2;
                a = 1;
                for (int i = 0; i < row_2 && a <= 30; i++)
                {
                    for (int q = 0; q < 1; q++)
                    {
                        nastr_sen[i, q] = a;
                        a++;
                    }
                }
                for (int i = 0; i < row_2; i++)
                {
                    for (int q = 1; q < 2; q++)
                    {
                        nastr_sen[i, q] = nastr_2.Next(1, 6);
                    }
                }
                Random nastr_3 = new Random(3);
                row_3 = nastr_okt.GetUpperBound(0) + 1;
                col_3 = nastr_okt.Length / row_3;
                a = 1;
                for (int i = 0; i < row_3 && a <= 31; i++)
                {
                    for (int q = 0; q < 1; q++)
                    {
                        nastr_okt[i, q] = a;
                        a++;
                    }
                }
                for (int i = 0; i < row_3; i++)
                {
                    for (int q = 1; q < 2; q++)
                    {
                        nastr_okt[i, q] = nastr_3.Next(1, 6);
                    }
                }
                c++;
            }
        }
        public void Nastr_3()
        {
            int sum_avg = 0;
            int sum_sen = 0;
            int sum_okt = 0;
            for (int i = 0; i < row; i++)
            {
                for (int q = 1; q < 2; q++)
                {
                    sum_avg = nastr_avg[i, q] + sum_avg;
                }
            }
            for (int i = 0; i < row_2; i++)
            {
                for (int q = 1; q < 2; q++)
                {
                    sum_sen = nastr_sen[i, q] + sum_sen;
                }
            }
            for (int i = 0; i < row_3; i++)
            {
                for (int q = 1; q < 2; q++)
                {
                    sum_okt = nastr_okt[i, q] + sum_okt;
                }
            }
            double sr_avg = sum_avg / 31.0;
            double sr_sen = sum_sen / 30.0;
            double sr_okt = sum_okt / 31.0;
            double max_sr = (sr_avg + sr_sen + sr_okt) / 3.0;
            Console.WriteLine($"Среднее настроение за 3 месяца: {max_sr}");
        }
        public void Vibor()
        {
                for (int i = 0; i < 30; i++)
                {
                    for (int q = 0; q < col_3; q++)
                    {
                        if (month == 3)
                            Console.Write($"{nastr_okt[i + 1, q]} \t");
                        if (month == 2)
                            Console.Write($"{nastr_sen[i, q]} \t");
                        if (month == 1)
                            Console.Write($"{nastr_avg[i + 1, q]} \t");
                    }
                    Console.WriteLine();
                }
                Vopros();
        }
        public void Vopros()
        {
            Console.WriteLine("Укажите, что вы хотели бы сделать:");
            Console.WriteLine("1. Среднее настроение за последнюю неделю;\n2. Среднее настроение за определенный диапазон;\n3. Количество дней хорошего/отличного настроения;\n4. Количество дней плохого/ужасного настроения. ");
            Console.WriteLine("Если хотите вернуться в главное меню, нажмите: 0");
            vibor = Convert.ToInt32(Console.ReadLine());
            if (vibor == 0)
            {
                Ccalendar();
            }
            if (vibor == 1)
            {
                Sr_ned();
            }
            if (vibor == 2)
            {
                Sr_diap();
            }
            if (vibor == 3)
            {
                Best();
            }
            if (vibor == 4)
            {
                Terrible();
            }
        }
        public void Sr_ned()
        {

            if (month == 1)
            {
                double sum_avg_2 = 0;
                for (int i = 24; i < 31; i++)
                {
                    for (int q = 1; q < 2; q++)
                    {
                        sum_avg_2 = nastr_avg[i, q] + sum_avg_2;
                    }
                }
                double sr_ned = sum_avg_2 / 7.0;
                Console.WriteLine($"Среднее настроение за последнюю неделю: {sr_ned}");
                Vibbor_2();
            }
            if (month == 2)
            {
                double sum_sen_2 = 0;
                for (int i = 23; i < 30; i++)
                {
                    for (int q = 1; q < 2; q++)
                    {
                        sum_sen_2 = nastr_sen[i, q] + sum_sen_2;
                    }
                }
                double sr_ned = sum_sen_2 / 7.0;
                Console.WriteLine($"Среднее настроение за последнюю неделю: {sr_ned}");
                Vibbor_2();
            }
            if (month == 3)
            {
                double sum_okt_2 = 0;
                for (int i = 24; i < 31; i++)
                {
                    for (int q = 1; q < 2; q++)
                    {
                        sum_okt_2 = nastr_okt[i, q] + sum_okt_2;
                    }
                }
                double sr_ned = sum_okt_2 / 7.0;
                Console.WriteLine($"Среднее настроение за последнюю неделю: {sr_ned}");
                Vibbor_2();
            }
        }
        public void Vibbor_2()
        {
            count = 0;
            count_2 = 0;
            count_3 = 0;
            count_4 = 0;
            Console.WriteLine("Чтобы вернуться назад, нажмите 9");
            vibor_2 = Convert.ToInt32(Console.ReadLine());
            if (vibor_2 == 9)
            {
                Vopros();
            }
        }
        public void Sr_diap()
        {
            int sum_diap = 0;
            Console.Write("Введите начальную дату, с которой будет начинаться отсчет(Например: 5): ");
            int date_1 = Convert.ToInt32(Console.ReadLine());
            float d_1 = date_1;
            date_1 = date_1 - 1;
            Console.Write("Введите конечную дату, до которой будет идти отсчет(Например: 20): ");
            int date_2 = Convert.ToInt32(Console.ReadLine());
            int d2 = date_2;
            date_2 = date_2 + 1;
            float d_2 = date_2;
            if (month == 1)
            {
                for (int i = date_1; date_1 + 1 < date_2; date_1++)
                {
                    for (int q = 1; q < 2; q++)
                    {
                        sum_diap = sum_diap + nastr_avg[date_1, q];
                    }
                }
                ch = d_2 - d_1;
                sr_diap = sum_diap / ch;
                Console.WriteLine($"Среднее настроение с {d_1} августа по {d2} августа: {sr_diap}");
                Vibbor_2();
            }
            if (month == 2)
            {
                for (int i = date_1; date_1 + 1 < date_2; date_1++)
                {
                    for (int q = 1; q < 2; q++)
                    {
                        sum_diap = sum_diap + nastr_sen[date_1, q];
                    }
                }
                ch = d_2 - d_1;
                sr_diap = sum_diap / ch;
                Console.WriteLine($"Среднее настроение с {d_1} сентября по {d2} сентября: {sr_diap}");
                Vibbor_2();
            }
            if (month == 3)
            {
                for (int i = date_1; date_1 + 1 < date_2; date_1++)
                {
                    for (int q = 1; q < 2; q++)
                    {
                        sum_diap = sum_diap + nastr_okt[date_1, q];
                    }
                }
                ch = d_2 - d_1;
                sr_diap = sum_diap / ch;
                Console.WriteLine($"Среднее настроение с {d_1} октября по {d2} октября: {sr_diap}");
                Vibbor_2();
            }
        }
        public void Best()
        {
            for (int i = 0; i < 30; i++)
            {
                for (int q = 0; q < col_3; q++)
                {
                    if (month == 1)
                    {
                        if (nastr_avg[i, q] > 3)
                        {
                            count++;
                        }
                        if (nastr_avg[i, q] == 4)
                        {
                            count_2++;
                        }
                        if (nastr_avg[i, q] == 5)
                        {
                            count_3++;
                        }
                    }
                    if (month == 2)
                    {
                        if (nastr_sen[i, q] > 3)
                        {
                            count++;
                        }
                        if (nastr_sen[i, q] == 4)
                        {
                            count_2++;
                        }
                        if (nastr_sen[i, q] == 5)
                        {
                            count_3++;
                        }
                    }
                    if (month == 3)
                    {
                        if (nastr_okt[i, q] > 3)
                        {
                            count++;
                        }
                        if (nastr_okt[i, q] == 4)
                        {
                            count_2++;
                        }
                        if (nastr_okt[i, q] == 5)
                        {
                            count_3++;
                        }
                    }
                }
            }
            Vivod();
            Vibbor_2();
        }
        public void Vivod()
        {
            Console.WriteLine($"Количество хороших дней: {count}");
            Console.WriteLine($"Дней с настроением 4: {count_2}");
            Console.WriteLine($"Дней с настроением 5: {count_3}");
        }
        public void Terrible()
        {
                for (int i = 0; i < 30; i++)
                {
                    for (int q = 0; q < col_3; q++)
                    {
                        if (month == 1)
                        {
                            if (nastr_avg[i, q] < 4)
                            {
                                count++;
                            }
                            if (nastr_avg[i, q] == 3)
                            {
                                count_2++;
                            }
                            if (nastr_avg[i, q] == 2)
                            {
                                count_3++;
                            }
                            if (nastr_avg[i, q] == 1)
                            {
                                count_4++;
                            }
                        }
                        if (month == 2)
                        {
                            if (nastr_sen[i, q] < 4)
                            {
                                count++;
                            }
                            if (nastr_sen[i, q] == 3)
                            {
                                count_2++;
                            }
                            if (nastr_sen[i, q] == 2)
                            {
                                count_3++;
                            }
                            if (nastr_sen[i, q] == 1)
                            {
                                count_4++;
                            }
                        }
                        if (month == 3)
                        {
                            if (nastr_okt[i + 1, q] < 4)
                            {
                                count++;
                            }
                            if (nastr_okt[i + 1, q] == 3)
                            {
                                count_2++;
                            }
                            if (nastr_okt[i + 1, q] == 2)
                            {
                                count_3++;
                            }
                            if (nastr_okt[i + 1, q] == 1)
                            {
                                count_4++;
                            }
                        }
                    }  
                }
            Vivod_2();
            Vibbor_2();
        }
        public void Vivod_2()
        {
            Console.WriteLine($"Количество плохих дней: {count}");
            Console.WriteLine($"Дней с настроением 3: {count_2}");
            Console.WriteLine($"Дней с настроением 2: {count_3}");
            Console.WriteLine($"Дней с настроением 1: {count_4}");
        }
        static void Main(string[] args)
        {
            Program pol = new Program();
            pol.Ccalendar();
        }
    }
}