Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int AckermanFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermanFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
return AckermanFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermanFunction(numberM, numberN)}");