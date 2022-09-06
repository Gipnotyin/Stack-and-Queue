using System;

namespace Stack_and_Queue
{
    internal class Program
    {
        static void StackOrQueue(string str)
        {
            switch(str.ToLower())
            {
                case "stack":
                    stack();
                    break;
                case "queue":
                    queue();
                    break;
                default:
                    Console.WriteLine("Увы, нет такой команды :(");
                    break;
            }
        }
        static void stack()
        {
            Console.Write("Введите размер стека: ");
            int size = int.Parse(Console.ReadLine());
            Stack stack = new Stack(size);
            bool flag = true;
            do
            {
                Console.WriteLine("Хотите вытащить из стека или положить? (0/1)");
                string str = Console.ReadLine();
                if (str == "0")
                    stack.Pop();
                else
                {
                    Console.Write("Введите число: ");
                    int number = int.Parse(Console.ReadLine());
                    stack.Push(number);
                }
                Console.WriteLine("Хотите продолжить ввод?(y/n)");
                str = Console.ReadLine();
                flag = (str == "y") ? true : false;
            } while (flag == true);
        }
        static void queue()
        {
            Console.Write("Введите размер очереди: ");
            int size = int.Parse(Console.ReadLine());
            Queue queue = new Queue(size);
            bool flag = true;
            do
            {
                Console.WriteLine("Хотите вытащить из очереди или положить? (0/1)");
                string str = Console.ReadLine();
                if (str == "0")
                    queue.Back();
                else
                {
                    Console.Write("Введите число: ");
                    int number = int.Parse(Console.ReadLine());
                    queue.Push(number);
                }
                Console.WriteLine("Хотите продолжить ввод?(y/n)");
                str = Console.ReadLine();
                flag = (str == "y") ? true : false;
            } while (flag == true);
        }
        static void Main(string[] args)
        {
            bool flag = true;
            string str = String.Empty;
            do
            {
                Console.Write("Что вы хотите выбрать? (stack/queue): ");
                str = Console.ReadLine();
                StackOrQueue(str);
            } while (flag == true);
        }
    }
}
