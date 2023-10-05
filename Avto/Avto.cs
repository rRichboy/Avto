using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avto
{
    class Avto
    {
        private string nomerAvto;
        private double kolichestvoBenzina;
        private double rashodTopliva;
        private double ostatokTopliva;
        private double skorost;
        private double probeg;

        public void Info(string nom, double bak, double ras)
        {
            nomerAvto = nom;
            kolichestvoBenzina = bak;
            rashodTopliva = ras;
            ostatokTopliva = bak;
            skorost = 0.0;
            probeg = 0.0;
        }

        public void Out()
        {
            Console.WriteLine($"Номер авто: {nomerAvto}");
            Console.WriteLine($"Количество бензина в баке: {ostatokTopliva} л");
            Console.WriteLine($"Расход топлива на 100 км: {rashodTopliva} л/100км");
            Console.WriteLine($"Текущая скорость: {skorost} км/ч");
            Console.WriteLine($"Ваш пробег: {probeg} км");
        }

        public void Zapravka(double top)
        {
            kolichestvoBenzina += top;
            ostatokTopliva += top;
        }

        public void Move(int speed, int distance)
        {
            if (speed <= 0)
            {
                Console.WriteLine("Скорость должна быть больше нуля.");
                return;
            }



            double rashodToplivaNaKm = rashodTopliva / 100;
            double rashod = distance * rashodToplivaNaKm;

            if (ostatokTopliva >= rashod)
            {
                ostatokTopliva -= rashod;
                probeg += distance;
                Console.WriteLine($"Проехано {distance} км со скоростью {speed} км/ч. Остаток топлива: {ostatokTopliva:F2} л");
                skorost = speed;
            }

            else

            {
                int maxDistance = (int)(ostatokTopliva / rashodToplivaNaKm);

                if (maxDistance > 0)
                {
                    Console.WriteLine($"Недостаточно топлива для поездки на всю дистанцию {distance} км.");
                    Console.WriteLine($"Машина проедет {maxDistance} км со скоростью {speed} км/ч.");
                    probeg += maxDistance;
                    Console.WriteLine("Машина проехала максимальное расстояние с текущим количеством топлива.");

                    Console.Write("Желаете дозаправить машину? (Да/Нет): ");
                    string choice = Console.ReadLine();
                    if (choice.ToLower() == "да")
                    {
                        Console.Write("Введите количество топлива для дозаправки: ");
                        double topUpAmount = double.Parse(Console.ReadLine());
                        Zapravka(topUpAmount);
                        Console.WriteLine($"Машина дозаправлена на {topUpAmount:F2} л.");
                        Move(speed, distance - maxDistance);
                    }
                }

                else

                {
                    Console.WriteLine("Недостаточно топлива для поездки.");
                }
            }
        }

        private double Ostatok()
        {
            return ostatokTopliva;
        }

        public void Tormozhenie()
        {
            Console.WriteLine("Автомобиль замедляется.");
            skorost = 0.0;
        }

        public void Razgon(int additionalSpeed)
        {
            if (ostatokTopliva >= 1.0)
            {
                skorost += additionalSpeed;
                rashodTopliva += 0.5;
                ostatokTopliva -= 1.0;
                Console.WriteLine($"Автомобиль разгоняется до скорости {skorost} км/ч. Расход топлива увеличен.");
            }
            else
            {
                Console.WriteLine("Недостаточно топлива для разгона.");
            }
        }

        private void proydennoerast(int distance)
        {
            this.probeg += distance;
        }
    }
}
