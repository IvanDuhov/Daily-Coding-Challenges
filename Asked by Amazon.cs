using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add(3); list.Add(4); list.Add(-7); list.Add(5); list.Add(-6); list.Add(6);

            for (int i = 0; i < list.Lenght - 1; i++)
            {
                ListNode n2 = ListNodeIndex(list, i);
                int sum = 0;

                int[] markedNumbers = new int[list.Lenght];
                byte index = 0;

                for (int j = i; j < list.Lenght; j++)
                {
                    sum += int.Parse(ListNodeIndex(list, j).Data.ToString());

                    markedNumbers[index] = int.Parse(ListNodeIndex(list, j).Data.ToString());
                    index++;

                    if (sum == 0)
                    {
                        byte countOfElementsToBeRemoved = byte.Parse((j - i + 1).ToString());

                        while (countOfElementsToBeRemoved != 0)
                        {
                            list.RemoveNode(ListNodeIndex(list, i).Data);
                            countOfElementsToBeRemoved--;
                        }
                    }
                }
            }

            ListNode head = list.FirstNode;

            while (head != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }
        }

        public static ListNode ListNodeIndex(List list, int index)
        {
            ListNode head = list.FirstNode;

            for (int i = 0; i < list.Lenght; i++)
            {
                if (i == index)
                {
                    return head;
                }
                else if (head.Next == null)
                {
                    return null;
                }
                else
                {
                    head = head.Next;
                }
            }

            return head;
        }
    }

    class ListNode
    {
        private Object data;
        private ListNode next;

        public Object Data { get { return data; } set { data = value; } }
        public ListNode Next { get { return next; } set { next = value; } }

        public ListNode(Object data)
        {
            this.data = data;
            next = null;
        }

        public ListNode(Object item, ListNode nextNode)
        {
            data = item;
            next = nextNode;
        }
    }

    class List
    {
        private ListNode first;
        private ListNode last;

        public ListNode FirstNode { get { return first; } }
        public ListNode LastNode { get { return last; } }
        public int Lenght { get { return Count(); } }

        public List()
        {
            first = last = null;
        }

        public bool IsEmpty()
        {
            if (first == null)
            {
                return true;
            }

            return false;
        }

        public void Add(Object item)
        {
            if (IsEmpty())
            {
                first = last = new ListNode(item);
            }
            else
            {
                last = last.Next = new ListNode(item);
            }
        }

        public int Count()
        {
            int result = 0;

            ListNode n;
            n = first;

            while (n != null)
            {
                result++;
                n = n.Next;
            }

            return result;
        }

        public void RemoveNode(Object item)
        {
            if (first.Data == item)
            {
                first = first.Next;
                return;
            }

            ListNode n = first.Next;
            ListNode previous = first;

            while (n != null)
            {
                if (n.Data.Equals(item))
                {
                    previous.Next = n.Next;
                    break;
                }
                else
                {
                    previous = previous.Next;
                    n = n.Next;
                }
            }
        }
    }
}