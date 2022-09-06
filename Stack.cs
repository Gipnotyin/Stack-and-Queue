using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    public class Stack
    {
        private int size;
        private int[] stack;
        private int TOP;
        public Stack()
        {
            size = 10;
            stack = new int[size];
            TOP = -1;
        }
        public Stack(int size)
        {
            this.size = size;
            stack = new int[size];
            TOP = -1;
        }
        public void Push(int element)
        {
            if (TOP == size - 1)
            {
                Console.WriteLine("Стек переполнен!");
            }
            else
            {
                stack[++TOP] = element;
            }
        }
        public void Pop()
        {
            if (TOP >= 0)
            {
                Console.WriteLine($"Число из стека: {stack[TOP--]}");
            }
            else
            {
                Console.WriteLine("Стек пустой!!!");
            }
        }
    }
}
