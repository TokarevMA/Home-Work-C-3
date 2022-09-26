// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string a = Console.ReadLine();
if (a.Length == 5)
{
    Chek (a);
}
else 
Console.WriteLine("Введите корректное число ");

void Chek (string a)
{
    if(a[0] == a[4] || a[1] == a[3])
    {
    Console.WriteLine($"Ваше число {a} - Полиандром!!!");
    }
    else Console.WriteLine($"Ваше число {a} - Не Полиандром!");
}
