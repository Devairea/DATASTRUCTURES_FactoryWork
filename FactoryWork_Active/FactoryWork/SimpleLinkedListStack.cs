using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWork
{
    class SimpleLinkedListStack
    {
        class Node
        {
            //Instance variables
            internal object value;
            internal Node next;

            //Constructor
            public Node(object v, Node n)
            {
                value = v;
                next = n;
            }

            public object Value { get { return value; } }

            public Node Next { get { return next; } }
        }// end of private class node


        //Instance variables
        private Node head;
        private int count;

        /// Check what size the stack is
        /// </summary>
        /// <returns>The size of the linked list</returns>
        public int Size { get { return count; } }

        //Constructors
        /// <summary>
        /// Default constructor sets head to null and count to 0
        /// </summary>
        public SimpleLinkedListStack()
        {
            head = null;
            count = 0;
        }

        /// <summary>
        /// Chacks to see if the stack is empty
        /// </summary>
        /// <returns>True if count == 0, else returns false</returns>
        public bool IsEmpty() { return count == 0; }

        /// <summary>
        /// Check if the stack is full
        /// </summary>
        /// <returns>As a linked list can never be full it will always return false</returns>
        public bool IsFull() { return false; }



        /// <summary>
        /// Add a new element to the list
        /// </summary>
        /// <param name="element">The element to be added</param>
        public void Push(object element)
        {
            head = new Node(element, head);
            count++;
        }

        /// <summary>
        /// Removing an element form the top of stack
        /// </summary>
        /// <returns>The value of the node before it was Poppped</returns>
        public object Pop()
        {
            if (IsEmpty()) { throw new InvalidOperationException("The List is Empty"); }
            object element = head.Value;
            head = head.Next;
            count--;
            return element;
        }

        /// <summary>
        /// Look at the top value of the list
        /// </summary>
        /// <returns>the value store in head</returns>
        public object Peak()
        {
            if (IsEmpty()) { throw new InvalidOperationException("The List is Empty"); }
            return head.Value;
        }
    }
}
