using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_Algoritma_dan_Struktur_Data
{
    class Queues
    {
        int RAYNANDA, AQIYAS, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            
            RAYNANDA = -1;
            AQIYAS = -1;
        }
        public void insert(int element)
        {
            if ((RAYNANDA == 0 && AQIYAS == max -1) || (RAYNANDA == AQIYAS + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            if (RAYNANDA == -1)
            {
                RAYNANDA = 0;
                AQIYAS = 0;
            }
            else
            {
                if (AQIYAS == max - 1)
                    AQIYAS = 0;
                else
                    AQIYAS = AQIYAS + 1;
            }
            queue_array[AQIYAS] = element;
        }
        public void remove()
        {
            //Checks queue is empty
            if (AQIYAS == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return ;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[RAYNANDA] + "\n");
            if (RAYNANDA == AQIYAS)
            {
                //Checks queue has one element
                if (RAYNANDA == AQIYAS)
                {
                    RAYNANDA = -1;
                    AQIYAS = -1;
                }
                else
                {
                    if (RAYNANDA == max - 1)
                        RAYNANDA = 0;
                    else
                        RAYNANDA = RAYNANDA + 1;
                }
            }
        }
    }
}
