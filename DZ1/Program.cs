void Palindrom(int num, int num1, int num2, int num4, int num5)
{
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("Данное число - Палиндром");
    }
    else
    {
        Console.WriteLine("Данное число не является палиндромом");
    }
}

Console.WriteLine("Напишите пятизначное число для проверки на палиндром");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 0;
int num4 = 0;
int num5 = 0;
num1 = num / 10000;
num2 = num % 10000 / 1000;
num4 = num % 100 / 10;
num5 = num % 10;
Palindrom(num, num1, num2, num4, num5);




