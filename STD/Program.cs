
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
        {
            Console.WriteLine("Нет слов в введённом тексте.");
            return;
        }

        int minLength = int.MaxValue;
        int maxLength = int.MinValue;

        foreach (string word in words)
        {
            int length = word.Length;
            if (length < minLength)
            {
                minLength = length;
            }
            if (length > maxLength)
            {
                maxLength = length;
            }
        }

        Console.WriteLine($"Длина самого короткого слова: {minLength}");
        Console.WriteLine($"Длина самого длинного слова: {maxLength}");
    

