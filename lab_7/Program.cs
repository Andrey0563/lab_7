using System;
using System.Collections.Generic;
using System.Collections;

namespace Task_7

{
    class WeatherDay
    {

        private double tem_day;
        private double tem_night;
        private double pressure;
        private double precipitation;
        private int typeWeather;
        private int counterOfBedWeather = 0;//дощ або гроза
        private int counterOfDarksky = 0;//туман

        private static List<double> TemperaturaDays = new List<double>();
        private static List<double> TemperaturaNight = new List<double>();
        private static List<double> Pressure = new List<double>();
        private static List<double> Precipitation = new List<double>();
        private static ArrayList WeatherType = new ArrayList();


        public void Weather()
        {
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Середня темперартура вдень");
                        tem_day = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Якась помилка");
                    }
                }
                TemperaturaDays.Add(tem_day);

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Середня темперартура вночі");
                        tem_night = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Якась помилка");
                    }
                }
                TemperaturaNight.Add(tem_night);

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Середній атмосферний тиск");
                        pressure = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Якась помилка");
                    }
                }
                Pressure.Add(pressure);

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Кількість опадів (мм/день),");
                        precipitation = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Якась помилка");
                    }
                }
                Precipitation.Add(precipitation);

                while (true)
                {
                    try
                    {
                        Console.WriteLine("***********");
                        Console.WriteLine("Вкажіть тип погоди, який був у цей день:\n" +
                            "1.дощ\n" +
                            "2.короткочасний дощ\n" +
                            "3.гроза\n" +
                            "4.сніг\n" +
                            "5.туман\n" +
                            "6.похмуро\n" +
                            "7.сонячноn\n");
                        typeWeather = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Якась помилка");
                    }
                }

                if (typeWeather == 1)
                {
                    WeatherType.Add(weather.дощ);
                    counterOfBedWeather++;
                }
                if (typeWeather == 2)
                {
                    WeatherType.Add(weather.короткочастний_дощь);
                    counterOfBedWeather++;
                }
                if (typeWeather == 3)
                {
                    WeatherType.Add(weather.гроза);
                    counterOfBedWeather++;
                }
                if (typeWeather == 4)
                {
                    WeatherType.Add(weather.сніг);

                }
                if (typeWeather == 5)
                {
                    WeatherType.Add(weather.туман);
                    counterOfDarksky++;
                }
                if (typeWeather == 6)
                {
                    WeatherType.Add(weather.похмуро);

                }
                if (typeWeather == 7)
                {
                    WeatherType.Add(weather.сонячно);
                }
                else
                {
                    WeatherType.Add(weather.не_визначено);
                }

            }
        }



        public void GetiNfo(int a)
        {
            Console.WriteLine("***********");
            Console.WriteLine("Загальні відомості про місяць");
            {
                double T = 0;
                for (int i = 0; i < 3; ++i)
                    T += Pressure[i];
                Console.WriteLine($"Середній тиск протягом місяця:{T / 3}");
            }

            Console.WriteLine($"Загальна  кількість  днів  коли  був туман: {counterOfDarksky}\n" +
                $"Кількість днів коли був дощ або гроза у місяці: {counterOfBedWeather}\n");
            if (a > 0 & a != 0 & a <= 30)
            {
                Console.WriteLine($"Інфорцація про день:{a}\n" +
                    $"Середня темперартура вдень:{TemperaturaDays[a - 1]}°C\n" +
                    $"Середня темперартура вночі:{ TemperaturaNight[a - 1]}°C\n" +
                    $"Середній атмосферний тиск:{Pressure[a - 1]}мм рт.ст\n" +
                    $"Кількість опадів :{Precipitation[a - 1]}мм/день\n" +
                    $"Тип погоди:{WeatherType[a - 1]}");
            }
            else
            {
                Console.WriteLine($"інформація про день {a} відсутня");
            }
        }
        enum weather : byte
        {
            не_визначено = 0,
            дощ,
            короткочастний_дощь,
            гроза,
            сніг,
            туман,
            похмуро,
            сонячно
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            WeatherDay A = new WeatherDay();
            A.Weather();
            while (true)
            {
                try
                {
                    Console.WriteLine("Номер дня про який хочете отримати інформацію");
                    a = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("кась помилка");
                }
            }
            A.GetiNfo(a);

        }
    }
}