// Дана строка символов. Признак конца строки — символ 'n' (переход на новую строку). 
// Строка состоит из слов, которые отделены друг от друга пробелами. Вывести самое длинное слово и его порядковый номер.

Console.Write("Введите текст: ");
string text = Console.ReadLine();
findMin(text); // вызов функции

void findMin(string txt) { // функция поиска самого длинного слова в строке
    int temp = 0;
    string[] words = text.Split(' '); // разбиение строки по словам 
    string maxText = words[0];
        for (int i = 0; i < words.Length; i++)
        {
            if(maxText.Length < words[i].Length) {
                maxText = words[i];
            }
        }
        for (int i = 0; i < words.Length; i++)
        {
            if(maxText == words[i]) {
                temp = i + 1;
                Console.WriteLine($"Самое длинное слово в строке под номером {temp}: {maxText}");
            } 
        }
        
}
