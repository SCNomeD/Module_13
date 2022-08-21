using System.Collections;

namespace Module_13_3
{
    #region Обобщенные коллекции
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //  создаём пустой список с типом данных Contact
    //        var phoneBook = new List<Contact>();

    //        // добавляем контакты
    //        phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
    //        phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));

    //        // проверяем, что добавилось в список
    //        foreach (var contact in phoneBook)
    //            Console.WriteLine(contact.Name + ": " + contact.PhoneNumber + " (" + contact.Email + ")");
    //    }
    //}
    //public class Contact // модель класса
    //{
    //    public Contact(string name, long phoneNumber, String email) // метод-конструктор
    //    {
    //        Name = name;
    //        PhoneNumber = phoneNumber;
    //        Email = email;
    //    }

    //    public String Name { get; }
    //    public long PhoneNumber { get; }
    //    public String Email { get; }
    //}
    #endregion
    #region 13.3.4
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //  создаём пустой список с типом данных Contact
    //        var phoneBook = new List<Contact>();

    //        // добавляем контакты
    //        phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
    //        phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));

    //        // проверяем, что добавилось в список
    //        foreach (var contact in phoneBook)
    //            Console.WriteLine(contact.Name + ": " + contact.PhoneNumber + " (" + contact.Email + ")");
    //    }
    //    private static void AddUnique(Contact newContact, List<Contact> phoneBook)
    //    {
    //        bool alreadyExists = false;

    //        // пробегаемся по списку и смотрим, есть ли уже с таким именем
    //        foreach (var contact in phoneBook)
    //        {
    //            if (contact.Name == newContact.Name)
    //            {
    //                //  если вдруг находим  -  выставляем флаг и прерываем цикл
    //                alreadyExists = true;
    //                break;
    //            }
    //        }

    //        if (!alreadyExists)
    //            phoneBook.Add(newContact);

    //        //  сортируем список по имени
    //        phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

    //        foreach (var contact in phoneBook)
    //            Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
    //    }
    //}
    //public class Contact // модель класса
    //{
    //    public Contact(string name, long phoneNumber, String email) // метод-конструктор
    //    {
    //        Name = name;
    //        PhoneNumber = phoneNumber;
    //        Email = email;
    //    }

    //    public String Name { get; }
    //    public long PhoneNumber { get; }
    //    public String Email { get; }
    //}
    #endregion
    #region 13.3.5
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var months = new List<string>()
    //        {
    //            "Jan", "Feb", "Mar", "Apr", "May"
    //        };

    //        var missing = new ArrayList()
    //        {
    //            1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
    //        };

    //        GetMissing(months, missing);
    //    }
    //    private static void GetMissing(List<string> months, ArrayList missing)
    //    {
    //        // инициализируем массив для 7 нужных нам недостающих элементов
    //        var missedArray = new string[7];

    //        // извлекаем эти элементы из ArrayList, и копируем в массив
    //        missing.GetRange(4, 7).CopyTo(missedArray);

    //        // Добавляем наш массив в конец списка
    //        months.AddRange(missedArray);

    //        // смотрим, что получилось
    //        foreach (var month in months)
    //            Console.WriteLine(month);
    //    }
    //}
    #endregion
    #region HashSet + Метод UnionWith
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Создаем массив строк
    //        string[] names =
    //            {
    //            "Игорь",   // повторяющееся значение
    //            "Андрей",
    //            "Васиий",
    //            "София",
    //            "Елена",
    //            "Анна",
    //            "Игорь"  //  повторяющееся значение
    //            };

    //        // Выведем длину массива в консоль
    //        Console.WriteLine("Длина массива " + names.Length);
    //        Console.WriteLine();
    //        Console.WriteLine("Данные в массиве");
    //        foreach (var n in names)
    //            Console.WriteLine(n);
    //        Console.WriteLine();

    //        // Создаем хэш-сет, передавая в конструктор наш массив
    //        HashSet<string> hSet = new HashSet<string>(names);
    //        // Посчитаем объекты в массиве
    //        Console.WriteLine("Длина хэш-сета " + hSet.Count);
    //        Console.WriteLine();
    //        // Выведем все элементы в консоль и посмотрим, есть ли дубликаты
    //        Console.WriteLine("Элементы в хэшсете:");
    //        foreach (var n in hSet)
    //            Console.WriteLine(n);

