using static System.Console;
Clear();
Write("Input Number: ");
int a = Convert.ToInt32(ReadLine());
int b = -a;
while (b <= a)
{
    WriteLine(b);
    b = b + 1;
}
