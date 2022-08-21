namespace Module_13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Text = File.ReadAllText("Text1.txt");
                var noPunctuationText = new string(Text.Where(c => !char.IsPunctuation(c)).ToArray());
                string[] Subs = noPunctuationText.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> Words = new Dictionary<string, int>();
                foreach (string item in Subs)
                {
                    if (Words.ContainsKey(item))
                    {
                        Words[item]++;
                    }
                    else
                    {
                        Words.Add(item, 1);
                    }
                }
                var top10 = Words.OrderByDescending(pair => pair.Value).Take(10);
                Console.WriteLine("10 слов, наиболее часто встречающихся в романе \"Обломов\":");
                foreach (var item in top10)
                {
                    Console.WriteLine($"Слово \"{item.Key}\" повторяется в тексте {item.Value} раз");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Произошла ошибка!");
            }
        }
    }
}