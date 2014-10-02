using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Dinklage<T>
    {
        private Node<T> first;

        // Create the list with a first reference, that will be null/0
        public Dinklage()
        {
            first = new Node<T>();
        }

        // Add data to the list, should add a node at the furthest point
        public void AddEntry(T _data)
        {
            Node<T> temp = first;
            // Iterate through list to find a point without a next element
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.data = _data;
            temp.next = new Node<T>();
        }

        /* Delete a set number of elements based on value
         * Pass in value and number of entries to delete
         * if unspecified function will delete all matching values
        */
        public void DeleteByValue(T _val, int _count = -1)
        {
            Node<T> temp = first;
            // Move through list till next node is null
            while (temp.next != null)
            {
                // Compare values 
                if (EqualityComparer<T>.Default.Equals(temp.data, _val))
                {
                    // If matching entry, remove it from list by setting it's next
                    // Property to the entry beyond it
                    if (temp.next != null)
                    {
                        if (temp == first)
                            first = temp.next;
                        
                        temp = temp.next;
                        _count--;
                    }
                    // If count is zeroed out, we have deleted target number and exit the loop
                    if (_count == 0)
                        break;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }

        // Remove last entry in list
        public void Pop()
        {
            Node<T> temp = first;
            while (temp.next != null)
            {
                // Check if the next node points to null
                // If so, that node needs to be removed as it is the end of the list
                if (temp.next.next == null)
                {
                    temp.next = null;
                    break;
                }
                // Otherwise step ahead one node
                temp = temp.next;
            }
        }

        // Printout all data in list
        public void OutputAll()
        {
            Node<T> temp = first;
            while (temp.next != null)
            {
                Console.WriteLine(" _ " + temp.data + " _ ");
                temp = temp.next;
            }
        }
    }
}
