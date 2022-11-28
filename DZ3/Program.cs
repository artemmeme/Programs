Console.WriteLine("Напишите число вывода кубов");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
int num1 = 1;
while (i < num + 1)
{
num1 = i*i*i;
Console.Write($"{num1}  ");
i++;
}
