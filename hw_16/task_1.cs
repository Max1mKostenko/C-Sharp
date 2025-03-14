class Moderator
{
    static void Main()
    {
        Console.Write("Enter the path to the text file: ");
        string? text_file_path = Console.ReadLine();

        Console.Write("Enter the path to the moderation words file: ");
        string? moderation_file_path = Console.ReadLine();

        if (!File.Exists(text_file_path) || !File.Exists(moderation_file_path))
        {
            Console.WriteLine("One or both files not found!");
            return;
        }

        if (Path.GetExtension(text_file_path).ToLower() != ".txt" ||
            Path.GetExtension(moderation_file_path).ToLower() != ".txt")
        {
            Console.WriteLine("Both files must be .txt!");
            return;
        }

        string text = File.ReadAllText(text_file_path);
        string[] forbidden_words = File.ReadAllLines(moderation_file_path);

        foreach (string word in forbidden_words)
        {
            string replacement = new string('*', word.Length);
            text = text.Replace(word, replacement);
        }

        File.WriteAllText(text_file_path, text);
    }
}

