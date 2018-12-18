using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWork
{
    class SimpleArrayListStack
    {
        //Instance Variables
        private Object[] entries;
        private int size = 0;

        public int Size { get { return size; } }

        //Constructors
        /// <summary>
        /// default constructor initialises the array at a length of 10
        /// </summary>
        public SimpleArrayListStack()
        {
            entries = new Object[10];
        }

        /// <summary>
        /// Overloaded constructor allows users to specify the length of the array
        /// </summary>
        /// <param name="capacity">the value to be used as the maximum length of the array</param>
        public SimpleArrayListStack(int capacity)
        {
            entries = new Object[capacity];
        }

        /// <summary>
        /// Checks if the stack is empty
        /// </summary>
        /// <returns>True if the size == 0, else returns false </returns>
        public bool IsEmpty()
        {
            if (size == 0) { return true; }
            return false;
        }

        /// <summary>
        /// Check if the stack is at maximum capacity
        /// </summary>
        /// <returns>True if size == the max length of the array, else returns false</returns>
        public bool IsFull()
        {
            if (size == entries.Length) { return true; }
            return false;
        }

        /// <summary>
        /// Adds a new object to the top of the stack
        /// </summary>
        /// <param name="obj">The object to be added to the top of the stack</param>
        public void Push(Object obj)
        {
            if (IsFull()) { throw new InvalidOperationException("Stack is full"); }

            entries[size] = obj;
            size++;
        }

        /// <summary>
        /// Removes the top value of the array and gives it to the user
        /// </summary>
        /// <returns>The object that was the previous top of the stack</returns>
        public Object Pop()
        {
            if (IsEmpty()) { throw new InvalidOperationException("Stack is empty"); }

            Object obj = entries[size - 1];
            size--;
            return obj;
        }

        /// <summary>
        /// returns a copy of the top object in the stack without removing it
        /// </summary>
        /// <returns>The object that is currently the top of the stack</returns>
        public Object Peek()
        {
            if (IsEmpty()) { throw new InvalidOperationException("Stack is empty"); }

            Object obj = entries[size - 1];
            return obj;
        }
    }
}

