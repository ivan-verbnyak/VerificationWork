Console.WriteLine("Input array of strings: ");
string[] line = new string[5];

for (int i = 0; i < line.Length; i++)
{
    line[i] = Console.ReadLine();
}
foreach (var item in line)
{
    if (item.Length <= 3)
    {
        Console.Write($"{item}, ");
    }
}
Console.WriteLine();