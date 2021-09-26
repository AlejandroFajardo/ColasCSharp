using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListasTipoCola1
{
    class Cola
    {
        /// <summary>
        /// todo esto esta documentado en pilas
        /// </summary>
        class Node
        {
            public int info;
            public Node next;
        }

        private Node head, last;

        public Cola()
        {
            head = null;
            last = null;
        }

        public bool isEmpty()
        {
            if (head == null)
                return true;
            else
                return false;
        }

        public void addNode(int info)
        {
            Node aux;
            aux = new Node();
            aux.info = info;
            aux.next = null;
            if (isEmpty())
            {
                head = aux;
                last = aux;
            }
            else
            {
                last.next = aux;
                last = aux;
            }
        }

        public int deleteNode()
        {
            if (!isEmpty())
            {
                int information = head.info;
                if (head == last)
                {
                    head = null;
                    last = null;
                }
                else
                {
                    head = head.next;
                }
                return information;
            }
            else
                return int.MaxValue;
        }

        public void print()
        {
            Node reco = head;
            Console.WriteLine("Listado de todos los elementos de la cola.");
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Cola cola1 = new Cola();
            cola1.addNode(5);
            cola1.addNode(10);
            cola1.addNode(50);
            cola1.print();
            Console.WriteLine("Extraemos uno de la cola:" + cola1.deleteNode());
            cola1.print();
            Console.ReadKey();
        }
    }
}