using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BabenkoIV.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            // Если строка пустая, возвращаем её как есть
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            // 1. Разбиваем строку на слова по пробелам
            string[] words = value.Split(' ');

            // 2. Проходимся по каждому слову
            for (int i = 0; i < words.Length; i++)
            {
                // Если слово длиннее 1 символа (чтобы не трогать предлоги типа "и", "в", "на")
                if (words[i].Length > 1)
                {
                    // Берем последнюю букву слова
                    char lastLetter = words[i][words[i].Length - 1];

                    // Берем всё слово, кроме последней буквы
                    string restOfWord = words[i].Substring(0, words[i].Length - 1);

                    // Заменяем слово в массиве на новое (последняя буква + остаток)
                    words[i] = lastLetter + restOfWord;
                }
            }

            // 3. Склеиваем массив слов обратно в строку через пробел
            return string.Join(" ", words);
        }

    }
}
