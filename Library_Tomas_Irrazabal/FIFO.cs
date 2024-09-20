using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Tomas_Irrazabal
{
    internal class FIFO
    {
        public Node first {  get; set; }

        public FIFO()
        {
            first = null;
        }

        public void Insert(Node node)
        {
            if (first == null) 
            {
                first = node;
            }
            else 
            {
                Node aux = first; 
                while (aux.next != null) 
                {
                    aux = aux.next; 
                }
                aux.next = node;
            }
        }
        public Node Remove()
        {
            Node aux = null; 
            if (first != null)
            {
                aux = first;
            }
            return aux;
        }
        public List<Node> ToList()
        {
            List<Node> nodes = new List<Node>();
            Node aux = first; 
            while (aux != null)
            {
                nodes.Add(aux); 
                aux = aux.next; 
            }
            return nodes; 
        }

    }
}
