﻿using System;
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
            if (RAYNANDA == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return ;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[RAYNANDA] + "\n");

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
        public void display()
        {
            int RAYNANDA_position = RAYNANDA;
            int AQIYAS_position = AQIYAS;
            //checks queue empty
            if (AQIYAS == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are................\n");
            if (RAYNANDA_position <= AQIYAS_position)
            {
                //traverse queue until the last element
                while (RAYNANDA_position <= AQIYAS_position)
                {
                    Console.Write(queue_array[RAYNANDA_position] + "   ");
                    RAYNANDA_position++;
                }
                Console.WriteLine();
            }
            else
            {
                //traverse queue until the last position array
                while (RAYNANDA_position <= max - 1)
                {
                    Console.WriteLine(queue_array[RAYNANDA_position] + "   ");
                    RAYNANDA_position++;
                }
                //set raynanda position to the frist element of array
                RAYNANDA_position = 0;
                //traverse array till last element present in the queue
                while(RAYNANDA_position <= AQIYAS_position)
                {
                    Console.Write(queue_array[RAYNANDA_position] + "   ");
                    RAYNANDA_position++;
                }
                Console.WriteLine();
            }
        }
    }
}
