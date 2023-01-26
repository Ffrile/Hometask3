System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int num2 = 0;
while (num > 0)
{
    num2 = (num2 *10) + num % 10;
    num = num / 10; 
}
if (num2 == num1)
{
    System.Console.WriteLine("Число является палиндромом");
}
else
{
    System.Console.WriteLine("Не палиндром");
}
