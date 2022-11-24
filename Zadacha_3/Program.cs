void Zadacha23()
{
    //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    Console.WriteLine("Введите число максимального значения в таблице квадратов: ");
    int N = Convert.ToInt32(Console.ReadLine());

    
            for(int i = 1; i <= N; i++)
                Console.WriteLine(i + "^3" + "\t" + "=" + "\t" + i*i*i);

}
Zadacha23();
