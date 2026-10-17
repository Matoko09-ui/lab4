// 30 variant baza

//Random rnd = new Random();
//double[] mas = new double[12];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rnd.NextDouble() * 100;
//    Console.Write($"{mas[i]:F2} ");
//}
//Console.WriteLine();
//double min = mas[0];
//int index = 0;
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i] < min)
//    {
//        min = mas[i]; index = i;
//    }
//}
////Console.WriteLine($"Сумма мин.элемента{min} и его индекса {index}:{min+index:F2}");


//Вариант 2 средний уровень

int[] mas = new int[8];
Console.WriteLine("Введите 8 двузначных чисел: ");
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Элемент[{i}]: ");
    mas[i] = Convert.ToInt32(Console.ReadLine());
}
int[] mas2 = new int[8];
for (int i = 0; i < 8; i++)
{
    mas2[i] = mas[i] % 10;
}
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < 8; i++)
{
    Console.WriteLine(mas[i] + "");
}
Console.WriteLine("Новый массив");
for (int i = 0; i < 8; i++)
{
    Console.WriteLine(mas2[i] + "");
}
Console.WriteLine();