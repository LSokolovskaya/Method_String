internal class Program
{
    static void Main(string[] args)
    {
        // Task1();
        Task2();
    }
    #region Задача1
    // 1. Ввести строку. Если эта равна “hschool”, вывести true. В противном случае false. Добавить проверки для строк. Удалить лишние пробелы
    static void Task1()
    {
        string text = Console.ReadLine();
        if (!string.IsNullOrEmpty(text))
        {
            if (text is string)
            {
                text = text.Trim();
                System.Console.WriteLine($"{text} = {MethodHschool(text)}");
            }
        }
    }
    static bool MethodHschool(string text)
    {
        if (text != "hschool")
        {
            return false;
        }
        else
        {
            return true;
        }

    }
    #endregion
    #region Задача2
    // 2. Ввести строку. Проверить является ли это число или строка. Если число, то выяснить, четное или нет. Если это строка то преобразовать строку в массив, где каждый символ – один элемент массива
    // ‘hschool’ => [‘h’, ‘s’, ‘c’, ‘h’, ‘o’, ‘o’, ‘l’]
    static void Task2()
    {
        System.Console.WriteLine("Введите строку");
        string? text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            System.Console.WriteLine(MethodChetnoe(number));
        }
        if (MethodHschool(text))
        {
            string[] textArray = text.Split("");
            text = string.Join(",", textArray);
            text = text.TrimEnd(',');
            System.Console.WriteLine(text);
        }
    }
    static string MethodChetnoe(int number)
    {
        string result = number % 2 == 0 ? "Число четное" : "Число нечетное";
        return result;
    }
    #endregion
    #region Задача3
    #endregion
}
// 3. Преобразовать строку ‘Full сStaCK DevELoper’ в массив вида [‘full, ‘stack’, ‘developer’]
// 4. Ввести строку. Проверить на isNaN. Если число, то ошибка ввода. Если это строка то узнать какая у нее длина. Привести к одному регистру, убрать лишние пробелы
// 5. ‘HTML JavaScript PHP’ преобразовать в "HTML-JAVASCRIPT-PHP"
// 6. Ввести строку. Проверить является ли это число или строка. Если число, то
// ошибка ввода. Если это строка то первый символ поставить в верхний регистр.
// Убрать лишние пробелы
// 7. На вход программе подаётся строка. Замените все @ на '!' с помощью
// глобального поиска и замены (2 способа)
// 8. Данастрока'aaabbbccc'.Вырежитеизнееслово'bbb'
// 9. На вход программе подается переменная date, в котрой лежит дата в формате
// 'xxxx-xx-xx'. Преобразуйте эту дату в формат 'xx/xx/xxxx’. (reverse)