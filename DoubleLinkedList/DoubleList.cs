using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class DoubleList : Node
    {
        public Node First { get; set; }
        public Node Last { get; set; }
        public int Length { get; set; }

        public DoubleList()
        {
            First = null;
            Last = null;
            Length = 0;
        }
        public DoubleList(int value) : base(value)
        {
            Node firstNode = new Node(value);
            First = firstNode;
            Last = firstNode;
            Length = 1;
        }

        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (First == null)
            {
                First = newNode;
                newNode.Prev = null;
            }
            else
            {
                Last.Next = newNode;
                newNode.Prev = Last;
            }

            Last = newNode;
            newNode.Next = null;
            Length++;
        }

        public bool DeleteByValue(int value)
        {
            if (Length > 0)
            {
                Node thisNode = First;
                for (int i = 0; i < Length; i++)
                {
                    if (thisNode.Value == value)
                    {
                        if (First == thisNode && Last == thisNode)
                        {
                            First = null;
                            Last = null;
                            Length--;
                            return true;
                        }
                        else if (First == thisNode)
                        {
                            First = thisNode.Next;
                            Length--;
                            return true;
                        }
                        else if (Last == thisNode)
                        {
                            Last = thisNode.Prev;
                            Length--;
                            return true;
                        }
                        else
                        {
                            thisNode.Prev.Next = thisNode.Next;
                            Length--;
                            return true;
                        }
                    }
                    else thisNode = thisNode.Next;
                }
            }

            return false;
        }

        public void SortDoubleListAscByValue()
        {
            Node current = First;
            for (int i = 0; i < Length; i++)
            {
                Node temp = First;
                for (int j = 0; j < Length; j++)
                {

                    if (current.Value < temp.Value)
                    {
                        int tmp = current.Value;
                        current.Value = temp.Value;
                        temp.Value = tmp;
                    }

                    temp = temp.Next;
                }

                current = current.Next;
            }
        }

        public void SortDoubleListDescByValue()
        {
            Node current = First;
            for (int i = 0; i < Length; i++)
            {
                Node temp = First;
                for (int j = 0; j < Length; j++)
                {

                    if (current.Value > temp.Value)
                    {
                        int tmp = current.Value;
                        current.Value = temp.Value;
                        temp.Value = tmp;
                    }

                    temp = temp.Next;
                }

                current = current.Next;
            }
        }

        public void ShowFromStart()
        {
            Node current = First;
            for (int i = 0; i < Length; i++)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }


        public void ShowFromEnd()
        {
            Node current = Last;
            for (int i = 0; i < Length; i++)
            {
                Console.Write(current.Value + " ");
                current = current.Prev;
            }
            Console.WriteLine();
        }


    }
}
