using System.Diagnostics;

namespace Module_13_4
{
    internal class Program
    {
        #region Словарь (Dictionary <TKey, TValue>)
        //static void Main(string[] args)
        //{
        //    // Создадим словарь. Ключом будет строка, а значением - массив строк
        //    var cities = new Dictionary<string, string[]>(3 /* Размер (указывать необязательно))*/ );

        //    // Добавим новые значения
        //    cities.Add("Россия", new[] { "Москва", "Санкт-Петербург", "Волгоград" });
        //    cities.Add("Украина", new[] { "Киев", "Львов", "Николаев", "Одесса" });
        //    cities.Add("Беларусь", new[] { "Минск", "Витебск", "Гродно" });

        //    //  Посмотрим всё что есть в словаре
        //    foreach (var citiesByCountry in cities)
        //    {
        //        Console.Write(citiesByCountry.Key + ": ");
        //        foreach (var city in citiesByCountry.Value)
        //            Console.Write(city + " ");

        //        Console.WriteLine();
        //    }

        //    Console.WriteLine();

        //    // Теперь попробуем вывести значения по ключу
        //    var russianCities = cities["Россия"];
        //    Console.WriteLine("Города России:");
        //    foreach (var city in russianCities)
        //        Console.WriteLine(city);
        //}
        #endregion
        #region Изменение и удаление объектов по ключу
        //static void Main(string[] args)
        //{
        //    // Создадим словарь. Ключом будет строка, а значением - массив строк
        //    var cities = new Dictionary<string, string[]>();

        //    // Добавим новые значения
        //    cities.Add("Россия", new[] { "Москва", "Санкт-Петербург", "Волгоград" });
        //    cities.Add("Украина", new[] { "Киев", "Львов", "Николаев", "Одесса" });
        //    cities.Add("Беларусь", new[] { "Минск", "Витебск", "Гродно" });

        //    //  Посмотрим всё что есть в словаре
        //    foreach (var citiesByCountry in cities)
        //    {
        //        Console.Write(citiesByCountry.Key + ": ");
        //        foreach (var city in citiesByCountry.Value)
        //            Console.Write(city + " ");

        //        Console.WriteLine();
        //    }

        //    Console.WriteLine();

        //    // Теперь попробуем вывести значения по ключу
        //    var russianCities = cities["Россия"];
        //    Console.WriteLine("Города России:");
        //    foreach (var city in russianCities)
        //        Console.WriteLine(city);

        //    // !!!!!!NEW!!!!!!
        //    Console.WriteLine("\nРаздел NEW:\n");
        //    // изменение объекта
        //    cities["Россия"] = new[] { "Мурманск", "Казань" };

        //    // удаление по ключу
        //    cities.Remove("Беларусь");

        //    // Теперь попробуем вывести значения по ключу
        //    var russianCitiesNew = cities["Россия"];
        //    Console.WriteLine("Города России:");
        //    foreach (var city in russianCitiesNew)
        //        Console.WriteLine(city);
        //}
        #endregion
        #region 13.4.4
        ////  Объявим словарь с двумя значениями
        //private static Dictionary<string, Contact> PhoneBook = new Dictionary<String, Contact>()
        //{
        //    ["Игорь"] = new Contact(79990000000, "igor@example.com"),
        //    ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        //};

        //static void Main(string[] args)
        //{
        //    // Покажем весь список
        //    Console.WriteLine("Текущий список контактов: ");
        //    WriteAllContacts();

        //    // Попробуем добавить новый контакт, если такого ещё нет
        //    PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));

        //    //  Выведем обновлённый список
        //    Console.WriteLine("Обновленный список контактов: ");
        //    WriteAllContacts();

        //    //  Попробуем достать контакт для изменения данных
        //    if (PhoneBook.TryGetValue("Диана", out Contact contact))
        //        contact.PhoneNumber = 79990000001;

        //    // И покажем результат после изменения
        //    Console.WriteLine("Список после изменения: ");
        //    WriteAllContacts();
        //}

