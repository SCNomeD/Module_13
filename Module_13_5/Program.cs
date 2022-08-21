using System.Collections.Concurrent;

namespace Module_13_5
{
    #region Stack<T> (Стэк - последний зашел -> первый вышел)
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Push() для добавления элемента в коллекцию:
    //        var stack = new Stack<string>();

    //        stack.Push("word");
    //        stack.Push("word1");
    //        //   в стеке; word, word1

    //        //Pop() извлекает и возвращает первый (он же последний добавленный) элемент из стека:
    //        // достанем  слово word1.  word осталось в стеке
    //        var element = stack.Pop();

    //        //Также есть метод для просмотра первого элемента без его удаления — Peek():
    //        // просмотрим  слово word.  оба слова остались в стеке
    //        var element2 = stack.Peek();
    //    }
    //}
    #endregion
    #region ScreenCast
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //  создадим числовой стек
    //        Stack<int> numbers = new Stack<int>();

    //        numbers.Push(3); // в стеке 3
    //        numbers.Push(5); // в стеке 5, 3
    //        numbers.Push(8); // в стеке 8, 5, 3

    //        Console.WriteLine("Элементы числового стека: ");
    //        foreach (var number in numbers)
    //            Console.WriteLine(number);

    //        Console.WriteLine($"Извлекаем верхний элемент из стека: {numbers.Pop()}");
    //        //  в стеке остались числа 5 и 3

    //        Console.WriteLine();

    //        // создадим стек объектов
    //        Stack<Person> persons = new Stack<Person>();
    //        persons.Push(new Person() { Name = "Иван" });
    //        persons.Push(new Person() { Name = "Сергей" });
    //        persons.Push(new Person() { Name = "Анна" });

    //        Console.WriteLine("Элементы стека объектов: ");
    //        foreach (Person p in persons)
    //            Console.WriteLine(p.Name);

    //        Console.WriteLine($"Извлекаем верхний элемент из стека объектов: {persons.Pop().Name}");
    //    }
    //}

    //class Person
    //{
    //    public string Name { get; set; }
    //}
    #endregion
    #region 13.5.4
    //class Program
    //{
    //    public static Stack<string> words = new Stack<string>();

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
    //        Console.WriteLine("Введите \"pop\" и нажмите Enter, чтобы удалить из стека последний добавленный элемент.");
    //        Console.WriteLine("Введите слово \"peek\"и нажмите Enter, посмотреть последний добавленный элемент в стек.");
    //        Console.WriteLine();

    //        while (true)
    //        {
    //            var input = Console.ReadLine();

    //            switch (input)
    //            {
    //                //   если  команда pop - пробуем достать элемент
    //                case "pop":
    //                    words.TryPop(out string popResult);
    //                    break;
    //                //   если  команда peek - пробуем  просмотреть элемент
    //                case "peek":
    //                    words.TryPeek(out string peekResult);
    //                    break;
    //                default:
    //                    // если ни одна из команд не распознана - простов стек добавляем то что введено
    //                    words.Push(input);
    //                    break;
    //            }

    //            Console.WriteLine();
    //            Console.WriteLine("В стеке:");

    //            foreach (var word in words)
    //            {
    //                Console.WriteLine(" " + word);
    //            }
    //        }
    //    }
    //}
    #endregion
    #region Queue (Необобщенная очередь) и Queue<T> (обобщенная очередь)
    //class Program
    //{
    //    static void Main()
    //    {
    //        // создаем очередь
    //        Queue<int> q = new Queue<int>();

    //        // добавляем в нее целые числа от 0 до 10
    //        for (int i = 0; i <= 10; i++)
    //        {
    //            q.Enqueue(i);
    //            Console.WriteLine($"{i} зашёл в очередь");
    //        }

    //        // Посмотрим, кто первый в очереди
    //        Console.WriteLine($"Первый элемент:   {q.Peek()}");

    //        // Обратите внимание, после  вызова Peek() элемент остается в очереди

    //        //  Посмотрим всю очередь
    //        Console.WriteLine("Элементы в очереди");
    //        foreach (int i in q)
    //            Console.Write(i + " ");

    //        Console.WriteLine();
    //        Console.WriteLine($"В очереди  {q.Count} элементов");

    //        // обработаем очередь -
    //        // достанем из неё элементы один за другим
    //        var queueLength = q.Count;
    //        for (int i = 0; i < queueLength; i++)
    //            Console.WriteLine($"{q.Dequeue()} вышел из очереди");

    //        //  Посмотрим, сколько элементов осталось
    //        Console.WriteLine($"В очереди  {q.Count} элементов");
    //    }
    //}
    #endregion
    #region 13.5.8
    //class Program
    //{
    //    // объявим потокобезопасную очередь (полностью идентична обычной очереди, но
    //    // позволяет безопасный доступ из разных потоков)
    //    public static ConcurrentQueue<string> words = new ConcurrentQueue<string>();

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
    //        Console.WriteLine("Введите слово \"peek\" и нажмите Enter, чтобы посмотреть крайний элемент в очереди.");
    //        Console.WriteLine();

    //        // запустим обработку очереди в отдельном потоке
    //        StartQueueProcessing();

    //        while (true)
    //        {
    //            var input = Console.ReadLine();

    //            // если введена нужная нам команда - смотрим, кто крайний в очереди
    //            if (input == "peek")
    //            {
    //                if (words.TryPeek(out var elem))
    //                    Console.WriteLine(elem);
    //            }
    //            else
    //            {
    //                // если не введена - ставим элемент в очередь, как и обычно
    //                words.Enqueue(input);
    //            }
    //        }
    //    }

    //    // метод, который обрабатывает и разбирает нашу очередь в отдельном потоке
    //    // ( для выполнения задания изменять его не нужно )
    //    static void StartQueueProcessing()
    //    {
    //        new Thread(() =>
    //        {
    //            Thread.CurrentThread.IsBackground = true;

    //            while (true)
    //            {
    //                Thread.Sleep(5000);
    //                if (words.TryDequeue(out var element))
    //                    Console.WriteLine("======>  " + element + " прошел очередь");
    //            }

    //        }).Start();
    //    }
    //}
    #endregion
    #region LinkedList<T> (связанный список) ScreenCast
    class Program
    {
        // объявим список в виде статической переменной
        public static LinkedList<string> LinkedList = new LinkedList<string>();

        static void Main()
        {
            // Добавим несколько элементов
            LinkedList.AddFirst("Лиса");
            LinkedList.AddFirst("Волк");
            LinkedList.AddFirst("Заяц");
            var mouse = LinkedList.AddFirst("Мышь");

            GoOnwards(); //   Прямой проход списка
            GoBackwards(); // Обратный проход списка

            // Вставка нового элемента
            LinkedList.AddAfter(mouse, "Медведь");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Выведем список ещё раз после вставки");
            Console.WriteLine();


            GoOnwards(); //   Прямой проход списка
            GoBackwards(); // Обратный проход списка
        }

        static void GoOnwards()
        {
            LinkedListNode<string> node;

            Console.WriteLine("Элементы коллекции в прямом направлении: ");
            for (node = LinkedList.First; node != null; node = node.Next)
                Console.Write(node.Value + " ");
        }

        static void GoBackwards()
        {
            LinkedListNode<string> node;

            Console.WriteLine("\n\nЭлементы коллекции в обратном направлении: ");
            for (node = LinkedList.Last; node != null; node = node.Previous)
                Console.Write(node.Value + " ");
        }
    }
    #endregion
}