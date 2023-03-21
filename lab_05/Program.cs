

//task1
Console.WriteLine("Введите имена: ");
string input = Console.ReadLine();
string[] names = input.Split(' ');
List<string> result = new List<string>();

foreach (string name in names)
{
    if (string.Compare(name, "Маша") < 0)
    {
        result.Add(name);
    }
}

result.Sort();

foreach (string name in result)
{
    Console.WriteLine(name);
}

//task2
Console.WriteLine("Введите строку: ");
string inputString = Console.ReadLine();
string[] lines = inputString.Split(' ');
List<string> resultString = new List<string>();

foreach (string line in lines)
{
    if (line.Length == 4)
    {
        resultString.Append("love_Is");
    }
    else
    {
        resultString.Append(line + " ");
    }
}

foreach (string line in resultString)
{
    Console.WriteLine(line);
}

//task3
Console.WriteLine("Введите строку: ");
string inputLine = Console.ReadLine();
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
for (int i = n; i < inputLine.Length; i += (n + 1))
{
    inputLine = inputLine.Insert(i, ":)");
}
Console.WriteLine(inputLine);

//task4

Console.WriteLine("Введите слова: ");
string inputWords = Console.ReadLine();
string[] words = inputWords.Split(' ');

string longest = words[0];
string shortest = words[0];

foreach (string word in words)
{
    if (word.Length > longest.Length)
    {
        longest = word;
    }
    if (word.Length < shortest.Length)
    {
        shortest = word;
    }
}

string output = $"{longest},{shortest}\n";

for (int i = 0; i < longest.Length; i++)
{
    output += longest + ",";
}
for (int i = 0; i < shortest.Length; i++)
{
    output += shortest;
    if (i < shortest.Length - 1)
    {
        output += ",";
    }
}
Console.WriteLine(output);

//task5

Console.WriteLine("Введите слова: ");
string inputWrd = Console.ReadLine();
string[] NewWords = inputWrd.Split(' ');
List<string> resultLine = new List<string>();

foreach (string word in NewWords)
{
    if (!resultLine.Contains(word))
    {
        resultLine.Add(word);
    }
}

string outputString = "";
foreach (string word in resultLine)
{
    outputString += word + " ";
}

Console.WriteLine(outputString);





