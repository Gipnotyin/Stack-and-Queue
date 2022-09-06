using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    public class Queue
    {
        private int size;
        private int[] queue;
        private int TOP;
        private int LOWER;
        public Queue()
        {
            size = 10;
            queue = new int[size];
            TOP = 0;
            LOWER = 0;
        }
        public Queue(int size)
        {
            this.size = size;
            queue = new int[size];
            TOP = 0;
            LOWER = 0;
        }
        public void Push(int number)
        {
            if ((LOWER + 1) % size == TOP) 
                Console.WriteLine("Очередь полна!!!");
            else
            {
                queue[LOWER] = number;
                LOWER = (LOWER + 1) % size;
            }
        }
        public void Back()
        {
            if(TOP!=LOWER)
            {
                Console.WriteLine($"Значение из очереди: {queue[TOP]}");
                TOP = (TOP + 1) % size;
            }
            else
                Console.WriteLine("Очередь пуста!!");
        }
    }
}
