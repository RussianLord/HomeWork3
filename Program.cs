void HW1()
{
    Console.WriteLine("Программа находит расстояние между двумя точками в 3D пространстве.");
    Console.WriteLine("Нажмите ENTER для запуска программы...");
    Console.ReadLine();
    Random random = new Random();
    int x1 = random.Next(-10, 10);
    int y1 = random.Next(-10, 10);
    int z1 = random.Next(-10, 10);
    int x2 = random.Next(-10, 10);
    int y2 = random.Next(-10, 10);
    int z2 = random.Next(-10, 10);
    vizov(x1, y1, z1, x2, y2, z2);
}

void vizov(int x1, int y1, int z1, int x2, int y2, int z2)
{
    
    int p1 = x2 - x1;
    int p2 = y2 - y1;
    int p3 = z2 - z1;
    double Leingt = Math.Sqrt(Math.Pow(p1, 2) + Math.Pow(p2, 2) + Math.Pow(p3, 2));
    Console.WriteLine("Расстояние между точками");
    Console.WriteLine($"Первая точка =  {x1}, {y1}, {z1} | Вторая точка =  {x2}, {y2}, {z2}");
    Console.WriteLine("Расстояние между точками = " + Leingt);
}

void HW2()
{
    Console.WriteLine("Программа выдаёт таблицу кубов введённого числа N.");
    Console.WriteLine("Введите число N...");
    int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int i = 1;
    double triple = 1;
    vizov1(i, N, triple);
}

void vizov1(int i, int N, double triple)
{
    while(i < N)
    {
       triple = Math.Pow(i, 3);
       Console.WriteLine($"| {i} | {triple} |");
       i++;
    }
}

void HW3()
{
    Console.WriteLine("Программа сообщает, является ли введённое пятизначное число палиндромом.");
    Console.WriteLine("Введите пятизначное число...");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int n1 = number / 10000;
    int n2 = number / 1000 % 10;
    int n4 = number / 10 % 10;
    int n5 = number % 10;
    string str = number.ToString();
    vizov2(number, n1, n2, n4, n5, str);
}

void vizov2(int number, int n1, int n2, int n4, int n5, string str)
{
    if(str.Length < 5 || str.Length > 5)
    {
        Console.WriteLine("Вы ввели не пятизначное число!");
    }
    else if(n1 == n5 && n2 == n4)
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом.");
    }  
}


// HW1();
HW2();
// HW3();