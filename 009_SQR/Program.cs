Console.Clear();
Console.WriteLine("Input Number #1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Number #2: ");
int b = Convert.ToInt32(Console.ReadLine());
int sqr1 = a*a;
int sqr2 = Convert.ToInt32(Math.Pow(b,2));
Console.WriteLine($"Квадрат числа {a} равен {sqr1}");
Console.WriteLine($"Квадрат числа {b} равен {sqr2}");