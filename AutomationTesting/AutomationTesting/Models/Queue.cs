using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Models
{
    public class Queue
    {
        int position;
        int[] queue;

        public Queue(int lenghtOfTheQueue) 
        {
           position= 0;
           queue= new int[lenghtOfTheQueue];
        }
        public void Enqueue(int value)
        {
          queue[position] = value;
            position++;
        }
        public void Unenqueue()
        {
            int value = queue[0];

            for(int i = 0; i < queue.Length-1; i++)
            {
                queue[i] = queue[i + 1];
            }
            Console.WriteLine(value);
        } 
    }
}
