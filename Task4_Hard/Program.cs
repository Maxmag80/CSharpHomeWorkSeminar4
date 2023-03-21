// Задача 27 HARD: Напишите программу, которая принимает на вход число (целое, вещественное, в экспоненциальной форме) и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9,012 -> 12;  6,02214129e23 -> 27
Console.WriteLine("Input any number: ");
string nums = Console.ReadLine();
char exp = 'e';
int IndexOfChar = nums.IndexOf(exp);
int sum = 0;

void Result(string nums)
{
    decimal num = Convert.ToDecimal(nums);
    while((num % 1) > 0)
        num *= 10;
    int num1 = Convert.ToInt32(num);

    while(num1 >= 1)
    {
        sum += num1 % 10;
        num1 /= 10;
    }
    Console.WriteLine(sum);
}
if(IndexOfChar < 1)
    Result(nums);
else
{
    nums = nums.Substring(0, IndexOfChar);
    Result(nums);
}

