void Zadacha19()
{
    //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    Console.WriteLine("Введите пятизначное число: ");
    string number = Console.ReadLine();

    if   (number!.Length != 5)
    {
        Console.WriteLine("Введено некорректное число. ");
    }
    else if ((number[0] == number[4] || number[1] == number[3]) && (number!.Length == 5))
    {
        Console.WriteLine(number + " - является палиндромом");
    }
    else if   (number!.Length != 5)
    {
        Console.WriteLine("Введено некорректное число. ");
    }
    else
    {
         Console.WriteLine(number + " -  не является палиндромом");
    }

   
}
Zadacha19();