        //// Метод для вывода словаря на консоль
        //public static void WriteAllContacts()
        //{
        //    foreach (var contact in PhoneBook)
        //        Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
        //    Console.WriteLine();
        //}

        //// Класс был изменен. Поле Name мы убрали,
        //// так как оно теперь будет ключом
        //// для поиска значений в словаре
        //public class Contact // модель класса
        //{
        //    public Contact(long phoneNumber, String email) // метод-конструктор
        //    {
        //        PhoneNumber = phoneNumber;
        //        Email = email;
        //    }
        //    public long PhoneNumber { get; set; }
        //    public String Email { get; set; }
        //}
        #endregion
        #region Сортированный словарь (SortedDictionary <TKey, TValue>)
        //static void Main()
        //{
        //    // Создаем сортированный словарь
        //    SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();

        //    // Добавим несколько элементов в случайном порядке
        //    sortedDictionary.Add("zebra", 5);
        //    sortedDictionary.Add("cat", 2);
        //    sortedDictionary.Add("dog", 9);
        //    sortedDictionary.Add("mouse", 4);
        //    sortedDictionary.Add("programmer", 100);

        //    // Ищем собаку
        //    if (sortedDictionary.ContainsKey("dog"))
        //        Console.WriteLine("Нашли собаку");
        //    // Ищем зебру
        //    if (sortedDictionary.ContainsKey("zebra"))
        //        Console.WriteLine("Нашли зебру");
        //    // Ищем обезьяну
        //    if (sortedDictionary.ContainsKey("ape"))
        //        Console.WriteLine("Нашли обезьяну");

        //    Console.WriteLine();

        //    // Теперь посмотрим, кто у нас живёт и в каком порядке
        //    Console.WriteLine("Посмотрим всех:");

        //    foreach (KeyValuePair<string, int> p in sortedDictionary)
        //        Console.WriteLine($"{p.Key} = {p.Value}");
        //}
        #endregion
        #region 13.4.5
        //  Объявим  простой  словарь
        private static Dictionary<string, Contact> PhoneBook = new Dictionary<String, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };

        //  Объявим  сортированный  словарь
        private static SortedDictionary<string, Contact> PhoneBookSorted = new SortedDictionary<String, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Тестовое сообщение");

            // Запустим таймер
            var watchOne = Stopwatch.StartNew();
            // Выполним вставку
            PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));
            // Выведем результат
            Console.WriteLine($"Вставка в словарь: {watchOne.Elapsed.TotalMilliseconds} мс \n");

            // Запустим таймер
            var watchTwo = Stopwatch.StartNew();
            // Выполним вставку
            PhoneBookSorted.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));
            // Выведем результат
            Console.WriteLine($"Вставка в сортированный словарь: {watchTwo.Elapsed.TotalMilliseconds} мс \n");

            // Запустим таймер
            var watchThree = Stopwatch.StartNew();
            // Покажем весь список
            Console.WriteLine("Текущий список контактов: ");
            WriteAllContacts();
            // Выведем результат
            Console.WriteLine($"Вывод словаря в консоль: {watchThree.Elapsed.TotalMilliseconds} мс \n");

            // Запустим таймер
            var watchFour = Stopwatch.StartNew();
            // Покажем весь сортированный список
            Console.WriteLine("Текущий сортированный список контактов: ");
            WriteAllContactsSorted();
            // Выведем результат
            Console.WriteLine($"Вывод сортированного словаря в консоль: {watchFour.Elapsed.TotalMilliseconds} мс \n");
        }

        // Метод для вывода словаря на консоль
        public static void WriteAllContacts()
        {
            foreach (var contact in PhoneBook)
                Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
        }

        // Метод для вывода сортированного словаря на консоль
        public static void WriteAllContactsSorted()
        {
            foreach (var contact in PhoneBookSorted)
                Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
        }

        public class Contact // модель класса
        {
            public Contact(long phoneNumber, String email) // метод-конструктор
            {
                PhoneNumber = phoneNumber;
                Email = email;
            }
            public long PhoneNumber { get; set; }
            public String Email { get; set; }
        }
        #endregion
    }
}