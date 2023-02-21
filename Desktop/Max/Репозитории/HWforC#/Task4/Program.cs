// Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все
// чётные числа от 1 до N.
// 5 -> 2, 4.
// 8 -> 2, 4, 6, 8

int N = int.Parse(Console.ReadLine());
int i = 1, k = 1;            
while (true)
{
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
		k++;
	}
	if (k > N)
	{
		break;
	}
	i++;
}