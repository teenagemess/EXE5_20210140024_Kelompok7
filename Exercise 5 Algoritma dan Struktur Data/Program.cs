using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_Algoritma_dan_Struktur_Data
{
    class Node
    {
        public char info;
        public Node next;
        public Node(char i, Node n)
        {
            info = i;
            next = n;
        }
    }
   
    class Queues
    {
        Node RAYNANDA;
        Node AQIYAS;

        public Queues()
        {
            
            RAYNANDA = null;
            AQIYAS = null;
        }
        public void insert(char element)
        {
            Node el;
            el = new Node(element, null);


            if (RAYNANDA == null)
            {
                RAYNANDA = el;
            }
            else
            {
                AQIYAS.next = el;
            }
            AQIYAS = el;
        }
        public int delete()
        {
            Node tmp;
            Console.WriteLine("\nThe element delete from the queue is " + RAYNANDA + "\n");

            tmp = RAYNANDA;
            RAYNANDA = RAYNANDA.next;

            if (RAYNANDA == null)
            {
                AQIYAS = null;
            }
            return tmp.info;
            
        }
        public void display()
        {
            Node RAYNANDA_position;
            RAYNANDA_position = RAYNANDA;

            if ((RAYNANDA_position == null) && (AQIYAS == null))
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("\nElements in the queue are...\n");

            while (RAYNANDA_position != AQIYAS)
            {
                Console.WriteLine(RAYNANDA_position.info);
                RAYNANDA_position = RAYNANDA_position.next;
            }
            if (RAYNANDA_position == AQIYAS)
            {
                Console.WriteLine(RAYNANDA_position.info);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter Character: ");
                                char c = Convert.ToChar(Console.ReadLine());
                                Console.WriteLine();
                                q.insert(c);
                            }
                            break;
                        case '2':
                            {
                                q.delete();
                            }
                            break ;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid Option!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered");
                }
            }
        }
    }
}
