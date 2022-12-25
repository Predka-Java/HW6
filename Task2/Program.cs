// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CheckingTheIntersection(int k1, int b1, int k2, int b2)
{
    int x = 0;
    int y = 0;
    if(k1 == k2)
    {
        Console.WriteLine("Заданные прямые параллельны.");
    }
    else if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("заданные прямые совпадают.");
    }
    else
    {
        x = (b1 - b2) / (k1 - k2);
        y = k1 * (b1 - b2) /(k1 - k2) + b1;
        Console.WriteLine($"Заданные прямые пересекаются в точке x = {x}, y = {y}");
    }
}

int ReceiveSize(string text) {
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

Console.WriteLine("y = k * x + b");
int k1 = ReceiveSize("Введите k1 ");

int b1 = ReceiveSize("Введите b1 ");

int k2 = ReceiveSize("Введите k2 ");

int b2 = ReceiveSize("Введите b2 ");

CheckingTheIntersection(k1, b1, k2, b2);
