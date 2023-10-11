namespace avto
{
    class main
    {
        static void Main(string[] args)
        {
            Avto avto1 = new Avto("Car1", 50.0, 10.0);
            Avto avto2 = new Avto("Car2", 50.0, 10.0);

            Console.Write("Введите расстояние дороги (в км): ");
            int roadDistance = int.Parse(Console.ReadLine());
            double totalDistance = 0;

            while (totalDistance < roadDistance)
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
                        totalDistance += distance;
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

                if (selectedCar.CheckCollision(roadDistance, totalDistance))
                {
                    Console.WriteLine("Авария!");
                    return;
                }
            }
        }
    }
}
