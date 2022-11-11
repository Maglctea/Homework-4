int Step(int chislo, int stepen)
{
    if (stepen == 0)
        return 1;
    
    int sum = 1;

    for (int i = 0; i < stepen; i++)
    {
        sum = sum * chislo;
    }
    return sum;

}


Console.WriteLine("Введите натуральное число (число)");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число (степень числа)");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0)
    Console.WriteLine("Некорректное число. Степень должна быть положительной");
else
    Console.WriteLine(Step(a,n));