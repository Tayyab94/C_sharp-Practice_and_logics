using System;
using System.Collections.Generic;
using System.Text;

namespace c_Sharp
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            //SinglyLinkList linkList = new SinglyLinkList();
            //linkList.Insert_First(12);
            //linkList.Insert_First(123);
            //linkList.Insert_First(152);
            //linkList.Insert_First(162);
            //linkList.Insert_First(122);
            //linkList.DisplayList();

            DemoLinklist_BuiltInFeaturs();
        }


        public static void DemoLinklist_BuiltInFeaturs()
        {

            string[] words = { "the", "actor", "Call", "and", "Jump", "from", "Buss" };
            LinkedList<String> sentence = new LinkedList<string>(words);
            Display(sentence, "The LinkedList Values");

            sentence.AddFirst("Tayyab at first");
            Display(sentence, "Test=1 [Tayyab at the fist] => to the beginning of the list");

            LinkedListNode<string> mark1 = sentence.First;  // LinkedList Node Representing the Node of the List
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence, "Test=2 move the very firs Node of the List to the very last of the node.");


            sentence.RemoveLast();
            sentence.AddLast(" Yester is at last");
            Display(sentence, "Test=3 [Yesterday] => to the last of the list");

            sentence.RemoveFirst();
            LinkedListNode<string> current = sentence.FindLast("and");
            IndicatedNode(current, "Test 5: Indicate last occurence of 'the':");

            sentence.AddAfter(current, "Bs Tayyab");

            sentence.AddAfter(current, "Bhatti");
            IndicatedNode(current, "Test 5: Indicate last occurence of 'the':");

        }

        public static void Display(LinkedList<string> word,string Text)
        {
            Console.WriteLine(Text);

            foreach (var item in word)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }


        public static void IndicatedNode(LinkedListNode<string> node,string text)
        {
            Console.WriteLine(text);

            if(node.List==null)
            {
                Console.WriteLine($"Node {node.Value} is not into the list");
                return;
            }
            StringBuilder result = new StringBuilder("(" + node.Value + ")");

            LinkedListNode<string> nodeP = node.Previous;

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            while (nodeP!=null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Previous;
            }

            
            Console.WriteLine(result);

            Console.WriteLine();
        }
    }


    public class SinglyLinkList
    {

        private Node first;

        public bool isEmpty()
        {
            return (first == null);
        }


        public void Insert_First(int data)
        {
            Node newNode = new Node();  // Create New Node 

            newNode.data = data;  // Assign the data to the new Node
            newNode.next = first;
            first = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Disply List From first to last");
            Node current = first;
            while (current!=null)
            {
                current.display();
                current = current.next;
            }

            Console.WriteLine();
        }

        public void Insert_Last(int data)
        {
            Node current = first;

            while (current.next!=null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }
   public class Node
    {
        public int data;
        public Node next;

        public void display()
        {
            Console.WriteLine($"< {data} >");
        }
    }
}
