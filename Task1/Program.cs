// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int ReceiveCount(string text, int size)
{
    Console.WriteLine(text);
    string str = string.Empty;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        int num = int.Parse(Console.ReadLine());
        if(num > 0)
        {
            count++;
            Console.WriteLine($" Количество положительных чисел: {count}");
        } 
        else
        {
             Console.WriteLine($" Количество положительных чисел: {count}");
        }
    }
    return count;
}
int ReceiveSize(string text) {
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int size = ReceiveSize("Сколько чисел обработать?");

int res = ReceiveCount("Введите число ", size);

Console.WriteLine("Помучился =(");