using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNQueueUsingGenerics
{
    internal class Stack<T>
    {
        public Node<T> top;
        
        //add data
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("{0} is added", data);
        }

        //display element
        public void Display()
        {
            Node<T> tempTop = top;
            if (this.top == null)
                Console.WriteLine("Stack is empty!!");

            while (tempTop != null)
            {
                Console.WriteLine("Element in stack : " + tempTop.data);
                tempTop = tempTop.next;
            }

        }
    }
}
