string[] mas1 = new string[] {"mama", "mas", "trap", "ya", "init", "bereza", "zoo", "zoom", "ikea", "." };
Console.WriteLine("First array:");
int n = mas1.Length;
for (int i=0; i < n; i++)
{
    Console.Write($"{mas1[i]} ");
}
string[] mas2 = new string[n];
int indexMas2 = 0;
for (int i=0; i < n; i++)
{
    if (mas1[i].Length <= 3)
    {
        mas2[indexMas2] = mas1[i];
        indexMas2++;
    }
}
Console.WriteLine();
Console.WriteLine("New array:");
for (int i=0; i < indexMas2; i++)
{
    Console.Write($"{mas2[i]} ");
}