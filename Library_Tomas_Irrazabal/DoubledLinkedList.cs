using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Tomas_Irrazabal
{
    internal class DoubledLinkedList
    {
        public Node? first {  get; set; }
        public Node? last { get; set; }
        public DoubledLinkedList()
        {
            first = null;
            last = null;
        }

        public void create(Node node)
        {
            if(first == null && last == null)
            {
                first = node;
                last = node;
            }
            else
            {
                Insert(node);
            }
        }
        public void Insert(Node node)
        {
            if(first != null && last != null)
            {
                if(node.value < first.value)
                {
                    node.next = first;
                    first = node;
                }
                if(node.value > last.value)
                {
                    node.prev = last;
                    last = node;
                }
                if(node.value > first.value && node.value < node.value)
                {
                    Node aux = first;
                    while(node.value < aux.value)
                    {
                        if(aux.next!= null)
                        {
                            aux = aux.next;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if(aux.prev!= null)
                    {
                        aux.prev.next = node;
                    }
                    if(aux.next != null)
                    {
                        aux.next.prev = node;
                    }
                    node.prev = aux.prev;
                    node.next = aux;
                }
            }
            else
            {
                create(node);
            }
        }
        public Node Remove(Node node)
        {
            Node? aux = null;
            if (node.value == first.value)
            {
                aux = first;
                if (first == null && last != null) 
                {
                    last = null;
                }
                else
                {
                    if(aux.next != null)
                    {
                        first = first.next;
                        aux.next.prev = null;
                    }
                }
            }
            else
            {
                aux = first;
                while (aux.next != null)
                {
                    if (node.value == aux.value) 
                    {                          
                        if (aux.next != null && aux.prev != null) 
                        {
                            aux.prev.next = aux.next;
                            aux.next.prev = aux.prev;
                            //aux.prev = null;
                            //aux.next = null;
                        }
                        else
                        {
                            last = aux.prev;
                            last.next = null;
                        }
                        break;
                    }
                    aux = aux.next;
                }
            }
            return aux;
        }
    }
}