    //        #region Метод UnionWith
    //        //Метод объединения коллекции с хэш-сет
    //        hSet.UnionWith(new[] { "Дмитрий", "Сергей", "Игорь" });
    //        Console.WriteLine();
    //        Console.WriteLine("Элементы после объединения с новой коллекцией:");
    //        foreach (var n in hSet)
    //            Console.WriteLine(n);
    //        #endregion
    //    }
    //}
    #endregion
    #region Метод ExceptWith(otherCollection) 
    //class Program
    //{
    //    static void Main()
    //    {
    //        // Создадим два множества
    //        SortedSet<char> lettersOne = new SortedSet<char>();
    //        SortedSet<char> lettersTwo = new SortedSet<char>();

    //        //  Добавим элементы в первую
    //        lettersOne.Add('A');
    //        lettersOne.Add('B');
    //        lettersOne.Add('C');
    //        lettersOne.Add('Z');

    //        // выведем
    //        PrintCollection(lettersOne, "Первая коллекция: ");

    //        // Добавим элементы во вторую
    //        lettersTwo.Add('X');
    //        lettersTwo.Add('Y');
    //        lettersTwo.Add('Z');

    //        // выведем
    //        PrintCollection(lettersTwo, "Вторая коллекция");

    //        //  Выполним вычитание множеств
    //        lettersOne.ExceptWith(lettersTwo);

    //        // Выведем результат
    //        PrintCollection(lettersOne, "Результат вычитания");
    //    }

    //    static void PrintCollection(SortedSet<char> ss, string s)
    //    {
    //        Console.WriteLine(s);
    //        foreach (char ch in ss)
    //            Console.Write(ch + " ");
    //        Console.WriteLine("\n");
    //    }
    //}
    #endregion
    #region Метод SymmetricExceptWith(otherCollection) 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var hSet = new HashSet<string>()
    //       {
    //           "Иван", "Дмитрий"
    //       };

    //        hSet.SymmetricExceptWith(new[] { "Дмитрий", "Сергей", "Игорь" });

    //        Console.WriteLine("Элементы после объединения с новой коллекцией:");

    //        foreach (var n in hSet)
    //            Console.WriteLine(n);
    //    }
    //}
    #endregion
    #region 13.3.10/13.3.11
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Сохраняем предложение в строку
    //        var sentence =
    //            "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

    //        // сохраняем в массив char
    //        var characters = sentence.ToCharArray();

    //        var symbols = new HashSet<char>();

    //        // добавляем во множество. Сохраняются только неповторяющиеся символы
    //        foreach (var symbol in characters)
    //            symbols.Add(symbol);

    //        // Выводим результат
    //        Console.WriteLine(symbols.Count);

    //        #region 13.3.11
    //        // сохраняем знаки препинания в массив Char
    //        var signs = new[] { ',', ' ', '.' };

    //        // сохраняем числовые символы в массив Char
    //        var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    //        //  Проверяем, есть ли цифры
    //        bool containsNumbers = symbols.Overlaps(numbers);
    //        Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

    //        // Отбрасываем знаки препинания и заново считаем
    //        symbols.ExceptWith(signs);
    //        Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");
    //        #endregion
    //    }
    //}
    #endregion
    #region 13.3.12
    class Program
    {
        static void Main(string[] args)
        {
            // Запускаем бесконечный цикл
            while (true)
            {
                Console.WriteLine("Введите текст:");

                // Сохраняем предложение в строку
                var sentence = Console.ReadLine();
                // сохраняем в массив char
                var characters = sentence.ToCharArray();

                var symbols = new HashSet<char>();

                // добавляем во множество. Сохраняются только неповторяющиеся символы
                foreach (var symbol in characters)
                    symbols.Add(symbol);

                // Выводим результат
                Console.WriteLine($"Всего {symbols.Count} уникальных символов");

                // сохраняем знаки препинания в массив Char
                var signs = new[] { ',', ' ', '.' };

                // сохраняем числовые символы в массив Char
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                //  Проверяем, есть ли цифры
                bool containsNumbers = symbols.Overlaps(numbers);
                Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

                // Отбрасываем знаки препинания и заново считаем
                symbols.ExceptWith(signs);
                Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");

                Console.WriteLine();
            }
        }
    }
    #endregion
}