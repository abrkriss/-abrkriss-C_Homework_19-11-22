void Zadacha19()
{
    //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    Console.WriteLine("Введите пятизначное число: ");
    string num = Console.ReadLine();

   
    if ((num[0] == num[4] || num[1] == num[3]) && (num!.Length == 5))
    {
        Console.WriteLine(num + " - является палиндромом");
    }
    else if   (num!.Length != 5)
    {
        Console.WriteLine("Введено некорректное число. ");
    }
    else
    {
         Console.WriteLine(num + " -  не является палиндромом");
    }

   
}
Zadacha19();