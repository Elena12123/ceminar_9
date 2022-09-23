Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());


string SummaRec(int N, int M)
{
if (N == M) return $"{M} ";
return SummaRec(N - 1,M) + N + " ";
}

Console.WriteLine(SummaRec(N,M));
