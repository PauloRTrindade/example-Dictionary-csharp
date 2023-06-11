using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();

        Dictionary<string, int> Candidate = new Dictionary<string, int>();

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string Name = line[0];
                    int Votes = int.Parse(line[1]);

                    if (Candidate.ContainsKey(Name))
                    {
                        Candidate[Name] += Votes;
                    }
                    else
                    {
                        Candidate[Name] = Votes;
                    }
                }

                foreach (KeyValuePair<string, int> item in Candidate)
                {
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);

                    }
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}