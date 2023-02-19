using System.Diagnostics;

namespace SingleResposibilityPrinciple
{

    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{count++}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        //public void SaveToFile(string fileName)
        //{
        //    File.WriteAllText(fileName, ToString());
        //}

        public class Persistence
        {
            public void SaveToFile(Journal journal, string fileName)
            {
                if (!File.Exists(fileName))
                {
                    File.WriteAllText(fileName, journal.ToString());
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var journal = new Journal();
                journal.AddEntry("My name Petter");
                journal.AddEntry("I ate a bug");
                Console.WriteLine(journal.ToString());

                var persistence = new Persistence();
                var fileName = @"c:\temp\journal.txt";
                persistence.SaveToFile(journal, fileName);
                var process = new Process();
                process.StartInfo = new ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                };
                process.Start();
                Console.ReadLine();
            }
        }
    }
}