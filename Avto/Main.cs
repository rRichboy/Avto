namespace avto
{
    class main
    {
        static void Main(string[] args)
        {
            Avto avto1 = new Avto();
            Avto avto2 = new Avto();

            Console.Write("Введите номер первого авто: ");
            string nomer = Console.ReadLine();

            Console.Write("Введите количество бензина в баке (в литрах): ");
            double bak = double.Parse(Console.ReadLine());

            Console.Write("Введите расход топлива на 100 км (в л/100км): ");
            double ras = double.Parse(Console.ReadLine());

            Console.Write("Введите номер второго авто: ");
            string nomer2 = Console.ReadLine();

            Console.Write("Введите количество бензина в баке второго авто (в литрах): ");
            double bak2 = double.Parse(Console.ReadLine());

            Console.Write("Введите расход топлива на 100 км второго авто (в л/100км): ");
            double ras2 = double.Parse(Console.ReadLine());

            avto1.Info(nomer, bak, ras);
            avto2.Info(nomer2, bak2, ras2);

            while (true)
            {
                Console.WriteLine("Выберите машину (1 или 2):");
                int carChoice = int.Parse(Console.ReadLine());

                Avto selectedCar;

                if (carChoice == 1)
                {
                    selectedCar = avto1;
                }
                else if (carChoice == 2)
                {
                    selectedCar = avto2;
                }
                else
                {
                    Console.WriteLine("Неверный выбор машины. Повторите попытку.");
                    continue;
                }

                Console.WriteLine("Выберите действие для машины " + carChoice + ":");
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
                        selectedCar.Move(speed, distance);
                        break;

                    case 2:
                        Console.Write("Введите скорость для разгона (в км/ч): ");
                        int additionalSpeed = int.Parse(Console.ReadLine());
                        selectedCar.Razgon(additionalSpeed);
                        break;

                    case 3:
                        selectedCar.Tormozhenie();
                        break;

                    case 4:
                        Console.Write("Введите количество бензина для заправки (в литрах): ");
                        double top = double.Parse(Console.ReadLine());
                        selectedCar.Zapravka(top);
                        break;

                    case 5:
                        selectedCar.Out();
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
