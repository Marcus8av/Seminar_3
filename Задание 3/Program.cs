/*Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N*/

void cube(int N)
{
    int count = 1;
    Console.Write(N + "-> ");
    while(count <= N)
    {
        Console.Write(count * count * count + " ");
        count++;
    }
}
Console.Write("Введите число: ");

int Number = Convert.ToInt32(Console.ReadLine());

if(Number > 0)
cube(Number);

else
Console.Write("Введенное число не является положительным");