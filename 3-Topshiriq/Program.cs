

using _3_Topshiriq;

int n = 10;

var parts = new List<SinglePart>();

for (int i = 0; i < n; i++)
{
    parts.Add(new SinglePart()
    {
        Power = i,
        Ratio = Math.Round(Random.Shared.NextDouble(), 1)
    });
}
Polinom polinom = new Polinom(parts.ToArray());

Console.WriteLine(polinom);
Console.WriteLine(polinom.Compute(100));

Console.WriteLine(polinom.Diff());
Console.WriteLine(polinom.Diff().Compute(100));

Console.WriteLine(Math.Round(0.7 * 6, 4));

Console.ReadKey();