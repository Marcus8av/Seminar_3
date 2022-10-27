/*Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом*/

void palindrome(string pal)
{
    if (pal[0] == pal[4] && pal[1] == pal[3])
    Console.WriteLine($"Введенное число это палиндром");
    else
    Console.WriteLine($"Введеное число не палиндром");
}

Console.WriteLine("Ввeдите пятизначное число: ");

int Number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(Number);

palindrome(str);