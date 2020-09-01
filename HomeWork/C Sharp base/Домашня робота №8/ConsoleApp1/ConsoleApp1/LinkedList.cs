using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinkedList<T>
    {
        Node<T> head;
        Node<T> tail;
        public int Count { get; set; }
        public void AddTail(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Prev = tail;
            }
            tail = node;
            Count++;
        }
        public void AddInPosition(T data, int pos)
        {
            Node<T> node = new Node<T>(data);
            if (pos < 0 || pos > Count)
            {
                Console.WriteLine("Position out of range");
                return;
            }
            else
            {
                Node<T> tmp = new Node<T>(data);
                Node<T> current = head;
                int i = 0;
                while (current != null)
                {
                    if (pos == 0)
                    {
                        tmp.Next = current;
                        current.Prev = tmp;
                        head = tmp;
                        break;
                    }
                    if (i == pos)
                    {
                        tmp.Next = current;
                        tmp.Prev = current.Prev;
                        current.Prev = tmp;
                        tmp.Prev.Next = tmp;
                        break;
                    }
                    if (pos == Count)
                    {
                        AddTail(data);
                        Count--;
                        break;
                    }
                    i++;
                    current = current.Next;
                }
                Count++;
            }
        }
        public void AddRangeInPosition(ref LinkedList<T> list, int pos)
        {
            if (pos < 0 || pos > Count)
            {
                Console.WriteLine("Position out of range");
                return;
            }
            else
            {
                Node<T> current = head;
                int i = 0;
                while (current != null)
                {

                    if (pos == 0)
                    {
                        list.tail.Next = head;
                        head.Prev = list.tail;
                        head = list.head;
                        break;
                    }
                    if (i == pos)
                    {
                        list.tail.Next = current;
                        current.Prev.Next = list.head;
                        current.Prev = list.tail;
                        list.head.Prev = head;
                        break;
                    }
                    if (pos == Count)
                    {
                        tail.Next = list.head;
                        list.head.Prev = tail;
                        tail = list.tail;
                        break;
                    }
                    i++;
                    current = current.Next;
                }
                Count += list.Count;
            }
        }
        public void RemoveHead()
        {
            head = head.Next;
            if (head == null)
                tail = null;
            Count--;
        }
        public void RemoveInPosition(int pos)
        {
            if (pos < 0 || pos > Count)
            {
                Console.WriteLine("Position out of range");
                return;
            }
            else
            {
                Node<T> current = head;
                int i = 0;
                while (current != null)
                {
                    if (pos == 0)
                    {
                        RemoveHead();
                        break;
                    }
                    if (i == pos)
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                        Count--;
                        break;
                    }
                    if (pos == Count - 1)
                    {
                        tail = tail.Prev;
                        tail.Next = null;
                        Count--;
                        break;
                    }
                    i++;
                    current = current.Next;
                }
            }
        }
        public void RemoveRangeInPositiion(int pos, int amount)
        {
            if (pos < 0 || pos > Count)
            {
                Console.WriteLine("Position out of range");
                return;
            }
            else
            {
                if (pos + amount - 1 > Count - 1)
                {
                    Console.WriteLine("Amount out of range");
                    return;
                }
                Node<T> current = head;
                if (pos == 0)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        RemoveHead();
                    }
                }
                else
                {
                    for (int i = 0; i < amount; i++)
                    {
                        RemoveInPosition(pos);
                    }
                }
            }
        }
        public void Print()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write($"{current.Data} ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
