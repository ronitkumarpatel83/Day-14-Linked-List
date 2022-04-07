﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Linked_List
{
    internal class CustomLinkedList<T>
    {
        public Node<T> head; // Creatind head if linked list
        public void AddFirst(T data) // creating generic method to Add element at first of linked list
        {
            Node<T> newNode = new Node<T>(data); // Creating a new node 
            if (this.head == null)
            {
                this.head = newNode; // If head pointing to null then hode is directly pointing to new node
                Console.WriteLine($"{newNode.data} is inserted at first of linked list");
                return;
            }
            newNode.next = this.head; // newnode pointing to where head is currently pointing
            this.head = newNode; // head is pointing to new node
            Console.WriteLine($"{newNode.data} is inserted at first of linked list");
        }
        public void DisplayElement() // creating generic method to display element at first of linked list
        {
            {
                Node<T> temp = this.head; // taking head as temp node
                if (temp == null) // If head is null that means linked list is empty
                {
                    Console.WriteLine("\nThe LinledList is Empty");
                    return;
                }
                Console.WriteLine("\nElements of linked list in sequence are : ");
                while (temp != null) // If head is not null then print one by one element of linked list
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next; // Go to next node
                }
            }
        }
        public void Append(T data) // creating generic method to Add element at first of linked list
        {
            Node<T> newNode = new Node<T>(data); // Creating a new node 
            if (this.head == null)
            {
                this.head = newNode; // If head pointing to null then hode is directly pointing to new node
                Console.WriteLine($"{newNode.data} is appended in linked list");
                return;
            }
            else
            {
                Node<T> temp = this.head; // taking head as temp node
                while (temp.next != null) // Find a last node 
                {
                    temp = temp.next;// Go to next node till last nast node               
                }
                temp.next = newNode; // Add new Node at last
                Console.WriteLine($"{newNode.data} is appended in linked list");
            }
        }
        public void insertBetween(Node<T> prevNode, T data, Node<T> nextNode)
        {
            if (prevNode == null && nextNode == null) //Check if the given Node is null
            {
                Console.WriteLine("The given previous node and next node cannot be null");
                return;
            }
            Node<T> newNode = new Node<T>(data); // Allocate the Node & Put in the data          
            newNode.next = nextNode; // Make next of new Node as next of prev_node
            prevNode.next = newNode; //make next of prev_node as new_node
            //this.head = prevNode;
            Console.WriteLine($"{newNode.data} is inserted between {prevNode.data} and {nextNode.data} in linked list");
        }
        public void DeleteAtfirst()
        {
            if (this.head == null) //Checking that list is empty or not
            {
                Console.WriteLine("Linked List is already Empty");
                return;
            }
            Node<T> temp = this.head; // Creating a temp node having head reference
            Console.WriteLine($"\nNow deleting {temp.data} ....");
            this.head = this.head.next;  // Deleting a first node  
        }
        public void DeleteAtLast()
        {
            Node<T> temp = this.head; // Creating a temp node having head reference
            if (temp == null) //Checking that list is empty or not
            {
                Console.WriteLine("Linked List is already Empty");
                return;
            }
            if (temp.next == null) //Checking that list having only one node
            {
                Console.WriteLine($"\nNow deleting {temp.data} ....");
                return;
            }

            while (temp.next.next != null) // Checking that list having atleast 2 nodes
            {
                temp = temp.next; // Go to next node
            }
            Console.WriteLine($"\nNow deleting {temp.next.data} ....");
            temp.next = null; // Deleting a last node       

        }

    }
}
