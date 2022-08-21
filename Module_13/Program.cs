// ArrayList
using System.Collections;
using System.Text;

namespace Module_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Необобщенные коллекции: Коллекция - ArrayList
            //var list = new ArrayList() { 2, "Lol" };

            //list.Add(2.3); // добавим double
            //list.Add(55); // добавим int
            //list.AddRange(new string[] { "Hello", "world" }); // добавим массив

            //// выведем, что получилось
            //foreach (var o in list)
            //    Console.WriteLine(o);

            //Console.WriteLine();

            //// добавим ещё строку
            //list.Add("again!");

            //// отрежем часть длиной в 3 элемента, начиная с четвертого
            //var slice = list.GetRange(4, 3);

            //// выведем результат
            //foreach (var o in slice)
            //    Console.WriteLine(o);
            #endregion
            #region Необобщенные коллекции: Коллекция - ArrayList (Доступ к элементам ArrayList)
            //// Объявим ArrayList с элементами разных типов
            //var arlist = new ArrayList()
            //{
            //    1,
            //    "Андрей",
            //    300,
            //    4.5f
            //};

            //// Получим первый элемент по индексу
            //int firstElement = (int)arlist[0];
            //Console.WriteLine(firstElement);

            //string secondElement = (string)arlist[1];
            //Console.WriteLine(secondElement);
            ///* int secondElement = (int) arlist[1]; Ошибка (пытаемся привести строку к числу) */

            //// используем ключевое слово var, чтобы не приводить к типу
            //var firstElementVar = arlist[0]; // получим запакованный объект
            //var secondElementVar = arlist[1];
            ///* var fifthElement = arlist[5]; Error: Index out of range (обращение по несуществующему индексу) */

            //// Обновление элементов по индексу
            //arlist[0] = "Диана";
            //arlist[1] = 100;
            //Console.WriteLine(arlist[0]);
            //Console.WriteLine(arlist[1]);
            #endregion
            #region Задание 13.2.5
            //var months = new[]
            //{
            //    "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            //};

            //var numbers = new[]
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            //};

            //// инициализация ArrayList
            //var combinedList = new ArrayList();

            ////  пробегаемся по массиву чисел
            //foreach (var number in numbers)
            //{
            //    // добавляем в ArrayList строку месяца (начинаем с нулевого по индексу)
            //    combinedList.Add(months[number - 1]);

            //    // добавляем его порядковый номер
            //    combinedList.Add(number);
            //}

            //foreach (var value in combinedList)
            //    Console.WriteLine(value);
            #endregion
            #region Задание 13.2.6
            // Объявим ArrayList с элементами разных типов
            var arrayList = new ArrayList()
            {
                1,
                "Андрей ",
                "Сергей ",
                300,
            };

            // переменная для хранения суммы
            int sum = 0;

            // переменная для хранения текста.
            // Можно было бы использовать String, но в случае когда необходимо выполнять много
            // операций с одной строкой - лучше использовать класс StringBuilder
            StringBuilder text = new StringBuilder();

            // проходим список и проверяем элементы на соответствие типу
            foreach (var element in arrayList)
            {
                //   если целое число - увеличиваем счётчик
                if (element is int)
                {
                    sum += (int)element;
                }

                // если строка - добавляем текст из неё
                if (element is string s)
                {
                    text.Append(element);
                }
            }

            // результат
            var result = new ArrayList() { sum, text.ToString() };

            // вывод
            foreach (var elem in result)
            {
                Console.WriteLine(elem);
            }
            #endregion
        }
    }
}