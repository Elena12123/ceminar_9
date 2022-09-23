Console.WriteLine("Введите число М");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());


int SummaRec(int N, int M)
{
if (N == M) return 0;
return N + SummaRec(N-1,M);
}

Console.WriteLine(SummaRec(N,M));




