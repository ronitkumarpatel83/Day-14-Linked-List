using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");
            Console.WriteLine("Linked List Data Structure");
            Console.WriteLine("\n1.Add Element at First of Linked List\n2.Append Element at Last of Linked List");
            Console.WriteLine("3.Add Element between two nodes of Linked List\n4.Delete first Element of Linked List");
            Console.WriteLine("5.Delete last Element of Linked List\n6.Seach Element in Linked List");
            Console.WriteLine("7.Insert Element after any Element of LinkedList\n8.Delete any Element of Linked List");
            Console.WriteLine("9.Adding Element in Linked List by ascending Order");
            Console.WriteLine("\nEnter any choice : ");
            int ch = int.Parse(Console.ReadLine());
            CustomLinkedList<int> list = new CustomLinkedList<int>(); // creating a object of CustomLinkedList generic class 

            switch (ch)
            {
                case 1:
                    //Adding Element at first 
                    list.AddFirst(70);
                    list.AddFirst(30);
                    list.AddFirst(56);
                    list.DisplayElement();
                    break;
                case 2:
                    //Append Element at last 
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.DisplayElement();
                    break;
                case 3:
                    //Insert 30 between 56 and 70
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.DisplayElement();
                    list.insertBetween(new Node<int>(56), 30, new Node<int>(70));
                    list.DisplayElement();
                    break;
                case 4:
                    //Delete first element
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.DisplayElement();
                    list.DeleteAtFirst();
                    list.DisplayElement();
                    break;
                case 5:
                    //Delete Last Element
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.DisplayElement();
                    list.DeleteAtLast();
                    list.DisplayElement();
                    break;
                case 6:
                    //Serch element 30
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Search(30);
                    list.DisplayElement();
                    break;
                case 7:
                    //Insert 40 element after 30 
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.DisplayElement();
                    list.InsertElement(30, 40);
                    list.DisplayElement();
                    break;
                case 8:
                    //Delete element 40
                    list.Append(56);
                    list.Append(30);
                    list.Append(40);
                    list.Append(70);
                    list.DisplayElement();
                    list.DeleteElement(40);
                    list.DisplayElement();
                    break;
                case 9:
                    //Add all the element with Ascending Order
                    list.AddWithAcsendingOrder(56);
                    list.AddWithAcsendingOrder(30);
                    list.AddWithAcsendingOrder(40);
                    list.AddWithAcsendingOrder(70);
                    Console.WriteLine("\nAll the element is added in Ascending Order");
                    list.DisplayElement();
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
            Console.ReadLine();
        }
    }
    
}
