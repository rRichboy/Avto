namespace avto
{
    class main
    {
        static void Main(string[] args)
        {
            Avto avto1 = new Avto();

            Console.Write("Введите номер авто: ");
            string nomer = Console.ReadLine();

            Console.Write("Введите количество бензина в баке (в литрах): ");
            double bak = double.Parse(Console.ReadLine());

            Console.Write("Введите расход топлива на 100 км (в л/100км): ");
            double ras = double.Parse(Console.ReadLine());

            avto1.Info(nomer, bak, ras);

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Поехать");
                Console.WriteLine("2 - Разогнать автомобиль");
                Console.WriteLine("3 - Тормозить");
                Console.WriteLine("4 - Заправить автомобиль");
                Console.WriteLine("5 - Вывести информацию");
                Console.WriteLine("6 - Выход");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите скорость для поездки (в км/ч): ");
                        int speed = int.Parse(Console.ReadLine());
                        Console.Write("Введите расстояние: ");
                        int distance = int.Parse(Console.ReadLine());
                        avto1.Move(speed, distance);
                        break;

                    case 2:
                        Console.Write("Введите скорость для разгона (в км/ч): ");
                        int additionalSpeed = int.Parse(Console.ReadLine());
                        avto1.Razgon(additionalSpeed);
                        break;

                    case 3:
                        avto1.Tormozhenie();
                        break;

                    case 4:
                        Console.Write("Введите количество бензина для заправки (в литрах): ");
                        double top = double.Parse(Console.ReadLine());
                        avto1.Zapravka(top);
                        break;

                    case 5:
                        avto1.Out();
                        break;

                    case 6:
                        Console.WriteLine("Программа завершена.");
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Повторите попытку.");
                        break;
                }
            }
        }
    }
}
