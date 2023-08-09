using System.Text.RegularExpressions;

//class Program
//{
//    static void Main(string[] args)
//    {
//Console.WriteLine("Enter the String");
//string str = Console.ReadLine();
//string[] strary = str.Split(new char[] { ' ', ',', '.' });


//var groups = strary.GroupBy(x => x); // this groups the words
//foreach (var group in groups)
//{
//    Console.WriteLine("{ 0}");
//    Console.WriteLine(" appears - {1} times", group.Key, group.Count());

//    string phrase;
//    int word = 1;


//    Console.Write("Enter a phrase: ");
//    phrase = Console.ReadLine();

//    for (int i = 0; i<phrase.Length; i++)
//    {
//        if (phrase[i] == ' ')
//        {
//            word++;
//        }
//    }
//    Console.WriteLine(word);

//}
//}
class Program
{
    static void Main()
    {
        string input = "I love to code in C#,C# is a great language";

        Dictionary<string, int> wordCount = CountWords(input);

        foreach (var kvp in wordCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    static Dictionary<string, int> CountWords(string input)
    {
        string[] words = input.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        return wordCount;
    }
}