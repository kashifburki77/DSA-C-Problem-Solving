using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Social Name following LIFO (Last In First Out) Method */

            Stack<string> stack = new Stack<string>();

            stack.Push("Rahim");
            stack.Push("Kashif");
            stack.Push("Salman");
            stack.Push("Hammad");
            stack.Push("Hammza Ali");
            stack.Push("Hanif");
            stack.Push("Fida");
            stack.Push("NaqibUllah");
            stack.Push("Hizbullah");
            stack.Push("Atiq"); 
            stack.Push("Amjad");
            stack.Push("Ayub khan");
            stack.Push("Naseer Khan");

           
            stack.Pop();
            stack.Pop();


            //Console.WriteLine(stack.Peek());


            //string topobject = stack.Pop();
            //Console.WriteLine(topobject);


            foreach (string name in stack)
            {
                Console.WriteLine(name);
            }
        }
    }
}
