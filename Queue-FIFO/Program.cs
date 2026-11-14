using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_FIFO
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Queue(FIFO) using the Enqueue,Dequeue,Top */

            Queue<string> queue = new Queue<string>();


            queue.Enqueue("Ali");
            queue.Enqueue("Hanif");
            queue.Enqueue("Rahim");
            queue.Enqueue("Hammad");
            queue.Enqueue("Salman");
            queue.Enqueue("Ihsan");
            queue.Enqueue("Dawar");
            queue.Enqueue("Ahmad");
            queue.Enqueue("IQbal");
            queue.Enqueue("Fahad");
            queue.Enqueue("Fawad");
            queue.Enqueue("Saqib");

            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();


            foreach (string names in queue)
            {
                Console.WriteLine(names);

                //Console.WriteLine(queue.Peek());

            }

            


        }
    }
}
